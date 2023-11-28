using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;

namespace QL_SieuThiMini
{
    public partial class Report_TonKho : Form
    {
        SqlDataAdapter da_HangHoa;
        DataSet ds_HangHoa = new DataSet();
        public Report_TonKho()
        {
            InitializeComponent();
        }
        private void LoadData_cbbTenHH()
        {
            string strSel = "select*from HangHoa";
            da_HangHoa = new SqlDataAdapter(strSel, env.conn);
            da_HangHoa.Fill(ds_HangHoa, "HangHoa");
            comboBox_TenHH.DataSource = ds_HangHoa.Tables["HangHoa"];
            comboBox_TenHH.DisplayMember = "TenHH";
            comboBox_TenHH.ValueMember = "TenHH";
        }

        private void LoadInventoryReport()
        {
            string strSel = "SELECT * FROM HangHoa";
            da_HangHoa = new SqlDataAdapter(strSel, env.conn);
            da_HangHoa.Fill(ds_HangHoa, "HangHoa");

        }

        private void Report_TonKho_Load(object sender, EventArgs e)
        {
            LoadData_cbbTenHH();
            LoadInventoryReport();
        }
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            // Handle the button click event to regenerate the report based on selected product
            string selectedProduct = comboBox_TenHH.SelectedValue.ToString();

            string strSelFiltered = $"SELECT * FROM HangHoa WHERE TenHH = '{selectedProduct}'";
            ds_HangHoa.Tables["HangHoa"].Clear();
            da_HangHoa.SelectCommand.CommandText = strSelFiltered;
            da_HangHoa.Fill(ds_HangHoa, "HangHoa");

            crystalReportViewer1.Refresh();
        }
    }
}
