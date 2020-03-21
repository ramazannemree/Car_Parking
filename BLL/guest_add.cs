using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using DAL;
namespace BLL
{
    public class guest_add:car
    {
        
        private string entrytime;
        private DateTime date_in;
        private DateTime date_out;
        
        public string Entrytime { get => entrytime; set => entrytime = value; }
        public DateTime Date_in { get => date_in; set => date_in = value; }
        public DateTime Date_out { get => date_out; set => date_out = value; }

       // guest_add g;
         DataAccess da;
     //   DateTime datetime;
       // DataTable dt;

            public DataTable sorgu(guest_add g)
            {
            da = new DataAccess();
            string query = string.Format("SELECT * FROM user WHERE plate='{0}'  ", g.PlateNo);
            return da.dataErisim(query);
        }
        DataTable d;
        public  int addguest(guest_add g)
        {
            d = new DataTable();
            d = sorgu(g);
            if (d.Rows.Count>0)
            {
                string query = string.Format("UPDATE user set parkarea='1' WHERE plate='{0}'", g.PlateNo);
                DataAccess da = new DataAccess();
                return da.executeNonQuery(query);
            }
            else
            {
                string query = string.Format("INSERT INTO user(name,surname,tel,TCKN,sub_payment,date_in,address,car_model,plate,car_brand,payment,parkarea) VALUES('','','','','guest','{0}','','','{1}','','','1')", g.Date_in.ToString(), g.PlateNo);
                DataAccess da = new DataAccess();
                return da.executeNonQuery(query);
            }
        }

        


        //public int addguest(guest_add g)
        //{
        //    try
        //    {
               
        //        //string query = string.Format("INSERT INTO user(name,surname,tel,TCKN,sub_payment,date_in,address,car_model,plate,car_brand,payment,parkarea) VALUES('','','','','guest','{0}','','','{1}','','1','')",g.Date_in.ToString(),g.PlateNo);
        //        string query = string.Format("UPDATE user set parkarea='1' WHERE plate='{0}'",g.PlateNo);
        //        DataAccess da = new DataAccess();

        //        return da.executeNonQuery(query);
        //    }

        //    catch(Exception e)
        //    {
        //        throw new Exception(e.Message);
        //    }
        //}
        public DataTable learn_subtype(string plate)
        {
            string query = string.Format("SELECT * FROM user WHERE plate='{0}'", plate);
            da = new DataAccess();
             d = new DataTable();

            return da.dataErisim(query);

        }
        //public guest_add exit_guest(guest_add g)
        //{
        //    g = new guest_add();
        //    dt = new DataTable();
        //    //Date_out = DateTime.Now.ToString();
        //    string query = string.Format("SELECT * FROM user WHERE plate='{0}", g.PlateNo);
        //   dt= da.dataErisim(query);
        //    if (dt.Rows.Count > 0)
        //    {
        //        g.PlateNo = dt.Rows[0]["plate"].ToString();
        //       // g.Date_in = dt.Rows[0][""];

        //    }
        //}


    }
}
