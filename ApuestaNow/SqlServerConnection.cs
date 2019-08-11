using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration; // for app.config
using System.Data.SqlClient; // for SQL Server
using System.Data; // for generic data

class SqlServerConnection
{
    #region ClassVariables

    private static SqlConnection connection = new SqlConnection();

    #endregion

    #region ClassMethods

    /// <summary>
    /// Opens a connection to a SQL Server database
    /// </summary>
    /// <returns></returns>
    private static bool OpenConnection()
    {
        bool connected = false; //result
        try
        {
            //assign connection string
            if (connection.State == ConnectionState.Closed)
            {
                connection.ConnectionString = ConfigurationManager.ConnectionStrings["cs"].ConnectionString;
                connection.Open();
            }
            //successful connection
            connected = true;
        }
        catch (NullReferenceException ex)
        {
            //for debugging only
            Console.WriteLine("Connection string does not exist in app.config");
            Console.WriteLine(ex.Message);
        }
        catch (ArgumentException ex)
        {
            //for debugging only
            Console.WriteLine("Check spelling in connection string in app.config");
            Console.WriteLine(ex.Message);
        }
        catch (SqlException ex)
        {
            //for debugging only
            Console.WriteLine("Check server name, database name or credentials in connection string");
            Console.WriteLine(ex.Message);
        }
        catch (Exception ex)
        {
            //for debugging only
            Console.WriteLine("WTF happend ?!?!");
            Console.WriteLine(ex.Message);
        }
        return connected; //return result
    }

    /// <summary>
    /// Executes a query and returns the resulting table
    /// </summary>
    /// <param name="command">SQL command</param>
    /// <returns></returns>
    public static DataTable ExecuteQuery(SqlCommand command)
    {
        DataTable table = new DataTable(); //result table
        //open connection
        if (OpenConnection())
        {
            try
            {
                command.Connection = connection; //assign connection
                SqlDataAdapter adapter = new SqlDataAdapter(command); //adapter
                adapter.Fill(table); //execute query and populate result table
                connection.Close(); //close connection
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Check syntax in query");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("WTF happend ?!?!");
                Console.WriteLine(ex.Message);
            }
        }
        return table; //retur result
    }

    /// <summary>
    /// Executes a non query SQL command and returns the number of affected rows
    /// </summary>
    /// <param name="command">SQL command</param>
    /// <returns></returns>
    public static int ExecuteNonQuery(SqlCommand command)
    {
        int affectedRows = 0; //result
        //open connection
        if (OpenConnection())
        {
            try
            {
                command.Connection = connection; //assign connection
                affectedRows = command.ExecuteNonQuery(); //execute non query
                connection.Close(); //close connection
            }
            catch (SqlException ex)
            {
                Console.WriteLine("Check syntax in query");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("WTF happend ?!?!");
                Console.WriteLine(ex.Message);
            }
        }
        return affectedRows; //return result
    }

    #endregion
}
