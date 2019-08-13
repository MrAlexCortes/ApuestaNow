using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

public class Match
{
    #region attributes
    private int _id;
    private DateTime _date;
    private int _week;
    private string _teamName;
    private int _teamBets;
    #endregion

    #region properties
    public int Id
    {
        get { return _id; }
    }

    public DateTime Date
    {
        get { return _date; }
        set { _date =  value; }
    }

    public int Week
    {
        get { return _week; }
        set { _week = value; }
    }

    public string TeamName
    {
        get { return _teamName; }
        set { _teamName = value; }
    }

    public int TeamBets
    {
        get { return _teamBets; }
        set { _teamBets = value; }
    }
    #endregion

    #region constructors

    public Match()
    {
        _id = 0;
        _teamName = "";
        _teamBets = 0;
        _date = new DateTime();
        _week = 0;
    }

    public Match(int id)
    {
        //query
        string query = "select matNumber, matDate, matWeek, matTotalBets from Match where matNumber = @ID"; 
        SqlCommand command = new SqlCommand(query); //command
        command.Parameters.AddWithValue("@ID", id);//assign value of user number to the parameter
        DataTable table = SqlServerConnection.ExecuteQuery(command); //execute query
        //read now 
        if (table.Rows.Count > 0)
        {
            //read first andd only row found
            DataRow row = table.Rows[0];
            //read each field andd assign the values to the attributes
            _id = (int)row["matNumber"];
            _date = (DateTime)row["matDate"];
            _week = (int)row["matWeek"];
            _teamBets = (int)row["matTotalBets"];
        }
        else
            throw new RecordNotFoundException(id);
    }

    public Match(int matchId, string teamName, int teamBets, DateTime matchDate, int week)
    {
        _id = matchId;
        _date = matchDate;
        _teamName = teamName;
        _teamBets = teamBets;
    }
    #endregion

    #region class methods
    public static List<Match> GetMatchesOfTheWeek(int week)
    {
        List<Match> list = new List<Match>();

        // query
        string query = @"select matNumber, teamName, mtTeamBets, matDate
                        from Teams
                          Join Match_Team on mtTeam = teamCode
                          Join Match on mtMatch = matNumber
                          where matWeek = @WEEK";

        SqlCommand command = new SqlCommand(query); //command
        command.Parameters.AddWithValue("@WEEK", week);
        DataTable table = SqlServerConnection.ExecuteQuery(command); //execute query

        // read table rows
        foreach (DataRow row in table.Rows)
        {
            //read each field
            int matchId = (int)row["matNumber"];
            string teamName = (string)row["teamName"];
            int teamBets = (int)row["mtTeamBets"];
            DateTime matchDate = (DateTime)row["matDate"];

            list.Add(new Match(matchId, teamName, teamBets, matchDate, week));
        }

        return list; //return list
    }
    #endregion
}

