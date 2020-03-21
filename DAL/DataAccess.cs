using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SQLite;

namespace DAL
{
    
    public class DataAccess
    {
        DataTable dt;
        SQLiteConnection con;
        SQLiteCommand cmd;
        public DataAccess()
        {
            con = new SQLiteConnection();
            con.ConnectionString = @"Data Source=..\..\..\DAL\db\dtbs.db";
            cmd = new SQLiteCommand(con);
        }
        public int executeNonQuery(string query)
        {
            con.Open();

            cmd.CommandText = query;
            cmd.CommandType = CommandType.Text;
            //cmd.Parameters.Add(new SQLiteParameter("@pr1", username));
            //cmd.Parameters.Add(new SQLiteParameter("@pr2", password));
           
            
           
            return cmd.ExecuteNonQuery();
        }
        public DataTable dataErisim(string query)
        {
            try
            {
                dt = new DataTable();
                con.Open();
                cmd.CommandText = query;
                cmd.CommandType = CommandType.Text;
                SQLiteDataAdapter adapter = new SQLiteDataAdapter(cmd);
                adapter.Fill(dt);
                con.Close();
                return dt;

            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
            }
        }
    }
}
