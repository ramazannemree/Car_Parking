using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DAL;
namespace BLL
{
    public class car
    {


        
        private string carModel;
        private string carBrand;
        private string plateNo;


       
      
        public string CarModel { get => carModel; set => carModel = value; }
        public string CarBrand { get => carBrand; set => carBrand = value; }
        public string PlateNo { get => plateNo; set => plateNo = value; }
       
    }

   

    
}
