namespace BisleriumCafePOSSystem.Windows
{
    partial class frmCoffeeManagement
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
            this.lblCoffeeType = new System.Windows.Forms.Label();
            this.lblCoffeePrice = new System.Windows.Forms.Label();
            this.txtCoffeeType = new System.Windows.Forms.TextBox();
            this.txtCoffeePrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvCoffeeTypeData = new System.Windows.Forms.DataGridView();
            this.btnBackToHomeScreen = new System.Windows.Forms.Button();
            this.pnlMainheading.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffeeTypeData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainheading
            // 
            this.pnlMainheading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMainheading.Controls.Add(this.lblMainHeading);
            this.pnlMainheading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainheading.Location = new System.Drawing.Point(0, 0);
            this.pnlMainheading.Name = "pnlMainheading";
            this.pnlMainheading.Size = new System.Drawing.Size(515, 70);
            this.pnlMainheading.TabIndex = 2;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(153, 30);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(223, 25);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Coffee Management";
            // 
            // pnltaskBar
            // 
            this.pnltaskBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnltaskBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnltaskBar.Location = new System.Drawing.Point(0, 469);
            this.pnltaskBar.Name = "pnltaskBar";
            this.pnltaskBar.Size = new System.Drawing.Size(515, 15);
            this.pnltaskBar.TabIndex = 3;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 31.97492F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 68.02508F));
            this.tableLayoutPanel1.Controls.Add(this.lblCoffeeType, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblCoffeePrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtCoffeeType, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtCoffeePrice, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(49, 89);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(406, 100);
            this.tableLayoutPanel1.TabIndex = 4;
            // 
            // lblCoffeeType
            // 
            this.lblCoffeeType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCoffeeType.AutoSize = true;
            this.lblCoffeeType.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeeType.Location = new System.Drawing.Point(3, 17);
            this.lblCoffeeType.Name = "lblCoffeeType";
            this.lblCoffeeType.Size = new System.Drawing.Size(92, 16);
            this.lblCoffeeType.TabIndex = 0;
            this.lblCoffeeType.Text = "Coffee Type";
            // 
            // lblCoffeePrice
            // 
            this.lblCoffeePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblCoffeePrice.AutoSize = true;
            this.lblCoffeePrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCoffeePrice.Location = new System.Drawing.Point(3, 67);
            this.lblCoffeePrice.Name = "lblCoffeePrice";
            this.lblCoffeePrice.Size = new System.Drawing.Size(43, 16);
            this.lblCoffeePrice.TabIndex = 0;
            this.lblCoffeePrice.Text = "Price";
            // 
            // txtCoffeeType
            // 
            this.txtCoffeeType.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCoffeeType.Location = new System.Drawing.Point(132, 15);
            this.txtCoffeeType.Name = "txtCoffeeType";
            this.txtCoffeeType.Size = new System.Drawing.Size(256, 20);
            this.txtCoffeeType.TabIndex = 0;
            // 
            // txtCoffeePrice
            // 
            this.txtCoffeePrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtCoffeePrice.Location = new System.Drawing.Point(132, 65);
            this.txtCoffeePrice.Name = "txtCoffeePrice";
            this.txtCoffeePrice.Size = new System.Drawing.Size(256, 20);
            this.txtCoffeePrice.TabIndex = 1;
            this.txtCoffeePrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtCoffeePrice_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(122, 221);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(95, 28);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(235, 221);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(95, 28);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(346, 221);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(95, 28);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvCoffeeTypeData
            // 
            this.dgvCoffeeTypeData.AllowUserToAddRows = false;
            this.dgvCoffeeTypeData.AllowUserToDeleteRows = false;
            this.dgvCoffeeTypeData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvCoffeeTypeData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCoffeeTypeData.Location = new System.Drawing.Point(59, 279);
            this.dgvCoffeeTypeData.MultiSelect = false;
            this.dgvCoffeeTypeData.Name = "dgvCoffeeTypeData";
            this.dgvCoffeeTypeData.ReadOnly = true;
            this.dgvCoffeeTypeData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCoffeeTypeData.Size = new System.Drawing.Size(382, 150);
            this.dgvCoffeeTypeData.TabIndex = 5;
            this.dgvCoffeeTypeData.SelectionChanged += new System.EventHandler(this.dgvCoffeeTypeData_SelectionChanged);
            // 
            // btnBackToHomeScreen
            // 
            this.btnBackToHomeScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHomeScreen.Location = new System.Drawing.Point(59, 436);
            this.btnBackToHomeScreen.Name = "btnBackToHomeScreen";
            this.btnBackToHomeScreen.Size = new System.Drawing.Size(382, 27);
            this.btnBackToHomeScreen.TabIndex = 6;
            this.btnBackToHomeScreen.Text = "Back to Home Screen";
            this.btnBackToHomeScreen.UseVisualStyleBackColor = true;
            this.btnBackToHomeScreen.Click += new System.EventHandler(this.btnBackToHomeScreen_Click);
            // 
            // frmCoffeeManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 484);
            this.Controls.Add(this.btnBackToHomeScreen);
            this.Controls.Add(this.dgvCoffeeTypeData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnltaskBar);
            this.Controls.Add(this.pnlMainheading);
            this.Name = "frmCoffeeManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coffee Management";
            this.Load += new System.EventHandler(this.frmCoffeeManagement_Load);
            this.pnlMainheading.ResumeLayout(false);
            this.pnlMainheading.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCoffeeTypeData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainheading;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Panel pnltaskBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblCoffeeType;
        private System.Windows.Forms.Label lblCoffeePrice;
        private System.Windows.Forms.TextBox txtCoffeeType;
        private System.Windows.Forms.TextBox txtCoffeePrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvCoffeeTypeData;
        private System.Windows.Forms.Button btnBackToHomeScreen;
    }
}