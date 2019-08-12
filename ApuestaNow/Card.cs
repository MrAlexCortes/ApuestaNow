using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;


public class Card
{
    #region attributes
    private int _id;
    private string _cardNumber;
    private string _expirationDate;
    private string _cardHolder;
    private string _ccv;

    #endregion

    #region properties
    public int Id
    {
        get { return _id; }
    }

    public string CardNumber
    {
        get { return _cardNumber; }
        set { _cardNumber = value; }
    }

    public string ExpirationDate
    {
        get { return _expirationDate; }
        set { _expirationDate = value; }
    }

    public string CardHolder
    {
        get { return _cardHolder; }
        set { _cardHolder = value; }
    }

    public string CCV
    {
        get { return _ccv; }
        set { _ccv = value; }
    }
    #endregion

    #region constructors
    public Card()
    {
        _id = 0;
        _cardNumber = "";
        _expirationDate = "";
        _cardHolder = "";
        _ccv = "";
    }

    public Card(int id, string number, string name, string expirationDate, string ccv)
    {
        _id = id;
        _cardNumber = number;
        _expirationDate = name;
        _cardHolder = expirationDate;
        _ccv = ccv;
    }
    #endregion

    #region static methods
    public static List<Card> GetAll(int user)
    {
        List<Card> list = new List<Card>();

        // query
        string query = @"select carUniNumber, carNumber, carExpDate, carHolder, carCCV
                            from ANUser
                                Join User_Card on useNumber = ucUser
                                Join Card on ucCard = carUniNumber
                            where ucUser = @IDUSER";

        SqlCommand command = new SqlCommand(query); //command
        command.Parameters.AddWithValue("@IDUSER", user); //assign value of id to the parameter
        DataTable table = SqlServerConnection.ExecuteQuery(command); //execute query

        // read table rows
        foreach (DataRow row in table.Rows)
        {
            //read each field
            int id = (int)row["carUniNumber"];
            string cardNumber = (string)row["carNumber"];
            string expirationDate = (string)row["carExpDate"];
            string cardHolder = (string)row["carHolder"];
            string ccv = (string)row["carCCV"];

            //add player to list
            list.Add(new Card(id, cardNumber, expirationDate, cardHolder, ccv));
        }

        return list; //return list
    }

    public static bool AddCard(string number, string name, string expdate, string ccv, int user)
    {
        string query = "select MAX(carUniNumber) as LastCard from Card";
        SqlCommand command = new SqlCommand(query); //command
        DataTable table = SqlServerConnection.ExecuteQuery(command); //execute query

        int lastid = 0;
        foreach (DataRow row in table.Rows)
        {
            lastid = (int)row["LastCard"];
        }

        lastid++;
        if (lastid != 0)
        {
            string query2 = @"BEGIN TRANSACTION
                                    INSERT INTO Card values(@carNumber, @carExpDate, @carHolder, @carCCV)
                                    INSERT INTO User_Card VALUES(@ucUser, @ucCard)
                                COMMIT";
            SqlCommand command2 = new SqlCommand(query2); //command
            command2.Parameters.AddWithValue("@carNumber", number);
            command2.Parameters.AddWithValue("@carExpDate", expdate);
            command2.Parameters.AddWithValue("@carHolder", name);
            command2.Parameters.AddWithValue("@carCCV", ccv);
            command2.Parameters.AddWithValue("@ucUser", user);
            command2.Parameters.AddWithValue("@ucCard", lastid);
            if (SqlServerConnection.ExecuteNonQuery(command2) > 0)
                return true; //command executed successfully
            else
                return false; //could not execute command
        }
        else
            return false;
    }

    public static bool DeleteCard(int id, int user)
    {

            string query = @"BEGIN TRANSACTION
                                    Delete from User_Card where ucCard = @carUniNumber AND ucUser = @user
                                    Delete from Tarjeta where tarNumUnico = @carUniNumber
                                COMMIT";
            SqlCommand command = new SqlCommand(query); //command
            command.Parameters.AddWithValue("@carUniNumber", id);
            command.Parameters.AddWithValue("@user", user);
            if (SqlServerConnection.ExecuteNonQuery(command) > 0)
                return true; //command executed successfully
            else
                return false; //could not execute command
    }
    #endregion
}

