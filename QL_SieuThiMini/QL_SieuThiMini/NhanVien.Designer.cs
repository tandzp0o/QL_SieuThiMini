
namespace QL_SieuThiMini
{
    partial class NhanVien
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(NhanVien));
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.labTenNV = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.grChucNang = new System.Windows.Forms.GroupBox();
            this.btnRefresh = new System.Windows.Forms.Button();
            this.btnIn = new System.Windows.Forms.Button();
            this.btnThoat = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.grThongTinNhanVien = new System.Windows.Forms.GroupBox();
            this.comboBox_PhanQuyen = new System.Windows.Forms.ComboBox();
            this.labPhanQuyen = new System.Windows.Forms.Label();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.labSDT = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.grSearch = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.grSearchSDT = new System.Windows.Forms.GroupBox();
            this.txtSearchSDT = new System.Windows.Forms.TextBox();
            this.grSearchName = new System.Windows.Forms.GroupBox();
            this.txtSearchName = new System.Windows.Forms.TextBox();
            this.grDSNhanVien = new System.Windows.Forms.GroupBox();
            this.listView_NhanVien = new System.Windows.Forms.ListView();
            this.colMaNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colTenNV = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colGioiTinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colNgaySinh = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colDiaChi = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colSDT = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.colChucVu = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.printDialog1 = new System.Windows.Forms.PrintDialog();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.grChucNang.SuspendLayout();
            this.grThongTinNhanVien.SuspendLayout();
            this.grSearch.SuspendLayout();
            this.grSearchSDT.SuspendLayout();
            this.grSearchName.SuspendLayout();
            this.grDSNhanVien.SuspendLayout();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // labTenNV
            // 
            this.labTenNV.AutoSize = true;
            this.labTenNV.Location = new System.Drawing.Point(18, 39);
            this.labTenNV.Name = "labTenNV";
            this.labTenNV.Size = new System.Drawing.Size(99, 17);
            this.labTenNV.TabIndex = 5;
            this.labTenNV.Text = "Tên nhân viên";
            this.labTenNV.Click += new System.EventHandler(this.labTenNV_Click);
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(123, 39);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(224, 22);
            this.txtTenNV.TabIndex = 8;
            // 
            // grChucNang
            // 
            this.grChucNang.BackColor = System.Drawing.Color.Aqua;
            this.grChucNang.Controls.Add(this.btnRefresh);
            this.grChucNang.Controls.Add(this.btnIn);
            this.grChucNang.Controls.Add(this.btnThoat);
            this.grChucNang.Controls.Add(this.btnDelete);
            this.grChucNang.Controls.Add(this.btnUpdate);
            this.grChucNang.Controls.Add(this.btnAdd);
            this.grChucNang.Location = new System.Drawing.Point(842, 5);
            this.grChucNang.Name = "grChucNang";
            this.grChucNang.Size = new System.Drawing.Size(475, 259);
            this.grChucNang.TabIndex = 14;
            this.grChucNang.TabStop = false;
            this.grChucNang.Text = "Các chức năng";
            // 
            // btnRefresh
            // 
            this.btnRefresh.BackColor = System.Drawing.SystemColors.Info;
            this.btnRefresh.Image = global::QL_SieuThiMini.Properties.Resources.icons8_refresh_48;
            this.btnRefresh.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRefresh.Location = new System.Drawing.Point(27, 133);
            this.btnRefresh.Name = "btnRefresh";
            this.btnRefresh.Size = new System.Drawing.Size(117, 66);
            this.btnRefresh.TabIndex = 13;
            this.btnRefresh.Text = "Làm mới";
            this.btnRefresh.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRefresh.UseVisualStyleBackColor = false;
            this.btnRefresh.Click += new System.EventHandler(this.btnRefresh_Click);
            // 
            // btnIn
            // 
            this.btnIn.BackColor = System.Drawing.SystemColors.Info;
            this.btnIn.Image = global::QL_SieuThiMini.Properties.Resources.icons8_print_48;
            this.btnIn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnIn.Location = new System.Drawing.Point(176, 140);
            this.btnIn.Name = "btnIn";
            this.btnIn.Size = new System.Drawing.Size(117, 59);
            this.btnIn.TabIndex = 12;
            this.btnIn.Text = "In";
            this.btnIn.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnIn.UseVisualStyleBackColor = false;
            this.btnIn.Click += new System.EventHandler(this.btnIn_Click);
            // 
            // btnThoat
            // 
            this.btnThoat.BackColor = System.Drawing.SystemColors.Info;
            this.btnThoat.Image = global::QL_SieuThiMini.Properties.Resources.icons8_close_48;
            this.btnThoat.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnThoat.Location = new System.Drawing.Point(336, 140);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(116, 59);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnThoat.UseVisualStyleBackColor = false;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.BackColor = System.Drawing.SystemColors.Info;
            this.btnDelete.Image = global::QL_SieuThiMini.Properties.Resources.icons8_delete_48;
            this.btnDelete.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDelete.Location = new System.Drawing.Point(176, 35);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(117, 59);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDelete.UseVisualStyleBackColor = false;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = System.Drawing.SystemColors.Info;
            this.btnUpdate.Image = global::QL_SieuThiMini.Properties.Resources.icons8_edit_48;
            this.btnUpdate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnUpdate.Location = new System.Drawing.Point(336, 35);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(116, 59);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.BackColor = System.Drawing.SystemColors.Info;
            this.btnAdd.ForeColor = System.Drawing.Color.Black;
            this.btnAdd.Image = global::QL_SieuThiMini.Properties.Resources.icons8_add_48;
            this.btnAdd.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAdd.Location = new System.Drawing.Point(27, 35);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(117, 62);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAdd.UseVisualStyleBackColor = false;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // grThongTinNhanVien
            // 
            this.grThongTinNhanVien.BackColor = System.Drawing.Color.Aqua;
            this.grThongTinNhanVien.Controls.Add(this.comboBox_PhanQuyen);
            this.grThongTinNhanVien.Controls.Add(this.labPhanQuyen);
            this.grThongTinNhanVien.Controls.Add(this.txtSDT);
            this.grThongTinNhanVien.Controls.Add(this.txtDiaChi);
            this.grThongTinNhanVien.Controls.Add(this.labSDT);
            this.grThongTinNhanVien.Controls.Add(this.labDiaChi);
            this.grThongTinNhanVien.Controls.Add(this.labTenNV);
            this.grThongTinNhanVien.Controls.Add(this.txtTenNV);
            this.grThongTinNhanVien.Location = new System.Drawing.Point(4, 5);
            this.grThongTinNhanVien.Name = "grThongTinNhanVien";
            this.grThongTinNhanVien.Size = new System.Drawing.Size(832, 141);
            this.grThongTinNhanVien.TabIndex = 15;
            this.grThongTinNhanVien.TabStop = false;
            this.grThongTinNhanVien.Text = "Thông tin nhân viên";
            // 
            // comboBox_PhanQuyen
            // 
            this.comboBox_PhanQuyen.FormattingEnabled = true;
            this.comboBox_PhanQuyen.Location = new System.Drawing.Point(452, 102);
            this.comboBox_PhanQuyen.Name = "comboBox_PhanQuyen";
            this.comboBox_PhanQuyen.Size = new System.Drawing.Size(166, 24);
            this.comboBox_PhanQuyen.TabIndex = 19;
            // 
            // labPhanQuyen
            // 
            this.labPhanQuyen.AutoSize = true;
            this.labPhanQuyen.Location = new System.Drawing.Point(361, 105);
            this.labPhanQuyen.Name = "labPhanQuyen";
            this.labPhanQuyen.Size = new System.Drawing.Size(84, 17);
            this.labPhanQuyen.TabIndex = 18;
            this.labPhanQuyen.Text = "Phân quyền";
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(452, 40);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(166, 22);
            this.txtSDT.TabIndex = 17;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(116, 102);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(224, 22);
            this.txtDiaChi.TabIndex = 16;
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Location = new System.Drawing.Point(361, 43);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(91, 17);
            this.labSDT.TabIndex = 15;
            this.labSDT.Text = "Số điện thoại";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Location = new System.Drawing.Point(18, 105);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(51, 17);
            this.labDiaChi.TabIndex = 14;
            this.labDiaChi.Text = "Địa chỉ";
            // 
            // grSearch
            // 
            this.grSearch.BackColor = System.Drawing.Color.Aqua;
            this.grSearch.Controls.Add(this.btnSearch);
            this.grSearch.Controls.Add(this.grSearchSDT);
            this.grSearch.Controls.Add(this.grSearchName);
            this.grSearch.Location = new System.Drawing.Point(4, 153);
            this.grSearch.Name = "grSearch";
            this.grSearch.Size = new System.Drawing.Size(832, 111);
            this.grSearch.TabIndex = 16;
            this.grSearch.TabStop = false;
            this.grSearch.Text = "Tìm kiếm nhân viên";
            // 
            // btnSearch
            // 
            this.btnSearch.BackColor = System.Drawing.SystemColors.Info;
            this.btnSearch.Image = global::QL_SieuThiMini.Properties.Resources.icons8_search_48;
            this.btnSearch.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSearch.Location = new System.Drawing.Point(631, 32);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(117, 59);
            this.btnSearch.TabIndex = 20;
            this.btnSearch.Text = "Tìm kiếm";
            this.btnSearch.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSearch.UseVisualStyleBackColor = false;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // grSearchSDT
            // 
            this.grSearchSDT.Controls.Add(this.txtSearchSDT);
            this.grSearchSDT.Location = new System.Drawing.Point(305, 27);
            this.grSearchSDT.Margin = new System.Windows.Forms.Padding(4);
            this.grSearchSDT.Name = "grSearchSDT";
            this.grSearchSDT.Padding = new System.Windows.Forms.Padding(4);
            this.grSearchSDT.Size = new System.Drawing.Size(265, 64);
            this.grSearchSDT.TabIndex = 19;
            this.grSearchSDT.TabStop = false;
            this.grSearchSDT.Text = "Theo Số SDT";
            // 
            // txtSearchSDT
            // 
            this.txtSearchSDT.Location = new System.Drawing.Point(16, 23);
            this.txtSearchSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchSDT.Name = "txtSearchSDT";
            this.txtSearchSDT.Size = new System.Drawing.Size(240, 22);
            this.txtSearchSDT.TabIndex = 16;
            // 
            // grSearchName
            // 
            this.grSearchName.Controls.Add(this.txtSearchName);
            this.grSearchName.Location = new System.Drawing.Point(9, 27);
            this.grSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.grSearchName.Name = "grSearchName";
            this.grSearchName.Padding = new System.Windows.Forms.Padding(4);
            this.grSearchName.Size = new System.Drawing.Size(265, 64);
            this.grSearchName.TabIndex = 18;
            this.grSearchName.TabStop = false;
            this.grSearchName.Text = "Theo tên";
            // 
            // txtSearchName
            // 
            this.txtSearchName.Location = new System.Drawing.Point(16, 23);
            this.txtSearchName.Margin = new System.Windows.Forms.Padding(4);
            this.txtSearchName.Name = "txtSearchName";
            this.txtSearchName.Size = new System.Drawing.Size(240, 22);
            this.txtSearchName.TabIndex = 16;
            // 
            // grDSNhanVien
            // 
            this.grDSNhanVien.BackColor = System.Drawing.Color.Aqua;
            this.grDSNhanVien.Controls.Add(this.listView_NhanVien);
            this.grDSNhanVien.Location = new System.Drawing.Point(4, 271);
            this.grDSNhanVien.Name = "grDSNhanVien";
            this.grDSNhanVien.Size = new System.Drawing.Size(1313, 295);
            this.grDSNhanVien.TabIndex = 17;
            this.grDSNhanVien.TabStop = false;
            this.grDSNhanVien.Text = "Danh sách nhân viên";
            // 
            // listView_NhanVien
            // 
            this.listView_NhanVien.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colMaNV,
            this.colTenNV,
            this.colGioiTinh,
            this.colNgaySinh,
            this.colDiaChi,
            this.colSDT,
            this.colChucVu});
            this.listView_NhanVien.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listView_NhanVien.HideSelection = false;
            this.listView_NhanVien.Location = new System.Drawing.Point(21, 22);
            this.listView_NhanVien.Name = "listView_NhanVien";
            this.listView_NhanVien.Size = new System.Drawing.Size(1269, 267);
            this.listView_NhanVien.TabIndex = 0;
            this.listView_NhanVien.UseCompatibleStateImageBehavior = false;
            this.listView_NhanVien.View = System.Windows.Forms.View.Details;
            // 
            // colMaNV
            // 
            this.colMaNV.Text = "Mã nhân viên";
            this.colMaNV.Width = 147;
            // 
            // colTenNV
            // 
            this.colTenNV.Text = "Tên nhân viên";
            this.colTenNV.Width = 204;
            // 
            // colGioiTinh
            // 
            this.colGioiTinh.Text = "Giới tính";
            this.colGioiTinh.Width = 101;
            // 
            // colNgaySinh
            // 
            this.colNgaySinh.Text = "Ngày sinh";
            this.colNgaySinh.Width = 122;
            // 
            // colDiaChi
            // 
            this.colDiaChi.Text = "Địa chỉ";
            this.colDiaChi.Width = 173;
            // 
            // colSDT
            // 
            this.colSDT.Text = "SĐT";
            this.colSDT.Width = 169;
            // 
            // colChucVu
            // 
            this.colChucVu.Text = "Chức vụ";
            this.colChucVu.Width = 158;
            // 
            // printDialog1
            // 
            this.printDialog1.UseEXDialog = true;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SteelBlue;
            this.ClientSize = new System.Drawing.Size(1321, 570);
            this.Controls.Add(this.grDSNhanVien);
            this.Controls.Add(this.grSearch);
            this.Controls.Add(this.grThongTinNhanVien);
            this.Controls.Add(this.grChucNang);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "NhanVien";
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.grChucNang.ResumeLayout(false);
            this.grThongTinNhanVien.ResumeLayout(false);
            this.grThongTinNhanVien.PerformLayout();
            this.grSearch.ResumeLayout(false);
            this.grSearchSDT.ResumeLayout(false);
            this.grSearchSDT.PerformLayout();
            this.grSearchName.ResumeLayout(false);
            this.grSearchName.PerformLayout();
            this.grDSNhanVien.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labTenNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.GroupBox grChucNang;
        private System.Windows.Forms.Button btnRefresh;
        private System.Windows.Forms.Button btnIn;
        private System.Windows.Forms.GroupBox grThongTinNhanVien;
        private System.Windows.Forms.GroupBox grSearch;
        private System.Windows.Forms.GroupBox grSearchSDT;
        private System.Windows.Forms.TextBox txtSearchSDT;
        private System.Windows.Forms.GroupBox grSearchName;
        private System.Windows.Forms.TextBox txtSearchName;
        private System.Windows.Forms.ComboBox comboBox_PhanQuyen;
        private System.Windows.Forms.Label labPhanQuyen;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.GroupBox grDSNhanVien;
        private System.Windows.Forms.ListView listView_NhanVien;
        private System.Windows.Forms.ColumnHeader colMaNV;
        private System.Windows.Forms.ColumnHeader colTenNV;
        private System.Windows.Forms.ColumnHeader colGioiTinh;
        private System.Windows.Forms.ColumnHeader colNgaySinh;
        private System.Windows.Forms.ColumnHeader colDiaChi;
        private System.Windows.Forms.ColumnHeader colSDT;
        private System.Windows.Forms.ColumnHeader colChucVu;
        private System.Windows.Forms.PrintDialog printDialog1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}

