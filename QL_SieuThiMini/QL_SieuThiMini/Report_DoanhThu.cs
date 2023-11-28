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
    public partial class Report_DoanhThu : Form
    {
        private ReportDocument reportDocument;
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

            LoadAndDisplayReport();
            LoadCrystalReport();
        }

        private void btnShowReport_Click(object sender, EventArgs e)
        {
            DataTable dtb = new DataTable("ChiTietBanHang,ChiTietNhapHang");
            SqlDataAdapter da_lop = new SqlDataAdapter("Select MaBanHang, Hanghoa.MaHH, GiaBan, ChiTietBanHang.SoLuong, ChiTietBanHang.ThanhTien, MaPhieuNhap, " +
                "HangHoa.MaHH,GiaNhap, ChiTietNhapHang.SoLuong,ChiTietNhapHang.ThanhTien From ChiTietBanHang,ChiTietNhapHang " +
                "Where ChiTietBanHang.MaHH = Hanghoa.MaHH AND ChiTietNhapHang.MaHH = HangHoa.MaHH", env.conn);
            da_lop.Fill(dtb);
            CrystalReport_DoanhThu baocao = new CrystalReport_DoanhThu();// khai báo biến thuộc lớp Report vừa tạo
            baocao.SetDataSource(dtb);
            //Hiển thị báo cáo
            Report_DoanhThu f = new Report_DoanhThu();// khai báo biến thuộc lớp lớp vừa tạo
            f.crystalReportViewer1.ReportSource = baocao;//Gán dữ liệu cho crystalReportViewer vừa tạo
            f.ShowDialog();// hiển thị chế độ ưu tiên
        }
        private void LoadAndDisplayReport()
        {
            // Load data into a DataTable (similar to previous steps)
            DataTable doanhThuTable = GetDoanhThuData();

            // Create a Crystal Report document
            ReportDocument reportDocument = new ReportDocument();
            reportDocument.Load("CrystalReport_DoanhThu.rpt"); // Replace with your report path

            // Set the report's data source
            reportDocument.SetDataSource(doanhThuTable);

            // Set the Crystal Report Viewer's report source
            crystalReportViewer1.ReportSource = reportDocument;
            crystalReportViewer1.Refresh();
        }
        private DataTable GetDoanhThuData()
        {
            DataTable doanhThuTable = new DataTable();

            try
            {
                // Replace the connection string with your actual database connection string
                string connectionString = env.conn;
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    // Replace the query with your actual SQL query to retrieve DoanhThu data
                    string query = "SELECT ChiTietBanHang.ThanhTien FROM ChiTietBanHang";
                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        SqlDataAdapter adapter = new SqlDataAdapter(command);
                        adapter.Fill(doanhThuTable);
                    }
                }
            }
            catch (Exception ex)
            {
                // Handle any exceptions that might occur during data retrieval
                MessageBox.Show($"Error retrieving DoanhThu data: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            return doanhThuTable;
        }
        private void LoadCrystalReport()
        {
            DataTable doanhThuTable = GetDoanhThuData();

            reportDocument = new ReportDocument();
            reportDocument.Load("CrystalReport_DoanhThu.rpt"); // Replace with your actual report file path
            reportDocument.SetDataSource(doanhThuTable);

            crystalReportViewer1.ReportSource = reportDocument;
        }
        private void Report_DoanhThu_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (reportDocument != null)
            {
                reportDocument.Close();
                reportDocument.Dispose();
            }
        }
    }
}
