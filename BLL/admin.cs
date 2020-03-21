using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{
    public abstract class giris
    {
        public abstract DataTable sorgula(admin a);
        public abstract int login(admin a);
    }
    public class admin:giris
    {
        
        private string username;
        private string password;
        DataAccess dt;

        public string Username { get => username; set => username = value; }
        public string Password { get => password; set => password = value; }
        public override DataTable sorgula(admin a)
        {

             dt = new DataAccess();


             string query = string.Format("SELECT * FROM admin WHERE username='{0}' and password='{1}' ", a.Username,a.Password);
          //  string query = string.Format("SELECT * FROM admin  ");
            return dt.dataErisim(query);

            
        }
        DataTable d;
        public override int login(admin a)
        {
         d = new DataTable();
            d =sorgula(a);
            if (d.Rows.Count > 0)
            {
                return 1;
            }
            else return 0;
            
        }
        //public int calc_gain()
        //{

        //}

    }
}
