namespace BisleriumCafePOSSystem.Windows
{
    partial class frmAddInsManagement
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
            this.lblAddinName = new System.Windows.Forms.Label();
            this.lblAddinPrice = new System.Windows.Forms.Label();
            this.txtAddinName = new System.Windows.Forms.TextBox();
            this.txtAddinPrice = new System.Windows.Forms.TextBox();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.dgvAddinsData = new System.Windows.Forms.DataGridView();
            this.btnBackToHomeScreen = new System.Windows.Forms.Button();
            this.pnlMainheading.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddinsData)).BeginInit();
            this.SuspendLayout();
            // 
            // pnlMainheading
            // 
            this.pnlMainheading.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnlMainheading.Controls.Add(this.lblMainHeading);
            this.pnlMainheading.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlMainheading.Location = new System.Drawing.Point(0, 0);
            this.pnlMainheading.Name = "pnlMainheading";
            this.pnlMainheading.Size = new System.Drawing.Size(494, 70);
            this.pnlMainheading.TabIndex = 3;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(135, 28);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(234, 25);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Add-ins Management";
            // 
            // pnltaskBar
            // 
            this.pnltaskBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnltaskBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnltaskBar.Location = new System.Drawing.Point(0, 469);
            this.pnltaskBar.Name = "pnltaskBar";
            this.pnltaskBar.Size = new System.Drawing.Size(494, 15);
            this.pnltaskBar.TabIndex = 4;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 22.18182F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 77.81818F));
            this.tableLayoutPanel1.Controls.Add(this.lblAddinName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.lblAddinPrice, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.txtAddinName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtAddinPrice, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(52, 92);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 100);
            this.tableLayoutPanel1.TabIndex = 5;
            // 
            // lblAddinName
            // 
            this.lblAddinName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddinName.AutoSize = true;
            this.lblAddinName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddinName.Location = new System.Drawing.Point(3, 17);
            this.lblAddinName.Name = "lblAddinName";
            this.lblAddinName.Size = new System.Drawing.Size(48, 16);
            this.lblAddinName.TabIndex = 0;
            this.lblAddinName.Text = "Name";
            // 
            // lblAddinPrice
            // 
            this.lblAddinPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblAddinPrice.AutoSize = true;
            this.lblAddinPrice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAddinPrice.Location = new System.Drawing.Point(3, 67);
            this.lblAddinPrice.Name = "lblAddinPrice";
            this.lblAddinPrice.Size = new System.Drawing.Size(43, 16);
            this.lblAddinPrice.TabIndex = 0;
            this.lblAddinPrice.Text = "Price";
            // 
            // txtAddinName
            // 
            this.txtAddinName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAddinName.Location = new System.Drawing.Point(88, 15);
            this.txtAddinName.Name = "txtAddinName";
            this.txtAddinName.Size = new System.Drawing.Size(273, 20);
            this.txtAddinName.TabIndex = 0;
            // 
            // txtAddinPrice
            // 
            this.txtAddinPrice.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtAddinPrice.Location = new System.Drawing.Point(88, 65);
            this.txtAddinPrice.Name = "txtAddinPrice";
            this.txtAddinPrice.Size = new System.Drawing.Size(273, 20);
            this.txtAddinPrice.TabIndex = 1;
            this.txtAddinPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtAddinPrice_KeyPress);
            // 
            // btnAdd
            // 
            this.btnAdd.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAdd.Location = new System.Drawing.Point(140, 224);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(87, 27);
            this.btnAdd.TabIndex = 2;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(233, 224);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(87, 27);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelete.Location = new System.Drawing.Point(326, 224);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(87, 27);
            this.btnDelete.TabIndex = 4;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // dgvAddinsData
            // 
            this.dgvAddinsData.AllowUserToAddRows = false;
            this.dgvAddinsData.AllowUserToDeleteRows = false;
            this.dgvAddinsData.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAddinsData.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAddinsData.Location = new System.Drawing.Point(58, 282);
            this.dgvAddinsData.MultiSelect = false;
            this.dgvAddinsData.Name = "dgvAddinsData";
            this.dgvAddinsData.ReadOnly = true;
            this.dgvAddinsData.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAddinsData.Size = new System.Drawing.Size(355, 150);
            this.dgvAddinsData.TabIndex = 6;
            this.dgvAddinsData.SelectionChanged += new System.EventHandler(this.dgvAddinsData_SelectionChanged);
            // 
            // btnBackToHomeScreen
            // 
            this.btnBackToHomeScreen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackToHomeScreen.Location = new System.Drawing.Point(58, 439);
            this.btnBackToHomeScreen.Name = "btnBackToHomeScreen";
            this.btnBackToHomeScreen.Size = new System.Drawing.Size(355, 24);
            this.btnBackToHomeScreen.TabIndex = 7;
            this.btnBackToHomeScreen.Text = "Back to Home Screen";
            this.btnBackToHomeScreen.UseVisualStyleBackColor = true;
            this.btnBackToHomeScreen.Click += new System.EventHandler(this.btnBackToHomeScreen_Click);
            // 
            // frmAddInsManagement
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(494, 484);
            this.Controls.Add(this.btnBackToHomeScreen);
            this.Controls.Add(this.dgvAddinsData);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnltaskBar);
            this.Controls.Add(this.pnlMainheading);
            this.Name = "frmAddInsManagement";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "AddIns Management";
            this.Load += new System.EventHandler(this.frmAddInsManagement_Load);
            this.pnlMainheading.ResumeLayout(false);
            this.pnlMainheading.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAddinsData)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainheading;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.Panel pnltaskBar;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblAddinName;
        private System.Windows.Forms.Label lblAddinPrice;
        private System.Windows.Forms.TextBox txtAddinName;
        private System.Windows.Forms.TextBox txtAddinPrice;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridView dgvAddinsData;
        private System.Windows.Forms.Button btnBackToHomeScreen;
    }
}