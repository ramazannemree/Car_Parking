using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
using System.Data.SQLite;
namespace BLL
{
   
   public class chart_home
    {
        DataAccess da;
        DataTable dt;
        public int find_empty()
        {
            string query = string.Format("SELECT * FROM user WHERE parkarea='1'");
            da = new DataAccess();
            dt = da.dataErisim(query);
            return dt.Rows.Count;
        }


        
     

    }
}
