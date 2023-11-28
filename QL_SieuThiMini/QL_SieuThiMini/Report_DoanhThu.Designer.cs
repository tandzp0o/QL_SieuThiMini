
namespace QL_SieuThiMini
{
    partial class Report_DoanhThu
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
            this.btnShowReport = new System.Windows.Forms.Button();
            this.labNgay = new System.Windows.Forms.Label();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(2, 166);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(912, 449);
            this.crystalReportViewer1.TabIndex = 3;
            // 
            // btnShowReport
            // 
            this.btnShowReport.BackColor = System.Drawing.Color.Pink;
            this.btnShowReport.Font = new System.Drawing.Font("Times New Roman", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnShowReport.Image = global::QL_SieuThiMini.Properties.Resources.icons8_eye_48;
            this.btnShowReport.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnShowReport.Location = new System.Drawing.Point(723, 12);
            this.btnShowReport.Name = "btnShowReport";
            this.btnShowReport.Size = new System.Drawing.Size(168, 60);
            this.btnShowReport.TabIndex = 4;
            this.btnShowReport.Text = "ShowReport";
            this.btnShowReport.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnShowReport.UseVisualStyleBackColor = false;
            this.btnShowReport.Click += new System.EventHandler(this.btnShowReport_Click);
            // 
            // labNgay
            // 
            this.labNgay.AutoSize = true;
            this.labNgay.Location = new System.Drawing.Point(39, 13);
            this.labNgay.Name = "labNgay";
            this.labNgay.Size = new System.Drawing.Size(41, 17);
            this.labNgay.TabIndex = 5;
            this.labNgay.Text = "Ngày";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Location = new System.Drawing.Point(100, 12);
            this.maskedTextBox1.Mask = "00/00/0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(163, 22);
            this.maskedTextBox1.TabIndex = 6;
            this.maskedTextBox1.ValidatingType = typeof(System.DateTime);
            // 
            // Report_DoanhThu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSkyBlue;
            this.ClientSize = new System.Drawing.Size(917, 618);
            this.Controls.Add(this.maskedTextBox1);
            this.Controls.Add(this.labNgay);
            this.Controls.Add(this.btnShowReport);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Report_DoanhThu";
            this.Text = "Report_DoanhThu";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Report_DoanhThu_FormClosing);
            this.Load += new System.EventHandler(this.Report_DoanhThu_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.Button btnShowReport;
        private System.Windows.Forms.Label labNgay;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}