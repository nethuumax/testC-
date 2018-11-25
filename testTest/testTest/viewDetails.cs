using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace testTest
{
    public partial class viewDetails : UserControl
    {
        private static viewDetails _instance;

        public static viewDetails Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new viewDetails();
                return _instance;
            }
        }
        public viewDetails()
        {
            InitializeComponent();
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8IFF65O\SQLEXPRESS;database=TEST;integrated security=true");

        private void viewDetails_Load(object sender, EventArgs e)
        {

        }
        public void Searchemp()
        {
            Employee db = new Employee();
            DataSet ds = db.Searchcardid();
            table1.DataSource = ds.Tables["load"];

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Searchemp();
        }

        //private void table1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{
        //    int r = e.RowIndex;
        //    DataGridViewRow selectedRow = table1.Rows[r];

        //    fname.Text = selectedRow.Cells[0].Value.ToString();
        //    lname.Text = selectedRow.Cells[1].Value.ToString();
        //    nic.Text = selectedRow.Cells[2].Value.ToString();
        //    position.Text = selectedRow.Cells[3].Value.ToString();
        //    telephone.Text = selectedRow.Cells[4].Value.ToString();
        //    salary.Text = selectedRow.Cells[5].Value.ToString();
           
        //}

        private void table1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {
            int r = e.RowIndex;
            DataGridViewRow selectedRow = table1.Rows[r];

            fname.Text = selectedRow.Cells[0].Value.ToString();
            lname.Text = selectedRow.Cells[1].Value.ToString();
            nic.Text = selectedRow.Cells[2].Value.ToString();
            position.Text = selectedRow.Cells[3].Value.ToString();
            telephone.Text = selectedRow.Cells[4].Value.ToString();
            slary.Text = selectedRow.Cells[5].Value.ToString();

        }
        public void updateEmployee()
        {
            Employee db = new Employee();
            db.UpdateDetails(fname.Text, lname.Text, nic.Text, position.Text, telephone.Text, slary.Text);

        }

        public void deleteEmp()
        {
            Employee db = new Employee();
            db.DeleteDetails(nic.Text);
        }
        private void button2_Click(object sender, EventArgs e)
        {
            updateEmployee();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            deleteEmp();
        }
    }
}
