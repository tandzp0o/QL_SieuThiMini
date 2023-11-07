
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
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.DanhSachNhanVienListBox = new System.Windows.Forms.ListBox();
            this.labTenNV = new System.Windows.Forms.Label();
            this.labDiaChi = new System.Windows.Forms.Label();
            this.labSDT = new System.Windows.Forms.Label();
            this.txtTenNV = new System.Windows.Forms.TextBox();
            this.txtDiaChi = new System.Windows.Forms.TextBox();
            this.txtSDT = new System.Windows.Forms.TextBox();
            this.btnThoat = new System.Windows.Forms.Button();
            this.labPhanQuyen = new System.Windows.Forms.Label();
            this.comboBox_PhanQuyen = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(48, 12);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(106, 46);
            this.btnAdd.TabIndex = 0;
            this.btnAdd.Text = "Thêm";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(184, 12);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(106, 46);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Cập nhật";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(323, 12);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(106, 46);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Xoá";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // DanhSachNhanVienListBox
            // 
            this.DanhSachNhanVienListBox.FormattingEnabled = true;
            this.DanhSachNhanVienListBox.ItemHeight = 16;
            this.DanhSachNhanVienListBox.Location = new System.Drawing.Point(4, 182);
            this.DanhSachNhanVienListBox.Name = "DanhSachNhanVienListBox";
            this.DanhSachNhanVienListBox.Size = new System.Drawing.Size(632, 228);
            this.DanhSachNhanVienListBox.TabIndex = 4;
            // 
            // labTenNV
            // 
            this.labTenNV.AutoSize = true;
            this.labTenNV.Location = new System.Drawing.Point(13, 75);
            this.labTenNV.Name = "labTenNV";
            this.labTenNV.Size = new System.Drawing.Size(91, 16);
            this.labTenNV.TabIndex = 5;
            this.labTenNV.Text = "Tên nhân viên";
            // 
            // labDiaChi
            // 
            this.labDiaChi.AutoSize = true;
            this.labDiaChi.Location = new System.Drawing.Point(13, 137);
            this.labDiaChi.Name = "labDiaChi";
            this.labDiaChi.Size = new System.Drawing.Size(47, 16);
            this.labDiaChi.TabIndex = 6;
            this.labDiaChi.Text = "Địa chỉ";
            // 
            // labSDT
            // 
            this.labSDT.AutoSize = true;
            this.labSDT.Location = new System.Drawing.Point(355, 75);
            this.labSDT.Name = "labSDT";
            this.labSDT.Size = new System.Drawing.Size(85, 16);
            this.labSDT.TabIndex = 7;
            this.labSDT.Text = "Số điện thoại";
            // 
            // txtTenNV
            // 
            this.txtTenNV.Location = new System.Drawing.Point(110, 72);
            this.txtTenNV.Name = "txtTenNV";
            this.txtTenNV.Size = new System.Drawing.Size(224, 22);
            this.txtTenNV.TabIndex = 8;
            // 
            // txtDiaChi
            // 
            this.txtDiaChi.Location = new System.Drawing.Point(110, 134);
            this.txtDiaChi.Name = "txtDiaChi";
            this.txtDiaChi.Size = new System.Drawing.Size(224, 22);
            this.txtDiaChi.TabIndex = 9;
            // 
            // txtSDT
            // 
            this.txtSDT.Location = new System.Drawing.Point(446, 72);
            this.txtSDT.Name = "txtSDT";
            this.txtSDT.Size = new System.Drawing.Size(166, 22);
            this.txtSDT.TabIndex = 10;
            // 
            // btnThoat
            // 
            this.btnThoat.Location = new System.Drawing.Point(465, 12);
            this.btnThoat.Name = "btnThoat";
            this.btnThoat.Size = new System.Drawing.Size(106, 46);
            this.btnThoat.TabIndex = 11;
            this.btnThoat.Text = "Thoát";
            this.btnThoat.UseVisualStyleBackColor = true;
            this.btnThoat.Click += new System.EventHandler(this.btnThoat_Click);
            // 
            // labPhanQuyen
            // 
            this.labPhanQuyen.AutoSize = true;
            this.labPhanQuyen.Location = new System.Drawing.Point(355, 137);
            this.labPhanQuyen.Name = "labPhanQuyen";
            this.labPhanQuyen.Size = new System.Drawing.Size(78, 16);
            this.labPhanQuyen.TabIndex = 12;
            this.labPhanQuyen.Text = "Phân quyền";
            // 
            // comboBox_PhanQuyen
            // 
            this.comboBox_PhanQuyen.FormattingEnabled = true;
            this.comboBox_PhanQuyen.Location = new System.Drawing.Point(446, 134);
            this.comboBox_PhanQuyen.Name = "comboBox_PhanQuyen";
            this.comboBox_PhanQuyen.Size = new System.Drawing.Size(166, 24);
            this.comboBox_PhanQuyen.TabIndex = 13;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 418);
            this.Controls.Add(this.comboBox_PhanQuyen);
            this.Controls.Add(this.labPhanQuyen);
            this.Controls.Add(this.btnThoat);
            this.Controls.Add(this.txtSDT);
            this.Controls.Add(this.txtDiaChi);
            this.Controls.Add(this.txtTenNV);
            this.Controls.Add(this.labSDT);
            this.Controls.Add(this.labDiaChi);
            this.Controls.Add(this.labTenNV);
            this.Controls.Add(this.DanhSachNhanVienListBox);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Name = "Form1";
            this.Text = "Quản lý nhân viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ListBox DanhSachNhanVienListBox;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label labSDT;
        private System.Windows.Forms.Label labDiaChi;
        private System.Windows.Forms.Label labTenNV;
        private System.Windows.Forms.TextBox txtTenNV;
        private System.Windows.Forms.TextBox txtSDT;
        private System.Windows.Forms.TextBox txtDiaChi;
        private System.Windows.Forms.Button btnThoat;
        private System.Windows.Forms.ComboBox comboBox_PhanQuyen;
        private System.Windows.Forms.Label labPhanQuyen;
    }
}

