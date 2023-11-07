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

namespace QL_SieuThiMini
{
    public partial class NhanVien : Form
    {
        SqlConnection conn;
        SqlDataAdapter da_PhanQuyen;
        DataSet ds_PhanQuyen=new DataSet();
        private List<NhanVienST> danhSachNhanVien = new List<NhanVienST>();
        public NhanVien()
        {
            InitializeComponent();
            conn = new SqlConnection("");
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            DialogResult r;
            r = MessageBox.Show("Bạn muốn thoát chương trình?", "Thoát", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (r == DialogResult.No)
                e.Cancel = true;
        }
        void LoadDuLieuPhanQuyen()
        {
            string strSel = "select*from QuyenHan";
            da_PhanQuyen = new SqlDataAdapter(strSel, conn);
            da_PhanQuyen.Fill(ds_PhanQuyen, "QuyenHan");
            comboBox_PhanQuyen.DataSource = ds_PhanQuyen.Tables["QuyenHan"];
            comboBox_PhanQuyen.DisplayMember = "TenNV";
            comboBox_PhanQuyen.ValueMember = "MaNV";
        }
        private void RefreshDanhSachNhanVien()
        {
            DanhSachNhanVienListBox.Items.Clear();

            foreach (NhanVienST nhanVien in danhSachNhanVien)
            {
                DanhSachNhanVienListBox.Items.Add($"{nhanVien.TenNhanVien} - {nhanVien.DiaChi} - {nhanVien.SoDienThoai}");
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            string tenNhanVien = txtTenNV.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSDT.Text;
            string quyenHan = comboBox_PhanQuyen.SelectedItem.ToString();
            danhSachNhanVien[DanhSachNhanVienListBox.SelectedIndex].QuyenHan = quyenHan;

            NhanVienST nhanVien = new NhanVienST(tenNhanVien, diaChi, soDienThoai,quyenHan);
            danhSachNhanVien.Add(nhanVien);

            RefreshDanhSachNhanVien();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (DanhSachNhanVienListBox.SelectedIndex >= 0)
            {
                string tenNhanVien = txtTenNV.Text;
                string diaChi = txtDiaChi.Text;
                string soDienThoai = txtSDT.Text;
                string quyenHanMoi = comboBox_PhanQuyen.SelectedItem.ToString();
                danhSachNhanVien[DanhSachNhanVienListBox.SelectedIndex].QuyenHan = quyenHanMoi;

                int selectedIndex = DanhSachNhanVienListBox.SelectedIndex;
                danhSachNhanVien[selectedIndex] = new NhanVienST(tenNhanVien, diaChi, soDienThoai, quyenHanMoi);
                RefreshDanhSachNhanVien();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (DanhSachNhanVienListBox.SelectedIndex >= 0)
            {
                danhSachNhanVien.RemoveAt(DanhSachNhanVienListBox.SelectedIndex);
                RefreshDanhSachNhanVien();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDuLieuPhanQuyen();
        }
    }
    public class NhanVienST
    {
        public string TenNhanVien { get; set; }
        public string DiaChi { get; set; }
        public string SoDienThoai { get; set; }
        public string QuyenHan { get; set; }

        public NhanVienST(string tenNhanVien, string diaChi, string soDienThoai, string quyenHan)
        {
            TenNhanVien = tenNhanVien;
            DiaChi = diaChi;
            SoDienThoai = soDienThoai;
            QuyenHan = quyenHan;
        }
    }
}