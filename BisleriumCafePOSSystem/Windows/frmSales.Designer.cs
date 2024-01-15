namespace BisleriumCafePOSSystem.Windows
{
    partial class frmSales
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
            this.cklCoffeeAddIns = new System.Windows.Forms.CheckedListBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblTotalBill = new System.Windows.Forms.Label();
            this.lblChooseCoffeeType = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.lblQuantity = new System.Windows.Forms.Label();
            this.cmbCoffeeTypes = new System.Windows.Forms.ComboBox();
            this.txtCustomerName = new System.Windows.Forms.TextBox();
            this.txtCustomerPhoneNumber = new System.Windows.Forms.TextBox();
            this.nudCoffeeQuantity = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.dtpOrderDate = new System.Windows.Forms.DateTimePicker();
            this.lblDiscount = new System.Windows.Forms.Label();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtTotalBill = new System.Windows.Forms.TextBox();
            this.lblChooseAddIns = new System.Windows.Forms.Label();
            this.btnAddToSale = new System.Windows.Forms.Button();
            this.dgvSales = new System.Windows.Forms.DataGridView();
            this.btnBackToHomePage = new System.Windows.Forms.Button();
            this.btnProceedSale = new System.Windows.Forms.Button();
            this.pnlMainheading.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoffeeQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainheading
            // 
            this.pnlMainheading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMainheading.Controls.Add(this.lblMainHeading);
            this.pnlMainheading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainheading.Location = new System.Drawing.Point(0, 0);
            this.pnlMainheading.Name = "pnlMainheading";
            this.pnlMainheading.Size = new System.Drawing.Size(730, 70);
            this.pnlMainheading.TabIndex = 3;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(279, 31);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(139, 25);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Order Detail";
            // 
            // pnltaskBar
            // 
            this.pnltaskBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnltaskBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnltaskBar.Location = new System.Drawing.Point(0, 610);
            this.pnltaskBar.Name = "pnltaskBar";
            this.pnltaskBar.Size = new System.Drawing.Size(730, 15);
            this.pnltaskBar.TabIndex = 4;
            // 
            // cklCoffeeAddIns
            // 
            this.cklCoffeeAddIns.FormattingEnabled = true;
            this.cklCoffeeAddIns.Location = new System.Drawing.Point(23, 126);
            this.cklCoffeeAddIns.Name = "cklCoffeeAddIns";
            this.cklCoffeeAddIns.Size = new System.Drawing.Size(167, 349);
            this.cklCoffeeAddIns.TabIndex = 5;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 28.71046F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 71.28954F));
            this.tableLayoutPanel1.Controls.Add(this.lblTotalBill, 0, 6);
            this.tableLayoutPanel1.Controls.Add(this.lblChooseCoffeeType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneNumber, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.lblQuantity, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.cmbCoffeeTypes, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerName, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCustomerPhoneNumber, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.nudCoffeeQuantity, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.dtpOrderDate, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblDiscount, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtDiscount, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtTotalBill, 1, 6);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(241, 126);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 7;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 14.28571F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(435, 200);
            this.tableLayoutPanel1.TabIndex = 6;
            // 
            // lblTotalBill
            // 
            this.lblTotalBill.AutoSize = true;
            this.lblTotalBill.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBill.Location = new System.Drawing.Point(3, 168);
            this.lblTotalBill.Name = "lblTotalBill";
            this.lblTotalBill.Size = new System.Drawing.Size(69, 16);
            this.lblTotalBill.TabIndex = 10;
            this.lblTotalBill.Text = "Total Bill";
            // 
            // lblChooseCoffeeType
            // 
            this.lblChooseCoffeeType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblChooseCoffeeType.AutoSize = true;
            this.lblChooseCoffeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseCoffeeType.Location = new System.Drawing.Point(3, 6);
            this.lblChooseCoffeeType.Name = "lblChooseCoffeeType";
            this.lblChooseCoffeeType.Size = new System.Drawing.Size(92, 16);
            this.lblChooseCoffeeType.TabIndex = 0;
            this.lblChooseCoffeeType.Text = "Coffee Type";
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 34);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(48, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 62);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(109, 16);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblQuantity
            // 
            this.lblQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblQuantity.AutoSize = true;
            this.lblQuantity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblQuantity.Location = new System.Drawing.Point(3, 90);
            this.lblQuantity.Name = "lblQuantity";
            this.lblQuantity.Size = new System.Drawing.Size(63, 16);
            this.lblQuantity.TabIndex = 0;
            this.lblQuantity.Text = "Quantity";
            // 
            // cmbCoffeeTypes
            // 
            this.cmbCoffeeTypes.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbCoffeeTypes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbCoffeeTypes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbCoffeeTypes.FormattingEnabled = true;
            this.cmbCoffeeTypes.Location = new System.Drawing.Point(127, 3);
            this.cmbCoffeeTypes.Name = "cmbCoffeeTypes";
            this.cmbCoffeeTypes.Size = new System.Drawing.Size(272, 21);
            this.cmbCoffeeTypes.TabIndex = 0;
            // 
            // txtCustomerName
            // 
            this.txtCustomerName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustomerName.Location = new System.Drawing.Point(127, 32);
            this.txtCustomerName.Name = "txtCustomerName";
            this.txtCustomerName.Size = new System.Drawing.Size(272, 20);
            this.txtCustomerName.TabIndex = 2;
            this.txtCustomerName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerName_KeyPress);
            // 
            // txtCustomerPhoneNumber
            // 
            this.txtCustomerPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCustomerPhoneNumber.Location = new System.Drawing.Point(127, 60);
            this.txtCustomerPhoneNumber.Name = "txtCustomerPhoneNumber";
            this.txtCustomerPhoneNumber.Size = new System.Drawing.Size(272, 20);
            this.txtCustomerPhoneNumber.TabIndex = 2;
            this.txtCustomerPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCustomerPhoneNumber_KeyPress);
            // 
            // nudCoffeeQuantity
            // 
            this.nudCoffeeQuantity.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.nudCoffeeQuantity.Location = new System.Drawing.Point(127, 88);
            this.nudCoffeeQuantity.Name = "nudCoffeeQuantity";
            this.nudCoffeeQuantity.Size = new System.Drawing.Size(272, 20);
            this.nudCoffeeQuantity.TabIndex = 3;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 118);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Date";
            // 
            // dtpOrderDate
            // 
            this.dtpOrderDate.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpOrderDate.Location = new System.Drawing.Point(127, 115);
            this.dtpOrderDate.Name = "dtpOrderDate";
            this.dtpOrderDate.Size = new System.Drawing.Size(272, 20);
            this.dtpOrderDate.TabIndex = 4;
            // 
            // lblDiscount
            // 
            this.lblDiscount.AutoSize = true;
            this.lblDiscount.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDiscount.Location = new System.Drawing.Point(3, 140);
            this.lblDiscount.Name = "lblDiscount";
            this.lblDiscount.Size = new System.Drawing.Size(67, 16);
            this.lblDiscount.TabIndex = 10;
            this.lblDiscount.Text = "Discount";
            // 
            // txtDiscount
            // 
            this.txtDiscount.Location = new System.Drawing.Point(127, 143);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(272, 20);
            this.txtDiscount.TabIndex = 11;
            // 
            // txtTotalBill
            // 
            this.txtTotalBill.Location = new System.Drawing.Point(127, 171);
            this.txtTotalBill.Name = "txtTotalBill";
            this.txtTotalBill.Size = new System.Drawing.Size(272, 20);
            this.txtTotalBill.TabIndex = 11;
            // 
            // lblChooseAddIns
            // 
            this.lblChooseAddIns.AutoSize = true;
            this.lblChooseAddIns.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblChooseAddIns.Location = new System.Drawing.Point(23, 96);
            this.lblChooseAddIns.Name = "lblChooseAddIns";
            this.lblChooseAddIns.Size = new System.Drawing.Size(144, 20);
            this.lblChooseAddIns.TabIndex = 7;
            this.lblChooseAddIns.Text = "Choose AddIn(s)";
            // 
            // btnAddToSale
            // 
            this.btnAddToSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddToSale.Location = new System.Drawing.Point(368, 364);
            this.btnAddToSale.Name = "btnAddToSale";
            this.btnAddToSale.Size = new System.Drawing.Size(116, 28);
            this.btnAddToSale.TabIndex = 5;
            this.btnAddToSale.Text = "Add to Sale";
            this.btnAddToSale.UseVisualStyleBackColor = true;
            this.btnAddToSale.Click += new System.EventHandler(this.btnAddToSale_Click);
            // 
            // dgvSales
            // 
            this.dgvSales.AllowUserToAddRows = false;
            this.dgvSales.AllowUserToDeleteRows = false;
            this.dgvSales.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvSales.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSales.Location = new System.Drawing.Point(241, 408);
            this.dgvSales.Name = "dgvSales";
            this.dgvSales.ReadOnly = true;
            this.dgvSales.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSales.Size = new System.Drawing.Size(399, 150);
            this.dgvSales.TabIndex = 8;
            // 
            // btnBackToHomePage
            // 
            this.btnBackToHomePage.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHomePage.Location = new System.Drawing.Point(241, 564);
            this.btnBackToHomePage.Name = "btnBackToHomePage";
            this.btnBackToHomePage.Size = new System.Drawing.Size(399, 30);
            this.btnBackToHomePage.TabIndex = 9;
            this.btnBackToHomePage.Text = "Back to Home Page";
            this.btnBackToHomePage.UseVisualStyleBackColor = true;
            this.btnBackToHomePage.Click += new System.EventHandler(this.btnBackToHomePage_Click);
            // 
            // btnProceedSale
            // 
            this.btnProceedSale.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProceedSale.Location = new System.Drawing.Point(505, 364);
            this.btnProceedSale.Name = "btnProceedSale";
            this.btnProceedSale.Size = new System.Drawing.Size(135, 28);
            this.btnProceedSale.TabIndex = 10;
            this.btnProceedSale.Text = "Proceed Sale";
            this.btnProceedSale.UseVisualStyleBackColor = true;
            this.btnProceedSale.Click += new System.EventHandler(this.btnProceedSale_Click);
            // 
            // frmSales
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(730, 625);
            this.Controls.Add(this.btnProceedSale);
            this.Controls.Add(this.btnBackToHomePage);
            this.Controls.Add(this.dgvSales);
            this.Controls.Add(this.btnAddToSale);
            this.Controls.Add(this.lblChooseAddIns);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.cklCoffeeAddIns);
            this.Controls.Add(this.pnltaskBar);
            this.Controls.Add(this.pnlMainheading);
            this.Name = "frmSales";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Customer Order";
            this.Load += new System.EventHandler(this.frmSales_Load);
            this.pnlMainheading.ResumeLayout(false);
            this.pnlMainheading.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudCoffeeQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSales)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainheading;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Panel pnltaskBar;
        private System.Windows.Forms.CheckedListBox cklCoffeeAddIns;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblChooseAddIns;
        private System.Windows.Forms.Label lblChooseCoffeeType;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.Label lblQuantity;
        private System.Windows.Forms.ComboBox cmbCoffeeTypes;
        private System.Windows.Forms.TextBox txtCustomerName;
        private System.Windows.Forms.TextBox txtCustomerPhoneNumber;
        private System.Windows.Forms.NumericUpDown nudCoffeeQuantity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dtpOrderDate;
        private System.Windows.Forms.Button btnAddToSale;
        private System.Windows.Forms.DataGridView dgvSales;
        private System.Windows.Forms.Button btnBackToHomePage;
        private System.Windows.Forms.Label lblDiscount;
        private System.Windows.Forms.Label lblTotalBill;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.TextBox txtTotalBill;
        private System.Windows.Forms.Button btnProceedSale;
    }
}