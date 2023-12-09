﻿using System;
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
        public Report_NhanVien()
        {
            InitializeComponent();
        }

        private void Report_NhanVien_Load(object sender, EventArgs e)
        {
            
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

            string query = "SELECT NhanVien.*, ChucVu.TenCV FROM NhanVien " +
                   "JOIN ChucVu ON NhanVien.MaCV = ChucVu.MaCV";

            // Tạo một DataTable để chứa dữ liệu từ cơ sở dữ liệu
            DataTable dataTable = new DataTable();

            // Sử dụng một SqlDataAdapter để lấy dữ liệu từ cơ sở dữ liệu
            SqlDataAdapter dataAdapter = new SqlDataAdapter(query, env.conn);
            dataAdapter.Fill(dataTable);

            // Tạo một thể hiện của Crystal Report của bạn
             CrystalReport_NhanVien rpt = new CrystalReport_NhanVien();

            // Thiết lập nguồn dữ liệu cho Crystal Report
            rpt.SetDataSource(dataTable);

            // Thiết lập thông tin đăng nhập cơ sở dữ liệu
            rpt.SetDatabaseLogon("sa", "123", "LAPTOP-DV021U52\\LUNCHAN", "SieuThiMini");

            // Thiết lập nguồn Crystal Report
            crystalReportViewer1.ReportSource = rpt;

            // Tùy chỉnh các thiết lập của Crystal Report Viewer
            crystalReportViewer1.ShowFirstPage();
            crystalReportViewer1.ShowLastPage();


            crystalReportViewer1.DisplayGroupTree = false;


            // Làm mới Crystal Report Viewer

            crystalReportViewer1.Refresh();
        }
    }
}
