using BOL;
namespace DAL.UsersDataAccess;
using MySql.Data.MySqlClient;
using System.Data;
 
public class UsersDataAccess
{
    public static string conString = @"server=localhost; port=3306; user=root; password=123456; database=empinfo";
    public static List<Employee> GetAllEmployees()
    {
        List<Employee> allemps = new List<Employee>();
        MySqlConnection con = new MySqlConnection(conString);

        try
        {
            string query = "select * from employees";
            DataSet ds = new DataSet();
            MySqlCommand cmd = new MySqlCommand(query, con);
            MySqlDataAdapter da = new MySqlDataAdapter(cmd);
            da.Fill(ds);

            DataTable dt = ds.Tables[0];
            DataRowCollection rows = dt.Rows;
            foreach (DataRow row in rows)
            {
                Employee e = new Employee
                {
                    Empid = int.Parse(row["Empid"].ToString()),
                    Ename = row["Ename"].ToString(),
                    Sal = double.Parse(row["Sal"].ToString()),
                };
                allemps.Add(e);
            }
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
        return allemps;
    }

    // public static User GetUserById(int id)
    // {
    //     User user = null;
    //     MySqlConnection con = new MySqlConnection(conString);

    //     try
    //     {
    //         con.Open();
    //         string query = "select * from users where userid=" + id;
    //         MySqlCommand command = new MySqlCommand(query, con);
    //         MySqlDataReader reader = command.ExecuteReader();

    //         if (reader.Read())
    //         {
    //             user = new User
    //             {
    //                 userid = int.Parse(reader["userid"].ToString()),
    //                 username = reader["username"].ToString(),
    //                 course = reader["course"].ToString(),
    //                 purchasedate = reader["purchasedate"].ToString()
    //             };
    //         }

    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }
    //     finally
    //     {
    //         con.Close();
    //     }
    //     return user;
    // }

    // public static void SaveNewUser(User user)
    // {
    //     MySqlConnection con = new MySqlConnection(conString);

    //     try
    //     {
    //         con.Open();
    //         string query = $"insert into users(username, course, purchasedate) values('{user.username}', '{user.course}', '{user.purchasedate}')";
    //         MySqlCommand command = new MySqlCommand(query, con);
    //         command.ExecuteNonQuery();
    //         con.Close();
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }
    //     finally
    //     {
    //         con.Close();
    //     }
    // }

    // public static void DeleteUserById(int id)
    // {
    //     MySqlConnection con = new MySqlConnection(conString);

    //     try
    //     {
    //         con.Open();
    //         string query = "delete from users where userid =" + id;
    //         MySqlCommand command = new MySqlCommand(query, con);
    //         command.ExecuteNonQuery();
    //         con.Close();
    //     }
    //     catch (Exception e)
    //     {
    //         Console.WriteLine(e.Message);
    //     }
    //     finally
    //     {
    //         con.Close();
    //     }
    // }

}