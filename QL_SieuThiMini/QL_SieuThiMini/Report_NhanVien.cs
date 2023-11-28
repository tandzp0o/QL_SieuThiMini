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
    public partial class Report_NhanVien : Form
    {
        SqlDataAdapter da_NhanVien;
        DataSet ds_NV = new DataSet();
        public Report_NhanVien()
        {
            InitializeComponent();
        }

        private void Report_NhanVien_Load(object sender, EventArgs e)
        {
            Report_NhanVien rpt = new Report_NhanVien();
            crystalReportViewer1.ReportSource = rpt;
            crystalReportViewer1.DisplayStatusBar = false;
            crystalReportViewer1.DisplayToolbar = true;
            crystalReportViewer1.Refresh();

            LoaData_cbbMaNV();
            LoadData_cbbTenNV();
        }
        private void LoadData_cbbTenNV()
        {
            string strSel = "select*from NhanVien";
            da_NhanVien = new SqlDataAdapter(strSel, env.conn);
            da_NhanVien.Fill(ds_NV, "NhanVien");
            comboBox_TenNV.DataSource = ds_NV.Tables["NhanVien"];
            comboBox_TenNV.DisplayMember = "TenNV";
            comboBox_TenNV.ValueMember = "TenNV";
        }
        private void LoaData_cbbMaNV()
        {
            string strSel = "select*from NhanVien";
            da_NhanVien = new SqlDataAdapter(strSel, env.conn);
            da_NhanVien.Fill(ds_NV, "NhanVien");
            comboBox_TenNV.DataSource = ds_NV.Tables["NhanVien"];
            comboBox_TenNV.DisplayMember = "MaNV";
            comboBox_TenNV.ValueMember = "MaNV";
        }
        void DataBingDing(DataTable dt)
        {
            comboBox_MaNV.DataBindings.Clear();
            comboBox_TenNV.DataBindings.Clear();

            comboBox_MaNV.DataBindings.Add("SelectedValue", dt, "MaNV");
            comboBox_TenNV.DataBindings.Add("SelectedValue", dt, "TenNV");
        }
        private void btnShowReport_Click(object sender, EventArgs e)
        {
            ReportDocument report = new ReportDocument();
            report.Load("CrystalReport_NhanVien.rpt");

            report.SetParameterValue("MaNV", comboBox_MaNV.SelectedValue);
            report.SetParameterValue("TenNV", comboBox_TenNV.SelectedValue);

            crystalReportViewer1.ReportSource = report;
            crystalReportViewer1.Refresh();
        }
    }
}
