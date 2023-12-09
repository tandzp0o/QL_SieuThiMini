using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QL_SieuThiMini
{
    public partial class Report_DoanhThu : Form
    {
        public Report_DoanhThu()
        {
            InitializeComponent();
        }

        private void Report_DoanhThu_Load(object sender, EventArgs e)
        {
            Report_DoanhThu rpt = new Report_DoanhThu();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();
        }
    }
}
