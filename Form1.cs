using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SA46Team07B_ESNET_Project_v2
{

    public partial class booking_form : Form
    {
        public booking_form()
        {
            InitializeComponent();
        }

        facilityBookingEntities1 ctx = new facilityBookingEntities1();

        // 1. upon load of booking form
        private void booking_form_Load(object sender, EventArgs e)
        {

            textBox_date.Text = DateTime.Today.AddDays(1).ToString("dd MMMM yyyy");           

            var findbooking = ctx.Facility_Status.Where(x => x.Date == DateTime.Today).FirstOrDefault();
            if (findbooking == null)

            {
                //   Update column 9-10am till 8-9pm to "Available" status;
                // update date to add today+1 day
                string conString = "Data Source=(local);" +
                "Initial Catalog=facilityBooking;Integrated Security=SSPI";
                SqlConnection cn = new SqlConnection(conString);
                cn.Open();

                string query = "Update [Facility Status] SET" +
                    "[Slot 9-10am]='available'," +
                    "[Slot 10-11am]='available'," +
                    "[Slot 11-12pm]='available'," +
                    "[Slot 12-1pm]='available'," +
                    "[Slot 1-2pm]='available'," +
                    "[Slot 2-3pm]='available'," +
                    "[Slot 3-4pm]='available'," +
                    "[Slot 4-5pm]='available'," +
                    "[Slot 5-6pm]='available'," +
                    "[Slot 6-7pm]='available'," +
                    "[Slot 7-8pm]='available'," +
                    "[Slot 8-9pm]='available'," +
                    "Date =GETDATE()+1 ";
                SqlCommand cm = new SqlCommand(query, cn);
                cm.ExecuteNonQuery();

                //string query11 = "Update [Facility Status] SET [Slot 8-9pm]='available'," +
                //    "Date=GETDATE()+1";
                //SqlCommand cm11 = new SqlCommand(query11, cn);
                //cm11.ExecuteNonQuery();

                cn.Close();
                ctx.SaveChanges();
            }

            DatagridviewDisplay("reset");

        }

        // 2. upon combobox selecton of sport
        private void comboBox_select_sport_SelectedIndexChanged(object sender, EventArgs e)
        {
            DatagridviewDisplay("selected sport");
        }


        // 3. upon selection of time slot inside datagridview
        
        private void dataGridView_bookStatus_CellClick(object sender, DataGridViewCellEventArgs e)
        {
           
            int rowPos = dataGridView_bookStatus.CurrentRow.Index;
            int columnPos = dataGridView_bookStatus.CurrentCell.ColumnIndex;          
            string sport = dataGridView_bookStatus.Columns[rowPos].Name;
            string timeslot = dataGridView_bookStatus.Columns[columnPos].Name;
            if (dataGridView_bookStatus.Rows[rowPos].Cells[columnPos].Value.ToString() == "available")
                BookingMarked(rowPos, columnPos);
            else MessageBox.Show("Please only select available time slot");
        }

        // 4. upon click on 'Book' buttton
        private void button_book_Click(object sender, EventArgs e)
        {
            //Load confirmation form();

            ConfirmationForm loadform = new ConfirmationForm(comboBox_select_sport.Text, Date,TimeSlot);          
            this.Hide();
            loadform.ShowDialog();
        }

        public string Sport
        {
            get { return "Sport"; }
        }

        public DateTime Date
        {
            get { return DateTime.Today.AddDays(1); }
        }
        public string TimeSlot
        {
            get { return "9-10am"; }
        }

        // 5. upon click on 'Cancel' button
        private void button_bookCancel_Click(object sender, EventArgs e)
        {
            int rowPos = dataGridView_bookStatus.CurrentRow.Index;
            int columnPos = dataGridView_bookStatus.CurrentCell.ColumnIndex;
            if (dataGridView_bookStatus.Rows[rowPos].Cells[columnPos].Value == "booked")
                BookingRelease(rowPos, columnPos);
        }


        // below are methods (1) DatagridviewDisplay (2) Bookrelease

        public void DatagridviewDisplay(string whattodisplay)
        {

            if (whattodisplay == "reset")
            {
                var query = from x in ctx.Facility_Status select x;
                List<Facility_Status> flist = query.ToList();
                dataGridView_bookStatus.DataSource = flist;
                comboBox_select_sport.Text = " ";
            }
            else
            {
                var query = from x in ctx.Facility_Status
                            where x.Facility == comboBox_select_sport.Text
                            select x;
                List<Facility_Status> flist = query.ToList<Facility_Status>();
                dataGridView_bookStatus.DataSource = flist;
            }

        }

        public void BookingMarked(int RowPos, int ColumnPos)
        {
            dataGridView_bookStatus.Rows[RowPos].Cells[ColumnPos].Style.BackColor = Color.Blue;
            dataGridView_bookStatus.Rows[RowPos].Cells[ColumnPos].Value = "booked";
        }
        public void BookingRelease(int RowPos, int ColumnPos)
        {

            {
                dataGridView_bookStatus.Rows[RowPos].Cells[ColumnPos].Style.BackColor = Color.White;
                dataGridView_bookStatus.Rows[RowPos].Cells[ColumnPos].Value = "available";
            }

        }

        private void button_reset_Click(object sender, EventArgs e)
        {
            DatagridviewDisplay("reset");
        }               
        
        
    }
}

