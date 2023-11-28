
namespace QL_SieuThiMini
{
    partial class Report_NhanVien
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
            this.btnShowReport = new System.Windows.Forms.Button();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.labTenNV = new System.Windows.Forms.Label();
            this.labMaNV = new System.Windows.Forms.Label();
            this.comboBox_MaNV = new System.Windows.Forms.ComboBox();
            this.comboBox_TenNV = new System.Windows.Forms.ComboBox();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnShowReport
            // 
            this.btnShowReport.BackColor = System.Drawing.SystemColors.Info;
            this.btnShowReport.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Image = global::QL_SieuThiMini.Properties.Resources.icons8_eye_48;
            this.btnShowReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowReport.Location = new System.Drawing.Point(723, 5);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(168, 60);
            this.btnShowReport.TabIndex = 3;
            this.btnShowReport.Text = "ShowReport";
            this.btnShowReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 131);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(898, 450);
            this.crystalReportViewer1.TabIndex = 2;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 32.03125F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 67.96875F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 107F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 262F));
            this.tableLayoutPanel1.Controls.Add(this.labTenNV, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.labMaNV, 2, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_MaNV, 3, 0);
            this.tableLayoutPanel1.Controls.Add(this.comboBox_TenNV, 1, 0);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(12, 12);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 1;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(705, 53);
            this.tableLayoutPanel1.TabIndex = 20;
            // 
            // labTenNV
            // 
            this.labTenNV.AutoSize = true;
            this.labTenNV.Location = new System.Drawing.Point(3, 0);
            this.labTenNV.Name = "labTenNV";
            this.labTenNV.Size = new System.Drawing.Size(99, 17);
            this.labTenNV.TabIndex = 12;
            this.labTenNV.Text = "Tên nhân viên";
            // 
            // labMaNV
            // 
            this.labMaNV.AutoSize = true;
            this.labMaNV.Location = new System.Drawing.Point(338, 0);
            this.labMaNV.Name = "labMaNV";
            this.labMaNV.Size = new System.Drawing.Size(93, 17);
            this.labMaNV.TabIndex = 14;
            this.labMaNV.Text = "Mã nhân viên";
            // 
            // comboBox_MaNV
            // 
            this.comboBox_MaNV.FormattingEnabled = true;
            this.comboBox_MaNV.Location = new System.Drawing.Point(445, 3);
            this.comboBox_MaNV.Name = "comboBox_MaNV";
            this.comboBox_MaNV.Size = new System.Drawing.Size(256, 24);
            this.comboBox_MaNV.TabIndex = 16;
            // 
            // comboBox_TenNV
            // 
            this.comboBox_TenNV.FormattingEnabled = true;
            this.comboBox_TenNV.Location = new System.Drawing.Point(110, 3);
            this.comboBox_TenNV.Name = "comboBox_TenNV";
            this.comboBox_TenNV.Size = new System.Drawing.Size(216, 24);
            this.comboBox_TenNV.TabIndex = 15;
            // 
            // Report_NhanVien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(903, 587);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Report_NhanVien";
            this.Text = "Report_NhanVien";
            this.Load += new System.EventHandler(this.Report_NhanVien_Load);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnShowReport;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label labTenNV;
        private System.Windows.Forms.Label labMaNV;
        private System.Windows.Forms.ComboBox comboBox_MaNV;
        private System.Windows.Forms.ComboBox comboBox_TenNV;
    }
}