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
            this.dtpSelectDate = new System.Windows.Forms.DateTimePicker();
            this.rdoTopFiveDailyReport = new System.Windows.Forms.RadioButton();
            this.lblMonthlyReport = new System.Windows.Forms.Label();
            this.rdoTopFiveMonthlyReport = new System.Windows.Forms.RadioButton();
            this.btnGenerateReport = new System.Windows.Forms.Button();
            this.dgvReport = new System.Windows.Forms.DataGridView();
            this.btnBackToHomePage = new System.Windows.Forms.Button();
            this.lblTopFiveSales = new System.Windows.Forms.Label();
            this.rdoTopFiveSales = new System.Windows.Forms.RadioButton();
            this.btnDownloadReport = new System.Windows.Forms.Button();
            this.lblAllSales = new System.Windows.Forms.Label();
            this.rdoAllSales = new System.Windows.Forms.RadioButton();
            this.lblTotalRevenue = new System.Windows.Forms.Label();
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
            this.pnltaskBar.Location = new System.Drawing.Point(0, 522);
            this.pnltaskBar.Name = "pnltaskBar";
            this.pnltaskBar.Size = new System.Drawing.Size(509, 15);
            this.pnltaskBar.TabIndex = 6;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.93069F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.06931F));
            this.tableLayoutPanel1.Controls.Add(this.lblSelectDate, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.dtpSelectDate, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblMonthlyReport, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblDailyReport, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.rdoTopFiveMonthlyReport, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.rdoTopFiveDailyReport, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblTopFiveSales, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.rdoTopFiveSales, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblAllSales, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.rdoAllSales, 1, 4);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(44, 96);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 5;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 20F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(404, 142);
            this.tableLayoutPanel1.TabIndex = 7;
            // 
            // lblSelectDate
            // 
            this.lblSelectDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblSelectDate.AutoSize = true;
            this.lblSelectDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectDate.Location = new System.Drawing.Point(3, 6);
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
            this.lblDailyReport.Location = new System.Drawing.Point(3, 62);
            this.lblDailyReport.Name = "lblDailyReport";
            this.lblDailyReport.Size = new System.Drawing.Size(94, 16);
            this.lblDailyReport.TabIndex = 0;
            this.lblDailyReport.Text = "Daily Report";
            // 
            // dtpSelectDate
            // 
            this.dtpSelectDate.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.dtpSelectDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpSelectDate.Location = new System.Drawing.Point(131, 4);
            this.dtpSelectDate.Name = "dtpSelectDate";
            this.dtpSelectDate.Size = new System.Drawing.Size(246, 20);
            this.dtpSelectDate.TabIndex = 1;
            // 
            // rdoTopFiveDailyReport
            // 
            this.rdoTopFiveDailyReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoTopFiveDailyReport.AutoSize = true;
            this.rdoTopFiveDailyReport.Location = new System.Drawing.Point(131, 61);
            this.rdoTopFiveDailyReport.Name = "rdoTopFiveDailyReport";
            this.rdoTopFiveDailyReport.Size = new System.Drawing.Size(122, 17);
            this.rdoTopFiveDailyReport.TabIndex = 2;
            this.rdoTopFiveDailyReport.TabStop = true;
            this.rdoTopFiveDailyReport.Text = "Top Five Daily Sales";
            this.rdoTopFiveDailyReport.UseVisualStyleBackColor = true;
            // 
            // lblMonthlyReport
            // 
            this.lblMonthlyReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblMonthlyReport.AutoSize = true;
            this.lblMonthlyReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMonthlyReport.Location = new System.Drawing.Point(3, 90);
            this.lblMonthlyReport.Name = "lblMonthlyReport";
            this.lblMonthlyReport.Size = new System.Drawing.Size(111, 16);
            this.lblMonthlyReport.TabIndex = 0;
            this.lblMonthlyReport.Text = "Monthly Report";
            // 
            // rdoTopFiveMonthlyReport
            // 
            this.rdoTopFiveMonthlyReport.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.rdoTopFiveMonthlyReport.AutoSize = true;
            this.rdoTopFiveMonthlyReport.Location = new System.Drawing.Point(131, 89);
            this.rdoTopFiveMonthlyReport.Name = "rdoTopFiveMonthlyReport";
            this.rdoTopFiveMonthlyReport.Size = new System.Drawing.Size(136, 17);
            this.rdoTopFiveMonthlyReport.TabIndex = 3;
            this.rdoTopFiveMonthlyReport.TabStop = true;
            this.rdoTopFiveMonthlyReport.Text = "Top Five Monthly Sales";
            this.rdoTopFiveMonthlyReport.UseVisualStyleBackColor = true;
            // 
            // btnGenerateReport
            // 
            this.btnGenerateReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGenerateReport.Location = new System.Drawing.Point(221, 295);
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
            this.dgvReport.Location = new System.Drawing.Point(44, 328);
            this.dgvReport.Name = "dgvReport";
            this.dgvReport.ReadOnly = true;
            this.dgvReport.Size = new System.Drawing.Size(393, 150);
            this.dgvReport.TabIndex = 9;
            // 
            // btnBackToHomePage
            // 
            this.btnBackToHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHomePage.Location = new System.Drawing.Point(44, 484);
            this.btnBackToHomePage.Name = "btnBackToHomePage";
            this.btnBackToHomePage.Size = new System.Drawing.Size(393, 32);
            this.btnBackToHomePage.TabIndex = 10;
            this.btnBackToHomePage.Text = "Back to Home Page";
            this.btnBackToHomePage.UseVisualStyleBackColor = true;
            this.btnBackToHomePage.Click += new System.EventHandler(this.btnBackToHomePage_Click);
            // 
            // lblTopFiveSales
            // 
            this.lblTopFiveSales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblTopFiveSales.AutoSize = true;
            this.lblTopFiveSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTopFiveSales.Location = new System.Drawing.Point(3, 34);
            this.lblTopFiveSales.Name = "lblTopFiveSales";
            this.lblTopFiveSales.Size = new System.Drawing.Size(113, 16);
            this.lblTopFiveSales.TabIndex = 0;
            this.lblTopFiveSales.Text = "Top Five Sales";
            // 
            // rdoTopFiveSales
            // 
            this.rdoTopFiveSales.AutoSize = true;
            this.rdoTopFiveSales.Location = new System.Drawing.Point(131, 31);
            this.rdoTopFiveSales.Name = "rdoTopFiveSales";
            this.rdoTopFiveSales.Size = new System.Drawing.Size(99, 17);
            this.rdoTopFiveSales.TabIndex = 4;
            this.rdoTopFiveSales.TabStop = true;
            this.rdoTopFiveSales.Text = "Top Five Sales ";
            this.rdoTopFiveSales.UseVisualStyleBackColor = true;
            // 
            // btnDownloadReport
            // 
            this.btnDownloadReport.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDownloadReport.Location = new System.Drawing.Point(59, 295);
            this.btnDownloadReport.Name = "btnDownloadReport";
            this.btnDownloadReport.Size = new System.Drawing.Size(156, 27);
            this.btnDownloadReport.TabIndex = 11;
            this.btnDownloadReport.Text = "Download Report";
            this.btnDownloadReport.UseVisualStyleBackColor = true;
            this.btnDownloadReport.Click += new System.EventHandler(this.btnDownloadReport_Click);
            // 
            // lblAllSales
            // 
            this.lblAllSales.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAllSales.AutoSize = true;
            this.lblAllSales.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAllSales.Location = new System.Drawing.Point(3, 119);
            this.lblAllSales.Name = "lblAllSales";
            this.lblAllSales.Size = new System.Drawing.Size(69, 16);
            this.lblAllSales.TabIndex = 0;
            this.lblAllSales.Text = "All Sales";
            // 
            // rdoAllSales
            // 
            this.rdoAllSales.AutoSize = true;
            this.rdoAllSales.Location = new System.Drawing.Point(131, 115);
            this.rdoAllSales.Name = "rdoAllSales";
            this.rdoAllSales.Size = new System.Drawing.Size(65, 17);
            this.rdoAllSales.TabIndex = 5;
            this.rdoAllSales.TabStop = true;
            this.rdoAllSales.Text = "All Sales";
            this.rdoAllSales.UseVisualStyleBackColor = true;
            // 
            // lblTotalRevenue
            // 
            this.lblTotalRevenue.AutoSize = true;
            this.lblTotalRevenue.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalRevenue.Location = new System.Drawing.Point(59, 256);
            this.lblTotalRevenue.Name = "lblTotalRevenue";
            this.lblTotalRevenue.Size = new System.Drawing.Size(109, 16);
            this.lblTotalRevenue.TabIndex = 12;
            this.lblTotalRevenue.Text = "Total Revenue";
            // 
            // frmGenerateReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(509, 537);
            this.Controls.Add(this.lblTotalRevenue);
            this.Controls.Add(this.btnDownloadReport);
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
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainheading;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Panel pnltaskBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblSelectDate;
        private System.Windows.Forms.Label lblDailyReport;
        private System.Windows.Forms.DateTimePicker dtpSelectDate;
        private System.Windows.Forms.RadioButton rdoTopFiveDailyReport;
        private System.Windows.Forms.Label lblMonthlyReport;
        private System.Windows.Forms.RadioButton rdoTopFiveMonthlyReport;
        private System.Windows.Forms.Button btnGenerateReport;
        private System.Windows.Forms.DataGridView dgvReport;
        private System.Windows.Forms.Button btnBackToHomePage;
        private System.Windows.Forms.Label lblTopFiveSales;
        private System.Windows.Forms.RadioButton rdoTopFiveSales;
        private System.Windows.Forms.Button btnDownloadReport;
        private System.Windows.Forms.Label lblAllSales;
        private System.Windows.Forms.RadioButton rdoAllSales;
        private System.Windows.Forms.Label lblTotalRevenue;
    }
}