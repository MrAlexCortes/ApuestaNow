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
    #endregion

    #region constructors

    #endregion

    #region class methods
    public static List<Match> GetMatchesOfTheWeek()
    {
        List<Match> list = new List<Match>();

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

