using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
namespace WindowsFormsApp7
{
    public partial class Login : Form
    {
      
       
        

        DataTable d;
        admin a;
       
        public Login()
        {
            InitializeComponent();
            label3.Parent = pictureBox1;
            
            lblMessage.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            pictureBox2.Parent = pictureBox1;
            pictureBox2.BackColor = Color.Transparent;
            groupBox1.Parent = pictureBox1;
            groupBox1.BackColor = Color.Transparent;
            textBox2.BackColor = Login.DefaultBackColor;
            pictureBox3.BackColor = Color.White;
            pictureBox4.BackColor = Color.White;


            lblMessage.BackColor = Color.Transparent;
            

            
        }

        

        private void button1_Click_1(object sender, EventArgs e)
        {
            


            string user = textBox2.Text;
            string pass = textBox3.Text;

            if (user == "")
            {
                lblMessage.Visible = false;
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Please enter email.";
                
                textBox2.Focus();
                return;
            }

            if (pass == string.Empty)
            {
                lblMessage.Visible = false;
                lblMessage.ForeColor = Color.Red;
                lblMessage.Text = "Please enter password";
                
                textBox3.Focus();
                return;
            }
            d = new DataTable();
            
            a = new admin();
            a.Username = textBox2.Text;
            a.Password = textBox3.Text;
            d = a.sorgula(a);
            int sorgu = a.login(a);
            if (sorgu > 0)
            {
                
                Form2 fm = new Form2();
                chart_home ch = new chart_home();

                fm.Show();
                this.Hide();
                fm.timer1.Start();
                

            }
            else
            {
                MessageBox.Show("Yanlıs sifre girdiniz.Tekrar Deneyin!");
            }

        }

        private void textBox2_Click(object sender, EventArgs e)
        {
            if (textBox2.Text == "Username")
            {
                textBox2.Text = "";
                textBox2.ForeColor = Color.Black;
            }
        }

        private void textBox3_Click(object sender, EventArgs e)
        {
            if (textBox3.Text == "Password")
            {
                textBox3.Text = "";
                textBox3.ForeColor = Color.Black;
            }
        }

        private void Login_MouseDown(object sender, MouseEventArgs e)
        {

        }

        private void Login_MouseUp(object sender, MouseEventArgs e)
        {

        }

        private void Login_MouseMove(object sender, MouseEventArgs e)
        {

        }
    }
}
