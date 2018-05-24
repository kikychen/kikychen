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
    public partial class FormSimple : Form
    {
        public FormSimple()
        {
            InitializeComponent();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {
            
        }

        private void FormSimple_Load(object sender, EventArgs e)
        {
            facilityBookingEntities1 ctx = new facilityBookingEntities1();
            CrystalReport10 cr = new CrystalReport10();
            cr.SetDataSource(ctx.Transaction_Records);
            crystalReportViewer1.ReportSource = cr;
        }
    }
}
