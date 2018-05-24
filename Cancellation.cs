using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace SA46Team07B_ESNET_Project_v2
{
    public partial class Form_cancelbooking : Form
    {
        public Form_cancelbooking()
        {
            InitializeComponent();
        }
         SqlConnection con = new SqlConnection("Data Source = (local);" +
"Initial Catalog=facilityBooking;Integrated Security=SSPI");
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //if (comboBox1.Text == "TransactionID")
            //{
            //    SqlDataAdapter Sda = new SqlDataAdapter("SELECT TransactionID, MemberID, Facility FROM TransactionRecord Where TransactionID LIKE'" + textBox1.Text + "%'", con);
            //    DataTable data = new DataTable();
            //    Sda.Fill(data);
            //    dataGridView1.DataSource = data;
            //}
            //else if (comboBox1.Text == "MemberID")
            //{
            //    SqlDataAdapter Sda = new SqlDataAdapter("SELECT TransactionID, MemberID, Facility FROM TransactionRecord Where MemberID LIKE'" + textBox1.Text + "%'", con);
            //    DataTable data = new DataTable();
            //    Sda.Fill(data);
            //    dataGridView1.DataSource = data;
            //}
    }

            private void button2_Click(object sender, EventArgs e)
            {
            string conString = "Data Source=(local);" +
                "Initial Catalog=facilityBooking;Integrated Security=SSPI";
            SqlConnection cn = new SqlConnection(conString);
            cn.Open();

            String query = "DELETE FROM [Transaction Records] where " +
                "Facility='"+comboBox2.Text+"' AND TimeSlot='"+ comboBox3.Text+"'" +
                "AND Date=GETDATE()+1";
            SqlCommand cm11 = new SqlCommand(query, cn);
            cm11.ExecuteNonQuery();
            cn.Close();

            MessageBox.Show("Delete successful, thank you!");
            this.Hide();
            MainForm mf = new MainForm();
            mf.ShowDialog();

            //SqlDataAdapter Sda = new SqlDataAdapter(query, con);
            //Sda.SelectCommand.ExecuteNonQuery();
            //con.Close();
   //         MessageBox.Show("RECORD DELETED");

   //       string query1 = "UPDATE [Facility status] SET textBox2.Text ='available' Where facility = '" + comboBox1.Text + "'";
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            //textBox1.Text = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            //textBox2.Text= dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //SqlDataAdapter Sda = new SqlDataAdapter("SELECT TransactionID, MemberID, Facility FROM [Transaction Record] Where TimeSlot='" + textBox2.Text +"'", con);
            //DataTable data = new DataTable();
            //Sda.Fill(data);
            //dataGridView1.DataSource = data;

        }
    }
}

