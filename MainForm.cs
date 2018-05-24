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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void bookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            booking_form bf = new booking_form();
            this.Hide();
            bf.ShowDialog();
        }

        private void cancelBookingToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form_cancelbooking fc = new Form_cancelbooking();
            fc.ShowDialog();
        }

        private void memberUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _1_member_management mm = new _1_member_management();
            mm.ShowDialog();
        }

        private void facilityUpdateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _2_Add_Members am = new _2_Add_Members();
            am.ShowDialog();
        }

        private void facilityManagementToolStripMenuItem_Click(object sender, EventArgs e)
        {
            _3_Facility_Management fm = new _3_Facility_Management();
            fm.ShowDialog();
        }

        private void facilityUpdateToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            _4_Add_Facility af = new _4_Add_Facility();
            af.ShowDialog();
        }
    }
}
