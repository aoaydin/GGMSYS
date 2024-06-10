using System;
using System.Data;
using System.Data.SqlClient;

public static class DBHelper
{
    private static string connectionString = "Server=DATASRV;Database=GGMSYS;Trusted_Connection=True;";

    // Veritabanı bağlantısı almak için kullanılır
    public static SqlConnection GetConnection()
    {
        return new SqlConnection(connectionString);
    }

    // SELECT sorguları için kullanılır
    public static DataTable ExecuteSelectCommand(string commandText, CommandType cmdType, SqlParameter[] parameters = null)
    {
        DataTable table = new DataTable();
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = cmdType;
                if (parameters != null)
                {
                    cmd.Parameters.AddRange(parameters);
                }
                conn.Open();
                using (SqlDataAdapter da = new SqlDataAdapter(cmd))
                {
                    da.Fill(table);
                }
            }
        }
        return table;
    }


    public static object ExecuteScalar(string commandText, CommandType commandType = CommandType.Text, SqlParameter[] parameters = null)
    {
        using (SqlConnection connection = new SqlConnection(connectionString))
        {
            using (SqlCommand command = new SqlCommand(commandText, connection))
            {
                command.CommandType = commandType;

                if (parameters != null)
                {
                    command.Parameters.AddRange(parameters);
                }

                connection.Open();
                return command.ExecuteScalar();
            }
        }
    }

    // INSERT, UPDATE, DELETE sorguları için kullanılır
    public static int ExecuteNonQuery(string commandText, CommandType cmdType, SqlParameter[] parameters = null)
    {
        int result = 0;
        using (SqlConnection conn = GetConnection())
        {
            using (SqlCommand cmd = new SqlCommand(commandText, conn))
            {
                cmd.CommandType = cmdType;
                if (parameters != null) 
                {
                    cmd.Parameters.AddRange(parameters);
                }
                conn.Open();
                result = cmd.ExecuteNonQuery();
            }
        }
        return result;
    }


}
