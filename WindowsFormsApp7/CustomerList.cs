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
    public partial class CustomerList : Form
    {
        Edit ed;
        public CustomerList()
        {
            customer c = new customer();
            InitializeComponent();
            
            DataTable dt = new DataTable();

            dt = c.show_user();
            dataGridView1.DataSource = dt;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            ed = new Edit();
            ed.textBox1.Text = name;
            ed.textBox5.Text = tckn;
            ed.comboBox1.SelectedItem = brand;
            ed.comboBox2.Text = sub_payment;
            ed.textBox4.Text = model;
            ed.textBox3.Text = plate;
            ed.textBox6.Text = tel;
            ed.dateTimePicker1.Text = date_in;
            ed.dateTimePicker2.Text = date_out;
            ed.richTextBox1.Text = address;
            ed.comboBox3.SelectedIndex = 0;
            ed.label1.Text = plate;
            if (sub_payment == "week")
            {
                ed.textBox2.Text = "40$";
            }
            else if(sub_payment == "month")
            {
                ed.textBox2.Text = "150$";
            }
            else if(sub_payment=="year")
            {
                ed.textBox2.Text = "1000$";
            }
            else if(sub_payment=="guest")
            {
                ed.textBox2.Text = "Guest";
            }
            ed.Show();
            this.Close();

        }

        
        
        DataGridViewRow selectedRow;
        
        string name, plate, address, tel, tckn, brand, model ,sub_payment,date_in,date_out,payment,parkarea;

        private void button5_MouseHover(object sender, EventArgs e)
        {
            button5.Cursor = Cursors.Hand;
            panel5.Visible = true;
            button5.ForeColor = Color.White;
        }

        private void button5_MouseLeave(object sender, EventArgs e)
        {
            button5.ForeColor = Color.Black;
            panel5.Visible = false;
        }

        private void button4_MouseHover(object sender, EventArgs e)
        {
            button4.Cursor = Cursors.Hand;
            panel6.Visible = true;
            button4.ForeColor = Color.White;
        }

        private void button4_MouseLeave(object sender, EventArgs e)
        {
            button4.ForeColor = Color.Black;
            panel6.Visible = false;

        }

        private void button3_MouseLeave(object sender, EventArgs e)
        {
            button3.ForeColor = Color.Black;
            panel4.Visible = false;
        }

        private void button3_MouseHover(object sender, EventArgs e)
        {
            button3.Cursor = Cursors.Hand;
            panel4.Visible = true;
            button3.ForeColor = Color.White;
        }

        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.ForeColor = Color.Black;
            panel3.Visible = false;
        }

        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.Cursor = Cursors.Hand;
            panel3.Visible = true;
            button2.ForeColor = Color.White;
        }

        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.ForeColor = Color.Black;
            panel2.Visible = false;
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.Cursor = Cursors.Hand;
            panel2.Visible = true;
            button1.ForeColor = Color.White;
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            DataTable dt = new DataTable();
            dt = c.show_user();
            dataGridView1.DataSource = dt;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            customer c = new customer();
            DataTable dt = new DataTable();
            dt = c.show_all();
            dataGridView1.DataSource = dt;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                customer cs = new customer();
              
                int res = cs.delete_customer(plate);
                if (res != 0)
                {
                    MessageBox.Show("Deleted succesfuly");
                    DataTable dt = new DataTable();
                    
                    dt = cs.show_user();
                    dataGridView1.DataSource = dt;
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show("There is error" + ex.Message);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            
            int rowindex = e.RowIndex;
            selectedRow= dataGridView1.Rows[rowindex];
           
            name =selectedRow.Cells[1].Value.ToString();
            plate= selectedRow.Cells[10].Value.ToString();
            address = selectedRow.Cells[8].Value.ToString();
            tel = selectedRow.Cells[3].Value.ToString();
            tckn = selectedRow.Cells[4].Value.ToString();
            brand = selectedRow.Cells[11].Value.ToString();
            model = selectedRow.Cells[9].Value.ToString();
            sub_payment = selectedRow.Cells[5].Value.ToString();
            date_in = selectedRow.Cells[6].Value.ToString();
            date_out = selectedRow.Cells[7].Value.ToString();
            payment = selectedRow.Cells[12].Value.ToString();
            parkarea = selectedRow.Cells[13].Value.ToString();


        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 fm = new Form2();
            fm.Show();
            this.Close();
            fm.timer1.Start();
        }

    }
}
