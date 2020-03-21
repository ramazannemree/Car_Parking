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
    public partial class Form2 : Form
    {
        Registry registry;


        public Form2()
        {


            InitializeComponent();
            circularProgressBar1.Value = 0;
            
            groupBox1.Parent = pictureBox1;
            groupBox2.Parent = pictureBox1;
            groupBox2.BackColor = Color.Transparent;
            groupBox1.BackColor = Color.Transparent;
            
            label4.Parent = pictureBox1;
            label4.BackColor = Color.Transparent;
            circularProgressBar1.Parent = pictureBox1;
            circularProgressBar1.BackColor = Color.Transparent;
            label3.Parent = pictureBox1;
            label3.BackColor = Color.Transparent;
            
            pictureBox2.BackColor = Color.Transparent;
            
            button2.BackColor = Color.Transparent;
            
            button3.BackColor = Color.Transparent;
            
            button4.BackColor = Color.Transparent;



            chart_home ch = new chart_home();
            


            label4.Text = (20 - ch.find_empty()).ToString();

        }

        customer cs;
        private void button2_Click(object sender, EventArgs e)
        {
            registry = new Registry();
            registry.Show();
            this.Close();

        }
        

        //  customer cs;
        DataTable dt;
        private void button1_Click(object sender, EventArgs e)
        {
            cs = new customer();
            dt = new DataTable();

            try
            {


                cs.PlateNo = textBox1.Text;
                dt = cs.plate_query(cs.PlateNo);


                string subtype = dt.Rows[0]["sub_payment"].ToString();
                string tp;

                if (subtype == "guest")
                {
                    tp = "Guest";
                }


                else
                {
                    tp = "Subscriber";
                }
                if (tp == "Subscriber")
                {


                    textBox2.Text = dt.Rows[0]["name"].ToString();
                    textBox3.Text = dt.Rows[0]["car_brand"].ToString();
                    textBox4.Text = dt.Rows[0]["car_model"].ToString();
                    textBox5.Text = dt.Rows[0]["TCKN"].ToString();
                    textBox6.Text = tp;
                }
                else
                {
                    textBox2.Text = dt.Rows[0]["name"].ToString();
                    textBox3.Text = "-";
                    textBox4.Text = "-";
                    textBox5.Text = "-";
                    textBox6.Text = tp;

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("No such plate in park! " +ex.Message);
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            GuestEntry ge = new GuestEntry();
            ge.Show();
            this.Close();

        }

        private void button3_Click(object sender, EventArgs e)
        {

            CustomerList cs = new CustomerList();
            cs.Show();
            this.Close();


        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {


                if (textBox1.Text == "")
                {
                    MessageBox.Show("Please enter plate");
                }
                customer c = new customer();
                guest_add g = new guest_add();
                string plate = textBox1.Text;
                DataTable t = g.learn_subtype(plate);
                string t2 = t.Rows[0]["sub_payment"].ToString();
                if (t2 == "guest")
                {

                    double hour;
                    g.Date_out = DateTime.Now;
                    string a = t.Rows[0]["date_in"].ToString();
                    DateTime d = DateTime.Parse(a.ToString());
                    TimeSpan tspn = g.Date_out - d;
                    hour = double.Parse(tspn.TotalHours.ToString());
                    int pay = Convert.ToInt16(hour) * 5;
                    textBox7.Text = pay.ToString() + "$";

                    c.PlateNo = textBox1.Text;
                    c.exit_user(c.PlateNo);
                    c.delete_customer(c.PlateNo);
                    MessageBox.Show("Succesfully Exit");

                }
                else
                {
                    textBox7.Text = "Subscriber";
                    c.PlateNo = textBox1.Text;
                    c.exit_user(c.PlateNo);
                    MessageBox.Show("Succesfully Exit");
                }


                textBox1.Text = "";
                textBox2.Text = "";
                textBox3.Text = "";
                textBox4.Text = "";
                textBox5.Text = "";
                textBox6.Text = "";
                textBox7.Text = "";


            }
            catch (Exception ex)
            {
                MessageBox.Show("There is an error");
            }

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "34XY34")
            {
                textBox1.Text = "";
                textBox1.ForeColor = Color.Black;
            }
        }
        int saniye = 0;
        private void timer1_Tick(object sender, EventArgs e)
        {
            saniye++;
            if (saniye == 1)
            {

                chart_home ch = new chart_home();
                int x = ch.find_empty();
                
                for (int i = 0; i <= x; i++)
                {
                    Thread.Sleep(20);
                    circularProgressBar1.Value = i;

                }

                timer1.Stop();

            }
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Cursor = Cursors.Hand;
            panel2.Visible = true;
            button2.ForeColor = Color.Black;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.White;
            panel2.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Cursor = Cursors.Hand;
            panel3.Visible = true;
            button4.ForeColor = Color.Black;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.White;
            panel3.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Cursor = Cursors.Hand;
            panel4.Visible = true;
            button3.ForeColor = Color.Black;
        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.White;
            panel4.Visible = false;
        }
    }
}
