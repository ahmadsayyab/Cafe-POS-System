namespace BisleriumCafePOSSystem.Windows
{
    partial class frmGenerateReport
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
            this.pnlMainheading = new System.Windows.Forms.Panel();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.pnltaskBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblSelectDate = new System.Windows.Forms.Label();
            this.lblDailyReport = new System.Windows.Forms.Label();
            this.dtpSelectDay = new System.Windows.Forms.DateTimePicker();
            this.rdoDailyReport = new System.Windows.Forms.RadioButton();
            this.lblMonthlyReport = new System.Windows.Forms.Label();
            this.rdoMonthlyReport = new System.Windows.Forms.RadioButton();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnBackToHomePage = new System.Windows.Forms.Button();
            this.pnlMainheading.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainheading
            // 
            this.pnlMainheading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMainheading.Controls.Add(this.lblMainHeading);
            this.pnlMainheading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainheading.Location = new System.Drawing.Point(0, 0);
            this.pnlMainheading.Name = "pnlMainheading";
            this.pnlMainheading.Size = new System.Drawing.Size(509, 70);
            this.pnlMainheading.TabIndex = 5;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(177, 26);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(186, 25);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Generate Report";
            // 
            // pnltaskBar
            // 
            this.pnltaskBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnltaskBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnltaskBar.Location = new System.Drawing.Point(0, 447);
            this.pnltaskBar.Name = "pnltaskBar";
            this.pnltaskBar.Size = new System.Drawing.Size(509, 15);
            this.pnltaskBar.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 35.8839F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 64.1161F));
            this.tableLayoutPanel1.Controls.Add(this.lblSelectDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblDailyReport, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.dtpSelectDay, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.rdoDailyReport, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblMonthlyReport, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rdoMonthlyReport, 1, 2);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 91);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 3;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(379, 108);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(3, 10);
            this.lblSelectDate.Name = "lblSelectDate";
            this.lblSelectDate.Size = new System.Drawing.Size(74, 16);
            this.lblSelectDate.TabIndex = 0;
            this.lblSelectDate.Text = "Pick Date";
            // 
            // lblDailyReport
            // 
            this.lblDailyReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblDailyReport.AutoSize = true;
            this.lblDailyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDailyReport.Location = new System.Drawing.Point(3, 46);
            this.lblDailyReport.Name = "lblDailyReport";
            this.lblDailyReport.Size = new System.Drawing.Size(94, 16);
            this.lblDailyReport.TabIndex = 0;
            this.lblDailyReport.Text = "Daily Report";
            // 
            // dtpSelectDay
            // 
            this.dtpSelectDay.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpSelectDay.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSelectDay.Location = new System.Drawing.Point(138, 8);
            this.dtpSelectDay.Name = "dtpSelectDay";
            this.dtpSelectDay.Size = new System.Drawing.Size(200, 20);
            this.dtpSelectDay.TabIndex = 1;
            // 
            // rdoDailyReport
            // 
            this.rdoDailyReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoDailyReport.AutoSize = true;
            this.rdoDailyReport.Location = new System.Drawing.Point(138, 45);
            this.rdoDailyReport.Name = "rdoDailyReport";
            this.rdoDailyReport.Size = new System.Drawing.Size(83, 17);
            this.rdoDailyReport.TabIndex = 2;
            this.rdoDailyReport.TabStop = true;
            this.rdoDailyReport.Text = "Daily Report";
            this.rdoDailyReport.UseVisualStyleBackColor = true;
            // 
            // lblMonthlyReport
            // 
            this.lblMonthlyReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMonthlyReport.AutoSize = true;
            this.lblMonthlyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyReport.Location = new System.Drawing.Point(3, 82);
            this.lblMonthlyReport.Name = "lblMonthlyReport";
            this.lblMonthlyReport.Size = new System.Drawing.Size(111, 16);
            this.lblMonthlyReport.TabIndex = 0;
            this.lblMonthlyReport.Text = "Monthly Report";
            // 
            // rdoMonthlyReport
            // 
            this.rdoMonthlyReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoMonthlyReport.AutoSize = true;
            this.rdoMonthlyReport.Location = new System.Drawing.Point(138, 81);
            this.rdoMonthlyReport.Name = "rdoMonthlyReport";
            this.rdoMonthlyReport.Size = new System.Drawing.Size(97, 17);
            this.rdoMonthlyReport.TabIndex = 3;
            this.rdoMonthlyReport.TabStop = true;
            this.rdoMonthlyReport.Text = "Monthly Report";
            this.rdoMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(182, 209);
            this.btnGenerateReport.Name = "btnGenerateReport";
            this.btnGenerateReport.Size = new System.Drawing.Size(200, 27);
            this.btnGenerateReport.TabIndex = 8;
            this.btnGenerateReport.Text = "Generate Report";
            this.btnGenerateReport.UseVisualStyleBackColor = true;
            this.btnGenerateReport.Click += new System.EventHandler(this.btnGenerateReport_Click);
            // 
            // dgvReport
            // 
            this.dgvReport.AllowUserToAddRows = false;
            this.dgvReport.AllowUserToDeleteRows = false;
            this.dgvReport.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReport.Location = new System.Drawing.Point(44, 258);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(393, 150);
            this.dgvReport.TabIndex = 9;
            // 
            // btnBackToHomePage
            // 
            this.btnBackToHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHomePage.Location = new System.Drawing.Point(44, 414);
            this.btnBackToHomePage.Name = "btnBackToHomePage";
            this.btnBackToHomePage.Size = new System.Drawing.Size(393, 27);
            this.btnBackToHomePage.TabIndex = 10;
            this.btnBackToHomePage.Text = "Back to Home Page";
            this.btnBackToHomePage.UseVisualStyleBackColor = true;
            // 
            // frmGenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 462);
            this.Controls.Add(this.btnBackToHomePage);
            this.Controls.Add(this.dgvReport);
            this.Controls.Add(this.btnGenerateReport);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnltaskBar);
            this.Controls.Add(this.pnlMainheading);
            this.Name = "frmGenerateReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Generate Report";
            this.pnlMainheading.ResumeLayout(false);
            this.pnlMainheading.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReport)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainheading;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Panel pnltaskBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblDailyReport;
        private System.Windows.Forms.DateTimePicker dtpSelectDay;
        private System.Windows.Forms.RadioButton rdoDailyReport;
        private System.Windows.Forms.Label lblMonthlyReport;
        private System.Windows.Forms.RadioButton rdoMonthlyReport;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnBackToHomePage;
    }
}