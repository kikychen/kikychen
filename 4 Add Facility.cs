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
    public partial class _4_Add_Facility : Form
    {
        public _4_Add_Facility()
        {
            InitializeComponent();
        }

        private void MIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void submit_Click(object sender, EventArgs e)
        {
            Facility_Status fs = new Facility_Status();
            facilityBookingEntities1 ctx = new facilityBookingEntities1();
            using (TransactionScope ts = new TransactionScope())
            fs.Facility = MIDTextBox.Text;
            fs.Slot_9_10am = comboBox1.Text;
            fs.Slot_10_11am = comboBox1.Text;
            fs.Slot_11_12pm = comboBox1.Text;
            fs.Slot_12_1pm = comboBox1.Text;
            fs.Slot_1_2pm = comboBox1.Text;
            fs.Slot_2_3pm = comboBox1.Text;
            fs.Slot_3_4pm = comboBox1.Text;
            fs.Slot_4_5pm = comboBox1.Text;
            fs.Slot_5_6pm = comboBox1.Text;
            fs.Slot_6_7pm = comboBox1.Text;
            fs.Slot_7_8pm = comboBox1.Text;
            fs.Slot_8_9pm = comboBox1.Text;
            fs.Slot_9_10am = comboBox1.Text;


        }

        private void slot1_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
