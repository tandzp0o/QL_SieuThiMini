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
        SqlDataAdapter da_PhanQuyen;
        DataSet ds_PhanQuyen=new DataSet();
        private List<NhanVienST> danhSachNhanVien = new List<NhanVienST>();
        public NhanVien()
        {
            InitializeComponent();
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
            da_PhanQuyen = new SqlDataAdapter(strSel, env.conn);
            da_PhanQuyen.Fill(ds_PhanQuyen, "QuyenHan");
            comboBox_PhanQuyen.DataSource = ds_PhanQuyen.Tables["QuyenHan"];
            comboBox_PhanQuyen.DisplayMember = "TenNV";
            comboBox_PhanQuyen.ValueMember = "MaNV";
        }
        private void RefreshDanhSachNhanVien()
        {
            listView_NhanVien.Items.Clear();

            foreach (NhanVienST nhanVien in danhSachNhanVien)
            {
                ListViewItem item = new ListViewItem(new[] { nhanVien.TenNhanVien, nhanVien.DiaChi, nhanVien.SoDienThoai, nhanVien.QuyenHan });
                listView_NhanVien.Items.Add(item);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate input
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get input values
            string tenNhanVien = txtTenNV.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSDT.Text;
            string quyenHan = comboBox_PhanQuyen.SelectedItem.ToString();

            // Create a new employee
            NhanVienST nhanVien = new NhanVienST(tenNhanVien, diaChi, soDienThoai, quyenHan);

            // Add the new employee to the list
            danhSachNhanVien.Add(nhanVien);

            // Refresh the ListView
            RefreshDanhSachNhanVien();

            // Provide feedback to the user
            MessageBox.Show("Thêm nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields();

        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Check if an employee is selected
            if (listView_NhanVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để cập nhật.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validate input
            if (string.IsNullOrWhiteSpace(txtTenNV.Text) || string.IsNullOrWhiteSpace(txtDiaChi.Text) || string.IsNullOrWhiteSpace(txtSDT.Text))
            {
                MessageBox.Show("Vui lòng nhập đủ thông tin nhân viên.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get input values
            string tenNhanVien = txtTenNV.Text;
            string diaChi = txtDiaChi.Text;
            string soDienThoai = txtSDT.Text;
            string quyenHanMoi = comboBox_PhanQuyen.SelectedItem.ToString();

            // Get the selected employee
            int selectedIndex = listView_NhanVien.SelectedItems[0].Index;

            // Update the selected employee
            danhSachNhanVien[selectedIndex] = new NhanVienST(tenNhanVien, diaChi, soDienThoai, quyenHanMoi);

            // Refresh the ListView
            RefreshDanhSachNhanVien();

            // Provide feedback to the user
            MessageBox.Show("Cập nhật nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Check if an employee is selected
            if (listView_NhanVien.SelectedItems.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn một nhân viên để xoá.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Get the selected employee
            int selectedIndex = listView_NhanVien.SelectedItems[0].Index;

            // Remove the selected employee from the list
            danhSachNhanVien.RemoveAt(selectedIndex);

            // Refresh the ListView
            RefreshDanhSachNhanVien();

            // Provide feedback to the user
            MessageBox.Show("Xoá nhân viên thành công.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields();
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LoadDuLieuPhanQuyen();
        }

        private void labTenNV_Click(object sender, EventArgs e)
        {

        }
        private void ClearInputFields()
        {
            txtTenNV.Text = "";
            txtDiaChi.Text = "";
            txtSDT.Text = "";
            comboBox_PhanQuyen.SelectedIndex = -1;
        }
        private void btnRefresh_Click(object sender, EventArgs e)
        {
            // Refresh the ListView
            RefreshDanhSachNhanVien();

            // Provide feedback to the user
            MessageBox.Show("Danh sách nhân viên đã được làm mới.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

            // Clear input fields
            ClearInputFields();
        }

        private void btnIn_Click(object sender, EventArgs e)
        {
            if (printDialog1.ShowDialog() == DialogResult.OK)
            {
                printDocument1.Print();
            }
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            // Set up the printing content
            string printContent = GetPrintContent();

            // Specify font and brush
            Font font = new Font("Arial", 12);
            SolidBrush brush = new SolidBrush(Color.Black);

            // Set the margin bounds
            float leftMargin = e.MarginBounds.Left;
            float topMargin = e.MarginBounds.Top;

            // Calculate the number of lines per page
            int linesPerPage = (int)(e.MarginBounds.Height / font.GetHeight(e.Graphics));

            // Initialize line index and page index
            int lineIndex = 0;
            int pageIndex = 0;

            // Loop through the content and print each line
            while (lineIndex < printContent.Length && pageIndex < linesPerPage)
            {
                // Calculate the position to print the line
                float yPos = topMargin + (lineIndex * font.GetHeight(e.Graphics));

                // Create a rectangle representing the line bounds
                RectangleF rect = new RectangleF(leftMargin, yPos, e.MarginBounds.Width, font.GetHeight(e.Graphics));

                // Print the line
                e.Graphics.DrawString(printContent.Substring(lineIndex, Math.Min(printContent.Length - lineIndex, linesPerPage)),
                                      font, brush, rect, StringFormat.GenericDefault);

                // Increment the line index and page index
                lineIndex += linesPerPage;
                pageIndex++;
            }

            // If there are more lines to print, set HasMorePages to true
            e.HasMorePages = lineIndex < printContent.Length;
        }
        private string GetPrintContent()
        {
            StringBuilder content = new StringBuilder();

            // Append the column headers
            foreach (ColumnHeader columnHeader in listView_NhanVien.Columns)
            {
                content.Append(columnHeader.Text.PadRight(20));
            }

            content.AppendLine();

            // Append the data from each row
            foreach (ListViewItem item in listView_NhanVien.Items)
            {
                foreach (ListViewItem.ListViewSubItem subItem in item.SubItems)
                {
                    content.Append(subItem.Text.PadRight(20));
                }

                content.AppendLine();
            }

            return content.ToString();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string searchTerm1 = txtSearchName.Text.Trim();

            if (string.IsNullOrWhiteSpace(searchTerm1))
            {
                MessageBox.Show("Vui lòng nhập từ khóa tìm kiếm.", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Get the search term from the TextBox (assuming you have a TextBox named txtSearch)
            string searchTerm2 = txtSearchName.Text.ToLower();

            // Filter the list based on the search term
            List<NhanVienST> searchResults = danhSachNhanVien
                .Where(nv => nv.TenNhanVien.ToLower().Contains(searchTerm2) ||
                             nv.DiaChi.ToLower().Contains(searchTerm2) ||
                             nv.SoDienThoai.ToLower().Contains(searchTerm2) ||
                             nv.QuyenHan.ToLower().Contains(searchTerm2))
                .ToList();

            // Update the ListView with the search results
            UpdateListView(searchResults);

            // Provide feedback to the user
            MessageBox.Show($"Đã tìm thấy {searchResults.Count} kết quả.", "Kết quả tìm kiếm", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void UpdateListView(List<NhanVienST> data)
        {
            listView_NhanVien.Items.Clear();

            foreach (NhanVienST nhanVien in data)
            {
                ListViewItem item = new ListViewItem(new[] { nhanVien.TenNhanVien, nhanVien.DiaChi, nhanVien.SoDienThoai, nhanVien.QuyenHan });
                listView_NhanVien.Items.Add(item);
            }
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