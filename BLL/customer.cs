using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
using System.Data;
namespace BLL
{

   public class customer : car
    {

        private string name;
        private string surname;
        private string tCKN;
     
        private string subscriberType;
        private string parkarea;
        private string payment;
        private string datein; 
        private string dateout;
        private string address;
        private string tel;


        public string Name { get => name; set => name = value; }
        public string Surname { get => surname; set => surname = value; }
        public string TCKN { get => tCKN; set => tCKN = value; }
      
        public string SubscriberType { get => subscriberType; set => subscriberType = value; }
        
        public string Payment { get => payment; set => payment = value; }
        public string Address { get => address; set => address = value; }
        public string Datein { get => datein; set => datein = value; }
        public string Dateout { get => dateout; set => dateout = value; }
        public string Tel { get => tel; set => tel = value; }
        public string Parkarea { get => parkarea; set => parkarea = value; }
       
        //DataAccess da;
        public int add_car(customer c)
        {
           
            try
            {
                
                // string query = string.Format("INSERT INTO user(name,surname,tel,TCKN,sub_payment,address,car_model,plate,car_brand,payment,parkarea) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}',33,'aa')", c.Name,c.Surname,c.Tel,c.tCKN,c.SubscriberType,c.Address, c.CarModel, c.PlateNo, c.CarBrand);
                string query = string.Format("INSERT INTO user (name,surname,tel,TCKN,sub_payment,date_in,date_out,address,car_model,plate,car_brand,payment) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')", c.Name, c.Surname, c.Tel, c.TCKN, c.SubscriberType,c.Datein,c.Dateout, c.Address, c.CarModel, c.PlateNo, c.CarBrand,c.Payment);
               //string query = string.Format("INSERT INTO admin VALUES('aa','bb')");
                
               DataAccess daa = new DataAccess();
               
                return daa.executeNonQuery(query);
            }
            catch (Exception e)
            {
                throw new Exception(e.Message);
                
            }
        }
        DataAccess da;
        DataTable dt;
        public DataTable plate_query(string plate)
        {

            string query = string.Format("SELECT * FROM user WHERE plate = '{0}' ", plate);
            da = new DataAccess();
            return da.dataErisim(query);

        }
        public int edit_user(customer c,string plate)
        {
             da = new DataAccess();
            string query = string.Format("UPDATE user set name='{0}', plate='{1}', address='{2}', tel='{3}',TCKN='{4}', car_brand='{5}', car_model='{6}', sub_payment='{7}' WHERE plate='{8}'", c.Name, c.PlateNo, c.Address, c.Tel, c.TCKN, c.CarBrand, c.CarModel,c.SubscriberType,plate);
            return da.executeNonQuery(query);
        }

        public DataTable show_user()
        {
             da = new DataAccess();
            string query = string.Format("SELECT * FROM user WHERE parkarea='1'");
             dt = new DataTable();
            dt = da.dataErisim(query);
            return dt;
        }
        public DataTable show_all()
        {
             da = new DataAccess();
            string query = string.Format("SELECT * FROM user");
             dt = new DataTable();
            dt = da.dataErisim(query);
            return dt;
        }

        public int delete_customer(string plate)
        {
            string query = string.Format("DELETE FROM user WHERE plate='{0}'", plate);
             da = new DataAccess();
            return da.executeNonQuery(query);
        }
        public int exit_user(string plate)
        {
            string query = string.Format("UPDATE user set parkarea='0' WHERE plate='{0}'", plate);
             da = new DataAccess();
            return da.executeNonQuery(query);

        }
    }
}