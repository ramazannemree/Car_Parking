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
    public partial class Edit : Form
    {
        public Edit()
        {
            InitializeComponent();
            label1.Parent = pictureBox1;
            label2.Parent = pictureBox1;
            label3.Parent = pictureBox1;
            label4.Parent = pictureBox1;
            label5.Parent = pictureBox1;
            label6.Parent = pictureBox1;
            label7.Parent = pictureBox1;
            label8.Parent = pictureBox1;
            label9.Parent = pictureBox1;
            label10.Parent = pictureBox1;
            label11.Parent = pictureBox1;
            label12.Parent = pictureBox1;
            label16.Parent = pictureBox1;
            label13.Parent = pictureBox1;
            label13.BackColor = Color.Transparent;
            label16.BackColor = Color.Transparent;
            label1.BackColor = Color.Transparent;
            label2.BackColor = Color.Transparent;
            label3.BackColor = Color.Transparent;
            label4.BackColor = Color.Transparent;
            label5.BackColor = Color.Transparent;
            label6.BackColor = Color.Transparent;
            label7.BackColor = Color.Transparent;
            label8.BackColor = Color.Transparent;
            label9.BackColor = Color.Transparent;
            label10.BackColor = Color.Transparent;
            label11.BackColor = Color.Transparent;
            label12.BackColor = Color.Transparent;






        }
        CustomerList c;
        

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Close();
            fm.timer1.Start();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                c = new CustomerList();

                customer cs = new customer();
                cs.Name = textBox1.Text;
                cs.TCKN = textBox5.Text;
                cs.SubscriberType = comboBox2.Text;
                cs.PlateNo = textBox3.Text;
                cs.CarModel = textBox4.Text;
                cs.Tel = textBox6.Text;
                cs.CarBrand = comboBox1.Text;

                int s = cs.edit_user(cs, label1.Text);
                if (s != 0)
                {
                    MessageBox.Show("Succesfully edited");
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
            }
        }
    }
}
