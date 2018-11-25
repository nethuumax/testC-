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
    public partial class UserControl1 : UserControl
    {
        private static UserControl1 _instance;

        public static UserControl1 Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new UserControl1();
                return _instance;
            }
        }
        SqlConnection con = new SqlConnection(@"Data Source=DESKTOP-8IFF65O\SQLEXPRESS;database=TEST;integrated security=true");
        public UserControl1()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Employee ds = new Employee();
            ds.Register(fname.Text, lname.Text, nic.Text, position.Text, telephone.Text, slary.Text);
        }
       

        private void fname_Enter_1(object sender, EventArgs e)
        {
            if (fname.Text == "First Name")
            {
                fname.Text = "";
                fname.ForeColor = Color.Black;
            }

        }
    }
}
