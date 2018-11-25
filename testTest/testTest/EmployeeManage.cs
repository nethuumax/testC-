using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace testTest
{
    public partial class EmployeeManage : System.Windows.Forms.Form
    {

        public EmployeeManage()
        {
            InitializeComponent();
        }

        private void EmployeeManage_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label2_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void button1_Click_1(object sender, EventArgs e)
        {

            //{
            //    indi.Top = ((System.Windows.Forms.Button)sender).Top - 0;

            //}
            if (!panel3.Controls.Contains(UserControl1.Instance))
            {
                panel3.Controls.Add(UserControl1.Instance);
                UserControl1.Instance.Dock = DockStyle.Fill;
                UserControl1.Instance.BringToFront();
            }
            else
                UserControl1.Instance.BringToFront();


        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (!panel3.Controls.Contains(viewDetails.Instance))
            {
                panel3.Controls.Add(viewDetails.Instance);
                viewDetails.Instance.Dock = DockStyle.Fill;
                viewDetails.Instance.BringToFront();
            }
            else
                viewDetails.Instance.BringToFront();


        }
    }

}
