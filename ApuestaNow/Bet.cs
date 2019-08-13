using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

public class Bet
{
    #region attributes
    private int _id;
    private int _amount;
    private Team _team;
    private Match _match;
    private User _user;
    #endregion

    #region properties
    public int Id
    {
        get { return _id; }
    }

    public int Amount
    {
        get { return _amount; }
        set { _amount = value; }
    }

    public Team Team
    {
        get { return _team; }
        set { _team = value; }
    }

    public Match Match
    {
        get { return _match; }
        set { _match = value; }
    }

    public User User
    {
        get { return _user; }
        set { _user = value; }
    }

    #endregion

    #region constructors
    public Bet()
    {
        _id = 0;
        _amount = 0;
        _team = new Team();
        _match = new Match();
        _user = new User();

    }
    #endregion

    #region instance methods
    public bool NewBet()
    {
        string query = @"BEGIN TRANSACTION
                            insert into Bet values(@AMOUNT, @USER, @TEAM, @MATCH)
                            update Match set matTotalBets = (matTotalBets + @AMOUNT) where matNumber = @MATCH
                            update Match_Team set mtTeamBets = (mtTeamBets + @AMOUNT) where mtMatch = @MATCH and mtTeam = @TEAM
                        COMMIT";
        SqlCommand command = new SqlCommand(query); //command
        command.Parameters.AddWithValue("@AMOUNT", _amount);
        command.Parameters.AddWithValue("@USER", _user.Number);
        command.Parameters.AddWithValue("@TEAM", _team.Id);
        command.Parameters.AddWithValue("@MATCH", _match.Id);
        if (SqlServerConnection.ExecuteNonQuery(command) > 0)
            return true; //command executed successfully
        else
            return false; //could not execute command
    }
    #endregion

    #region class methods
    /*public static List<Bet> GetAll()
    {
        List<Bet> list = new List<Bet>();

        // query
        string query = @"select teamCode, teamName, teamJJ, teamJG, teamJE, teamJP, teamGF,
                        teamGC, teamPoints from Teams
						order by teamPoints desc, teamJG desc, teamJE desc, teamGF desc;";

        SqlCommand command = new SqlCommand(query); //command
        DataTable table = SqlServerConnection.ExecuteQuery(command); //execute query

        // read table rows
        foreach (DataRow row in table.Rows)
        {
            //read each field
            string id = (string)row["teamCode"];
            string teamName = (string)row["teamName"];
            int teamJJ = (int)row["teamJJ"];
            int teamJG = (int)row["teamJG"];
            int teamJE = (int)row["teamJE"];
            int teamJP = (int)row["teamJP"];
            int teamGF = (int)row["teamGF"];
            int teamGC = (int)row["teamGC"];
            int teamPoints = (int)row["teamPoints"];

            //add player to list
            list.Add(new Team(id, teamName, teamJJ, teamJG, teamJE, teamJP, teamGF, teamGC, teamPoints));
            
        }

        return list; //return list
    }
    */
    #endregion
}

