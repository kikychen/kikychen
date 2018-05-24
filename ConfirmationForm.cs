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
    public partial class ConfirmationForm : Form
    {
        public ConfirmationForm(string sport,DateTime date, string timeslot)
        {
            InitializeComponent();
            textBox_sport.Text = sport;            
            textBox_date.Text = date.ToString();
            textBox_time.Text = timeslot;
        }

        private void ConfirmationForm_Load(object sender, EventArgs e)
        {
            
        }

        private void button_confirm_Click(object sender, EventArgs e)
        {
            //facilityBookingEntities1 ctx1 = new facilityBookingEntities1();
            //Transaction_Record _Record = new Transaction_Record
            //{
            //    MemberID = Int32.Parse(textBox_memberID.Text),
            //    Facility = textBox_sport.Text, // Sport??
            //    Date = DateTime.Now.AddDays(1),
            //    TimeSlot = textBox_time.Text, // Timeslot??
            //    status = "booked"
            //};
            //ctx1.Transaction_Records.Add(_Record);
            //ctx1.SaveChanges();
            MessageBox.Show("Thank you, your booking is confirmed");
            MainForm mf = new MainForm();
            this.Hide();
            mf.ShowDialog();

            // update database 'transactions records'
            // update database 'facility status' avail->booked
            // messagebox 'thank you, your booking is confirmed'
            // back to home page
        }

        private void button_confirmCancel_Click(object sender, EventArgs e)
        {
            //return to bookingform and display status
            MainForm Tomain = new MainForm();
            this.Hide();
            Tomain.ShowDialog();

        }

        private void button_member_Click(object sender, EventArgs e)
        {

        }
    }
}
