
namespace QL_SieuThiMini
{
    partial class Report_TonKho
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.labTenHH = new System.Windows.Forms.Label();
            this.comboBox_TenHH = new System.Windows.Forms.ComboBox();
            this.btnShowReport = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(4, 123);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(898, 450);
            this.crystalReportViewer1.TabIndex = 1;
            // 
            // labTenHH
            // 
            this.labTenHH.AutoSize = true;
            this.labTenHH.Location = new System.Drawing.Point(72, 29);
            this.labTenHH.Name = "labTenHH";
            this.labTenHH.Size = new System.Drawing.Size(97, 17);
            this.labTenHH.TabIndex = 22;
            this.labTenHH.Text = "Tên hàng hoá";
            // 
            // comboBox_TenHH
            // 
            this.comboBox_TenHH.FormattingEnabled = true;
            this.comboBox_TenHH.Location = new System.Drawing.Point(175, 26);
            this.comboBox_TenHH.Name = "comboBox_TenHH";
            this.comboBox_TenHH.Size = new System.Drawing.Size(216, 24);
            this.comboBox_TenHH.TabIndex = 23;
            // 
            // btnShowReport
            // 
            this.btnShowReport.BackColor = System.Drawing.SystemColors.Info;
            this.btnShowReport.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Image = global::QL_SieuThiMini.Properties.Resources.icons8_eye_48;
            this.btnShowReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowReport.Location = new System.Drawing.Point(734, 6);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(168, 60);
            this.btnShowReport.TabIndex = 24;
            this.btnShowReport.Text = "ShowReport";
            this.btnShowReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // Report_TonKho
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(902, 576);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.labTenHH);
            this.Controls.Add(this.comboBox_TenHH);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Report_TonKho";
            this.Text = "Report_TonKho";
            this.Load += new System.EventHandler(this.Report_TonKho_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Label labTenHH;
        private System.Windows.Forms.ComboBox comboBox_TenHH;
        private System.Windows.Forms.Button btnShowReport;
    }
}