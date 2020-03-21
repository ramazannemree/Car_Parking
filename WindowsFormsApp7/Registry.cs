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
    public partial class Registry : Form 
    {
       // Form2 form22;
        
        public Registry()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            groupBox1.Parent = pictureBox1;
            label1.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
        }
        customer cs;
        string a;
        DateTime dt;
        private void button1_Click(object sender, EventArgs e)
        {
            
           cs = new customer();
            cs.Name = textBox1.Text;
            cs.Surname = textBox1.Text;
            cs.PlateNo = textBox3.Text;
            cs.TCKN =(textBox5.Text);
            cs.Tel = (textBox6.Text);
            cs.SubscriberType = comboBox2.SelectedItem.ToString();
            dateTimePicker1.Value = DateTime.Now;
            dt = dateTimePicker1.Value;
            cs.Datein = dt.ToString();
            cs.Address = richTextBox1.Text;
            cs.CarBrand = comboBox1.SelectedItem.ToString();
            cs.CarModel = textBox4.Text;
            cs.Payment = (textBox2.Text);
            //cs.Parkarea = comboBox4.SelectedItem.ToString();
            cs.Dateout = a;

            try
            {
                int res = cs.add_car(cs);
                if (res > 0)
                {



                    MessageBox.Show("Kayıt Tamamlandı.");

                    textBox1.Text = "";
                    textBox2.Text = "";
                    textBox3.Text = "";
                    textBox4.Text = "";
                    textBox5.Text = "";
                    textBox6.Text = "";
                    comboBox1.Text = "";
                    comboBox2.Text = "";
                    comboBox3.Text = "";
                    //comboBox4.Text = "";
                    richTextBox1.Text = "";

                }
                else
                {
                    MessageBox.Show("Something Wrong!");
                }
            }
            catch(Exception ex)
            {
                throw new Exception(ex.Message);
            }
           
        }

        private void comboBox2_SelectedValueChanged(object sender, EventArgs e)
        {
            try
            {
                
            
            string selek = comboBox2.Text;
            if (selek == "week")
            {
                textBox2.Text = "40$";

                    dateTimePicker2.Value = DateTime.Now.AddDays(7);
                   a = dateTimePicker2.Value.ToString();
                }
            else if (selek == "month")
            {

                    dateTimePicker2.Value = DateTime.Now.AddMonths(1);
                   a = dateTimePicker2.Value.ToString();
                textBox2.Text = "150$";
            }
            else
            {

                    dateTimePicker2.Value = DateTime.Now.AddYears(1);
                    a = dateTimePicker2.Value.ToString();
                    textBox2.Text = "1000$";
            }
            }
            catch (Exception ex)
            {
                MessageBox.Show("hata register"+ex.Message.ToString());
              //  throw new Exception(ex.Message);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
           this.Close();
            fm.timer1.Start();
        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "Name")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }

        private void textBox5_Click(object sender, EventArgs e)
        {
            if (textBox5.Text == "99999999999")
            {
                textBox5.Text = "";
                textBox5.ForeColor = Color.Black;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "34XY34")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void textBox6_Click(object sender, EventArgs e)
        {
            if (textBox6.Text == "5555555555")
            {
                textBox6.Text = "";
                textBox6.ForeColor = Color.Black;
            }
        }
    }
}
