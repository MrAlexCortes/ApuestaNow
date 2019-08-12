using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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

    #endregion

    #region class methods
    
    #endregion
}

