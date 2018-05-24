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
    public partial class _3_Facility_Management : Form
    {
        public _3_Facility_Management()
        {
            InitializeComponent();
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            _4_Add_Facility fc = new _4_Add_Facility();
            fc.ShowDialog();
        }

        private void delete_Click(object sender, EventArgs e)
        {

            facilityBookingEntities1 ctx = new facilityBookingEntities1();
            Facility_Status fc = ctx.Facility_Status.Where(x => x.Facility == comboBox1.Text).First();
            ctx.Facility_Status.Remove(fc);
            ctx.SaveChanges();
            MessageBox.Show("the facility delete successfully!");
        }

        private void SearchButton_Click(object sender, EventArgs e)
        {

            facilityBookingEntities1 ctx = new facilityBookingEntities1();
            var fid = from x in ctx.Facility_Status
                      where x.Facility == comboBox1.Text
                      select x;

            dataGridView1.DataSource = fid.ToList();
        }

        private void _3_Facility_Management_Load(object sender, EventArgs e)
        {
            // TODO: 这行代码将数据加载到表“facility7a0DataSet1.Facility_Status”中。您可以根据需要移动或删除它。
            this.facility_StatusTableAdapter.Fill(this.facilityBookingDataSet1.Facility_Status);

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void delete_Click_1(object sender, EventArgs e)
        {

        }

        private void _3_Facility_Management_Load_1(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'facilityBookingDataSet1.Facility_Status' table. You can move, or remove it, as needed.
            this.facility_StatusTableAdapter.Fill(this.facilityBookingDataSet1.Facility_Status);

        }

        private void dataGridView1_CellContentClick_1(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
