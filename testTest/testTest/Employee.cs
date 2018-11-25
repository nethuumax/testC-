using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testTest
{
    class Employee
    {

        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8IFF65O\SQLEXPRESS;database=TEST;integrated security=true");

        public void AddEmployeeDetails(string fname,string lname,string nic,string position,string telephone,string slary)
        {
            string quary = "insert into addEmp (fname,lname,nic,position,telephone,slary) values('" + fname + "','" + lname + "','" + nic + "','" + position + "','" + telephone + "','" + slary + "')";
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            SqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = quary;
                cmd.ExecuteNonQuery();

                // MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, "your details are successfully added.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("your details are successfully added.");

            }
            catch (Exception e1)
            {
                //   MetroFramework.MetroMessageBox.Show(Form1.ActiveForm, " " + e1, "Fail", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" " + e1, "Fail");
            }
            con.Close();


        }
        public void Register(string fname, string lname, string nic, string position, string telephone, string slary)

        {
            if (fname != "" && lname != "" && nic != "" && position != "" && telephone != "" && slary != "" )
            {
                //double salary1 = double.Parse(salary);
                //int rpt1 = int.Parse(rpt);
                //int rpot1 = int.Parse(rpot);
                AddEmployeeDetails(fname, lname, nic, position, telephone, slary);


            }
            else
            {
                MessageBox.Show("can't have empty value");
            }
        }
        public void DeleteDetails(String nic)
        {

            string qu = ("DELETE  FROM addEmp WHERE  nic ='" + nic + "'");

            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            SqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = qu;
                cmd.ExecuteNonQuery();

                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "your details are successfully Update.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" successfully delete.");
            }
            catch (Exception e1)
            {
                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, " " + e1,   MessageBox.Show(" "+ e1, "Fail");, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" " + e1, "Fail");
            }
            con.Close();
        }
        public void UpdateDetails(string fname, string lname, string nic, string position, string telephone, string slary)
        {
            //SqlConnection con = new SqlConnection("server=localhost;user id=root;database=dbfire");
            string qu = "Update addEmp SET fname = '" + fname + "',lname = '" + lname + "', nic = '" + nic + "', position = '" + position + "', telephone = '" + telephone + "', slary= '" + slary + "' where nic = '" + nic + "' ";
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            SqlCommand cmd = con.CreateCommand();

            try
            {
                cmd.CommandType = CommandType.Text;
                cmd.CommandText = qu;
                cmd.ExecuteNonQuery();

                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, "your details are successfully Update.", "Successfull", MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show("your details are successfully update.");
            }
            catch (Exception e1)
            {
                // MetroFramework.MetroMessageBox.Show(Form.ActiveForm, " " + e1,   MessageBox.Show(" "+ e1, "Fail");, MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
                MessageBox.Show(" " + e1, "Fail");
            }
            con.Close();
        }
        public DataSet Searchcardid()
        {
            
            string query = ("SELECT * FROM addEmp");
            if (con.State.ToString() == "Closed")
            {
                con.Open();
            }

            try
            {
                SqlCommand cmdg = con.CreateCommand();
                cmdg.Connection = con;
                cmdg.CommandType = CommandType.Text;

                cmdg.CommandText = query;

                SqlDataAdapter deta = new SqlDataAdapter(cmdg);
                DataSet ds = new DataSet();
                deta.Fill(ds, "load");

                con.Close();
                return ds;
            }
            catch (Exception)
            {
                MessageBox.Show("Somthing wrong. Please check your database connection.");
                DataSet ee = new DataSet();
                return ee;
            }

        }
    }
}
