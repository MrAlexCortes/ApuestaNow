using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

public class User
{
    #region Attributes

    private int _useNumber;
    private string _useUser;
    private string _useFirName;
    private string _useFirSurname;
    private string _useSecSurname;
    private string _useEmail;
    private string _useTel;
    private int _useCredits;
    private string _usePassword;
    private DateTime _useBirthDate;

    #endregion

    #region Propierties

    public int Number
    {
        get { return _useNumber; }
        set { _useNumber = value; }
    }
    public string UserName
    {
        get { return _useUser; }
        set { _useUser = value; }
    }
    public string FirstName
    {
        get { return _useFirName; }
        set { _useFirName = value; }
    }
    public string FirstSurname
    {
        get { return _useFirSurname; }
        set { _useFirSurname = value; }
    }
    public string SecondSurname
    {
        get { return _useSecSurname; }
        set { _useSecSurname = value; }
    }
    public string Email
    {
        get { return _useEmail; }
        set { _useEmail = value; }
    }
    public string TelephoneNumber
    {
        get { return _useTel; }
        set { _useTel = value; }
    }
    public int Credits
    {
        get { return _useCredits; }
        set { _useCredits = value; }
    }
    public string Password
    {
        get { return _usePassword; }
        set { _usePassword = value; }
    }
    public DateTime BirthDate
    {
        get { return _useBirthDate; }
        set { _useBirthDate = value; }
    }

    #endregion

    #region Constructors

    public User()
    {
        _useNumber = 0;
        _useUser = "";
        _useFirName = "";
        _useFirSurname = "";
        _useSecSurname = "";
        _useEmail = "";
        _useTel = "";
        _useCredits = 0;
        _usePassword = "";
        _useBirthDate = new DateTime();
    }

    public User(string user, string password)
    {
        string sha1 = Encrypt(password);

        string query = "select useNumber, useUser, usePassword from ANUser where useUser=@USER and usePassword=@PASSWORD";
        SqlCommand command = new SqlCommand(query);
        command.Parameters.AddWithValue("@USER", user);
        command.Parameters.AddWithValue("@PASSWORD", sha1);
        DataTable table = SqlServerConnection.ExecuteQuery(command);

        if (table.Rows.Count == 1)
        {
            DataRow row = table.Rows[0];
            _useNumber = (int)row["useNumber"];
            _useUser = (string)row["useUser"];
            _usePassword = (string)row["usePassword"];
        }
    }

    public User(int number)
    {
        //query
        string query = @"select useNumber, useUser, useFirName, useFirSurname, useSecSurname, useEmail,
                       useTel, useCredits, usePassword, convert(datetime, useBirthDate, 101) as useBirthDate from ANUser where useNumber=@USERNUMBER";
        SqlCommand command = new SqlCommand(query); //command
        command.Parameters.AddWithValue("@USERNUMBER", number);//assign value of user number to the parameter
        DataTable table = SqlServerConnection.ExecuteQuery(command); //execute query
        //read now 
        if (table.Rows.Count > 0)
        {
            //read first andd only row found
            DataRow row = table.Rows[0];
            //read each field andd assign the values to the attributes
            _useNumber = (int)row["useNumber"];
            _useUser = (string)row["useUser"];
            _useFirName = (string)row["useFirName"];
            _useFirSurname = (string)row["useFirSurname"];
            _useSecSurname = (string)row["useSecSurname"];
            _useEmail = (string)row["useEmail"];
            _useTel = (string)row["useTel"];
            _useCredits = (int)row["useCredits"];
            _usePassword = (string)row["usePassword"];
            _useBirthDate = (DateTime)row["useBirthDate"];
        }
        else
            throw new RecordNotFoundException(number);
    }

    /// <summary>
    /// Creates a User object with data from the arguments
    /// </summary>
    /// <param name="useNumber">User Number</param>
    /// <param name="useUser">User</param>
    /// <param name="useFirName">First Name</param>
    /// <param name="useFirSurname">First Surname</param>
    /// <param name="useSecSurname">Second Surname</param>
    /// <param name="useEmail">Email</param>
    /// <param name="useTel">Telephone number</param>
    /// <param name="useCredits">Credits</param>
    /// <param name="useBirthDate">Birth Date</param>
    public User(int useNumber, string useUser, string useFirName, string useFirSurname, string useSecSurname, string useEmail, string useTel, int useCredits, DateTime useBirthDate)
    {
        _useNumber = useNumber;
        _useUser = useUser;
        _useFirName = useFirName;
        _useFirSurname = useFirSurname;
        _useSecSurname = useSecSurname;
        _useEmail = useEmail;
        _useTel = useTel;
        _useCredits = useCredits;
        _useBirthDate = useBirthDate;

    }

    #endregion


    #region Instance Methods
    public bool ModifyCredits(bool sum, int amount)
    {
        string query;

        if (sum)
            query = "update ANUser set useCredits = (useCredits + @amount) where useNumber = @userId";
        else
            query = "update ANUser set useCredits = (useCredits - @amount) where useNumber = @userId";

        SqlCommand command2 = new SqlCommand(query); //command
        command2.Parameters.AddWithValue("@amount", amount);
        command2.Parameters.AddWithValue("@userId", _useNumber);

        if (SqlServerConnection.ExecuteNonQuery(command2) > 0)
        {
            if (sum)
                _useCredits = _useCredits + amount;
            else
                _useCredits = _useCredits - amount;

            return true;
        }
        else
            return false; //could not execute command
    }

    public bool UpdateInfo(string firstName, string firstSurname, string secondSurname, string email, string tel, DateTime dob)
    {
        string query = @"update ANUser set useFirName = @FIRSTNAME, useFirSurname = @FIRSTSURNAME, useSecSurname = @SECONDSURNAME, useEmail = @EMAIL, 
                        useTel = @TEL, useBirthDate = convert(datetime, @DOB, 101) where useNumber = @USERID";


        SqlCommand command = new SqlCommand(query); //command
        command.Parameters.AddWithValue("@FIRSTNAME", firstName);
        command.Parameters.AddWithValue("@USERID", _useNumber);
        command.Parameters.AddWithValue("@FIRSTSURNAME", firstSurname);
        command.Parameters.AddWithValue("@SECONDSURNAME", secondSurname);
        command.Parameters.AddWithValue("@EMAIL", email);
        command.Parameters.AddWithValue("@TEL", tel);
        command.Parameters.AddWithValue("@DOB", dob);

        if (SqlServerConnection.ExecuteNonQuery(command) > 0)
            return true;
        else
            return false;
    }
    #endregion

    #region Class Methods

    #endregion

    public string Encrypt(string password)
    {
        var sha1 = new System.Security.Cryptography.SHA1Managed();
        var plaintextBytes = Encoding.UTF8.GetBytes(password);
        var hashBytes = sha1.ComputeHash(plaintextBytes);

        var sb = new StringBuilder();
        foreach (var hashByte in hashBytes)
        {
            sb.AppendFormat("{0:x2}", hashByte);
        }

        return sb.ToString().ToUpper();
    }
}

