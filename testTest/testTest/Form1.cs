using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8IFF65O\SQLEXPRESS;database=TEST;integrated security=true");


        private void bunifuThinButton21_Click(object sender, EventArgs e)
        {
            con.Open();

            SqlCommand cmd = new SqlCommand("select NAME,ID from EMP where NAME='" + bunifuTextBox2.Text + "'and ID='" + bunifuTextBox1.Text + "'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            if (dt.Rows.Count > 0)
            {
                MessageBox.Show("Login sucess Welcome to Homepage");
                EmployeeManage frm = new EmployeeManage();
                //Form2 frm = new Form2();
              
               frm.Show();

                //this.Close();

            }
            else
            {
                MessageBox.Show("Invalid Login please check username and password");
            }
            con.Close();

        }

        private void bunifuTextBox2_TextChange(object sender, EventArgs e)
        {

        }

        private void bunifuTextBox2_TextChange_1(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label3_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
    }
}
