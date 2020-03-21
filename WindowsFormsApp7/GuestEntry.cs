using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace WindowsFormsApp7
{
    public partial class GuestEntry : Form
    {
        public GuestEntry()
        {
            InitializeComponent();
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Close();
            fm.timer1.Start();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int adition = 0;
            try
            {
                string plate = textBox1.Text;
            DateTime dateTime =DateTime.Now;
            guest_add g = new guest_add();
            g.Date_in = dateTime;
            g.PlateNo = plate;
           
            adition= g.addguest(g);
                
            if (adition != 0)
            {
                MessageBox.Show("Succesfully added.");
            }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is An error!"+ex.Message);
            }
           
           
            
                
            
        }
    }
}
