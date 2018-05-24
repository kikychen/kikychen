using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace SA46Team07B_ESNET_Project_v2
{
    public partial class _2_Add_Members : Form
    {
        public _2_Add_Members()
        {
            InitializeComponent();
        }
        private void MemTextBox_TextChanged(object sender, EventArgs e)
        {

        }
        private void MIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void MNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void AddressTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void PCTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void ConTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void EmialTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void SubmitButton_Click(object sender, EventArgs e)
        {
            facilityBookingEntities1 ctx = new facilityBookingEntities1();
            using (TransactionScope ts = new TransactionScope())
            {
                int PC = Convert.ToInt32(PCTextBox.Text);
                double PN = Convert.ToDouble(ConTextBox.Text);
                int ID = Convert.ToInt32(MemTextBox.Text);

                Member mem = new Member();

                mem.FirstName = MIDTextBox.Text;
                mem.LastName = MNameTextBox.Text;
                mem.TitleOfCountery = comboBox1.Text;
                mem.Address = AddressTextBox.Text;
                mem.PostalCode = PC;
                mem.PhoneNumber = PN;
                mem.EmailAddress = EmialTextBox.Text;
                mem.MemberID = ID;

                ctx.Members.Add(mem);
                ctx.SaveChanges();
                ts.Complete();
            }

            this.Close();




        }

        private void _2_Add_Member_Load(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
    }
}
