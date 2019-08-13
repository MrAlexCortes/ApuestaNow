using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
public class Team
{
    #region attributes
    private string _id;
    private string _name;
    private int _gamesPlayed;
    private int _wins;
    private int _draws;
    private int _losses;
    private int _goalsScored;
    private int _goalsAgainst;
    private int _points;
    #endregion

    #region properties
    public string Id
    {
        get { return _id; }
    }

    public string Name
    {
        get { return _name; }
    }

    public int GamesPlayed
    {
        get { return _gamesPlayed; }
        set { _gamesPlayed = value; }
    }

    public int Wins
    {
        get { return _wins; }
        set { _wins = value; }
    }

    public int Draws
    {
        get { return _draws; }
        set { _draws = value; }
    }

    public int Losses
    {
        get { return _losses; }
        set { _losses = value; }
    }

    public int GoalsScored
    {
        get { return _goalsScored; }
        set { _goalsScored = value; }
    }

    public int GoalsAgainst
    {
        get { return _goalsAgainst; }
        set { _goalsAgainst = value; }
    }

    public int Points
    {
        get { return _points; }
        set { _points = value; }
    }
    #endregion

    #region Constructors
    public Team()
    {
        _id = "";
        _name = "";
        _gamesPlayed = 0;
        _wins = 0;
        _draws = 0;
        _losses = 0;
        _goalsScored = 0;
        _goalsAgainst = 0;
        _points = 0;
    }

    public Team(string name)
    {
        //query
        string query = "select teamCode, teamName, teamJJ, teamJG, teamJE, teamJP, teamGF, teamGC, teamPoints from Teams where teamName = @NAME";
        SqlCommand command = new SqlCommand(query); //command
        command.Parameters.AddWithValue("@NAME", name);//assign value of user number to the parameter
        DataTable table = SqlServerConnection.ExecuteQuery(command); //execute query
        //read now 
        if (table.Rows.Count > 0)
        {
            //read first andd only row found
            DataRow row = table.Rows[0];
            //read each field andd assign the values to the attributes
            _id = (string)row["teamCode"];
            _name = (string)row["teamName"];
            _gamesPlayed = (int)row["teamJJ"];
            _wins = (int)row["teamJG"];
            _draws = (int)row["teamJE"];
            _losses = (int)row["teamJP"];
            _goalsScored = (int)row["teamGF"];
            _goalsAgainst = (int)row["teamGC"];
            _points = (int)row["teamPoints"];
        }
        else
            throw new RecordNotFoundException(name);
    }

    public Team(string id, string name, int jj, int jg, int je, int jp, int gf, int gc, int points)
    {
        _id = id;
        _name = name;
        _gamesPlayed = jj;
        _wins = jg;
        _draws = je;
        _losses = jp;
        _goalsScored = gf;
        _goalsAgainst = gc;
        _points = points;
    }
    #endregion

    #region Instance Methods

    #endregion

    #region Class Methods
    public static List<Team> GetAll()
    {
        List<Team> list = new List<Team>();

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
    #endregion
}

