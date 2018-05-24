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
    public partial class _1_member_management : Form
    {
        public _1_member_management()
        {
            InitializeComponent();
        }

        private void MIDTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
           this.memberTableAdapter.Fill(this.facilityBookingDataSet.Member);

        }

        private void SearchButton_Click(object sender, EventArgs e)
        {
            int mtt = Convert.ToInt32(MIDTextBox.Text);
            facilityBookingEntities1 ctx = new facilityBookingEntities1();
            var mid = from x in ctx.Members
                      where x.MemberID == mtt
                      select x
                 ;
            dataGridView1.DataSource = mid.ToList();
        }

        private void delete_Click(object sender, EventArgs e)
        {
            int mtt = Convert.ToInt32(MIDTextBox.Text);
            facilityBookingEntities1 ctx = new facilityBookingEntities1();
            Member me = ctx.Members.Where(x => x.MemberID == mtt).First();
            ctx.Members.Remove(me);
            ctx.SaveChanges();
            MessageBox.Show("the member delete successfully!");

        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            _2_Add_Members sd = new _2_Add_Members();
            sd.ShowDialog();
        }

       

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
