using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team07B_ESNET_Project_v2
{
    public partial class Log_In : Form
    {
        static int attempt;
        public Log_In()
        {
            InitializeComponent();
            attempt = 5;
        }

        string conString = "Data Source=(local);" +
                "Initial Catalog=facilityBooking;Integrated Security=SSPI";
        //SqlConnection cn = new SqlConnection(conString);
        //cn.Open();
        private void button3_Click(object sender, EventArgs e)
        {
            
            facilityBookingEntities1 context = new facilityBookingEntities1();
            string EmployeeID = textBox2.Text;
            string Password = textBox1.Text;
            var qry = (from x in context.Employee_Accounts select x.EmployeeID).First();
            var qry1 = (from x in context.Employee_Accounts select x.Password).First();
            if ((qry == EmployeeID) && (qry1 == Password))
            {
             //   attempt = 0;
                Log_In f = new Log_In();
                f.Show();
                this.Hide();
                MainForm mf = new MainForm();
                mf.ShowDialog();
            }
            else if ((attempt <= 5) && (attempt > 0))
            {
                attempt = attempt - 1;
                MessageBox.Show("Unmatched password and ID,You Have Only " + Convert.ToString(attempt) + " Attempt Left To Try");
            }
            else
            {
                MessageBox.Show("you cannot log in the system now");
                this.Close();
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
