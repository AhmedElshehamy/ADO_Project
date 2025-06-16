using System.Data;
using Microsoft.Data.SqlClient;

namespace Ecommerce.DataAcess
{
    public class DbContext
    {

        SqlConnection con;

        public DbContext(string connnection)
        {
            // Getting Data From DataBase
            con = new SqlConnection(connnection);
        }

        // Excute (Select)

        public DataTable ExcuteQuery(string cmd)
        {


            SqlCommand commend = new SqlCommand(cmd, con);

            SqlDataAdapter adapter = new SqlDataAdapter(commend);

            DataTable dt = new DataTable();
            adapter.Fill(dt);
            return dt;
        }

        // NonExcuteQuery (Insert  , Update , Delete) Using Connected Mode

        public int ExecuteNonQuery(string cmd)
        {
            SqlCommand commend = new SqlCommand(cmd, con);
            int rowAffected = 0;
            try
            {
                con.Open();
                rowAffected = commend.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Error {ex.Message}");
                throw;
            }
            finally
            {
                if (con.State == ConnectionState.Open)
                {
                    con.Close();
                }
            }
            return rowAffected;
        }
    }
}
