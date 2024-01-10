namespace BisleriumCafePOSSystem
{
    partial class frmMain
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
            this.pnlMainheading = new System.Windows.Forms.Panel();
            this.lblMainHeading = new System.Windows.Forms.Label();
            this.pnltaskBar = new System.Windows.Forms.Panel();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.lblName = new System.Windows.Forms.Label();
            this.txtFullName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.lblPhoneNumber = new System.Windows.Forms.Label();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.lblRole = new System.Windows.Forms.Label();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.btnSignup = new System.Windows.Forms.Button();
            this.chkShowPassword = new System.Windows.Forms.CheckBox();
            this.errEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.btnClearFields = new System.Windows.Forms.Button();
            this.llbAlreadyRegistered = new System.Windows.Forms.LinkLabel();
            this.pnlMainheading.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).BeginInit();
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
            this.pnlMainheading.TabIndex = 0;
            // 
            // lblMainHeading
            // 
            this.lblMainHeading.AutoSize = true;
            this.lblMainHeading.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMainHeading.Location = new System.Drawing.Point(215, 23);
            this.lblMainHeading.Name = "lblMainHeading";
            this.lblMainHeading.Size = new System.Drawing.Size(92, 25);
            this.lblMainHeading.TabIndex = 0;
            this.lblMainHeading.Text = "Sign up";
            // 
            // pnltaskBar
            // 
            this.pnltaskBar.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pnltaskBar.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnltaskBar.Location = new System.Drawing.Point(0, 517);
            this.pnltaskBar.Name = "pnltaskBar";
            this.pnltaskBar.Size = new System.Drawing.Size(515, 15);
            this.pnltaskBar.TabIndex = 1;
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 2;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 36.59942F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 63.40058F));
            this.tableLayoutPanel1.Controls.Add(this.lblName, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.txtFullName, 1, 0);
            this.tableLayoutPanel1.Controls.Add(this.label1, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.txtPassword, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.lblPhoneNumber, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.txtPhoneNumber, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.lblEmail, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.txtEmail, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.lblRole, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.txtRole, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.label2, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.cmbGender, 1, 1);
            this.tableLayoutPanel1.Location = new System.Drawing.Point(21, 88);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.66667F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(443, 267);
            this.tableLayoutPanel1.TabIndex = 2;
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(3, 14);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(77, 16);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Full Name";
            // 
            // txtFullName
            // 
            this.txtFullName.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtFullName.Location = new System.Drawing.Point(165, 12);
            this.txtFullName.Name = "txtFullName";
            this.txtFullName.Size = new System.Drawing.Size(254, 20);
            this.txtFullName.TabIndex = 0;
            this.txtFullName.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFullName_KeyPress);
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(3, 235);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Password";
            // 
            // txtPassword
            // 
            this.txtPassword.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPassword.Location = new System.Drawing.Point(165, 233);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.Size = new System.Drawing.Size(254, 20);
            this.txtPassword.TabIndex = 5;
            this.txtPassword.UseSystemPasswordChar = true;
            this.txtPassword.Leave += new System.EventHandler(this.txtPassword_Leave);
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPhoneNumber.Location = new System.Drawing.Point(3, 190);
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(109, 16);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtPhoneNumber.Location = new System.Drawing.Point(165, 188);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(254, 20);
            this.txtPhoneNumber.TabIndex = 4;
            this.txtPhoneNumber.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPhoneNumber_KeyPress);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblEmail.Location = new System.Drawing.Point(3, 146);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(46, 16);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "Email";
            // 
            // txtEmail
            // 
            this.txtEmail.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtEmail.Location = new System.Drawing.Point(165, 144);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(254, 20);
            this.txtEmail.TabIndex = 3;
            this.txtEmail.Leave += new System.EventHandler(this.txtEmail_Leave);
            // 
            // lblRole
            // 
            this.lblRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.lblRole.AutoSize = true;
            this.lblRole.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRole.Location = new System.Drawing.Point(3, 102);
            this.lblRole.Name = "lblRole";
            this.lblRole.Size = new System.Drawing.Size(40, 16);
            this.lblRole.TabIndex = 0;
            this.lblRole.Text = "Role";
            // 
            // txtRole
            // 
            this.txtRole.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.txtRole.Location = new System.Drawing.Point(165, 100);
            this.txtRole.Name = "txtRole";
            this.txtRole.Size = new System.Drawing.Size(254, 20);
            this.txtRole.TabIndex = 2;
            this.txtRole.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtRole_KeyPress);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(3, 58);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 16);
            this.label2.TabIndex = 0;
            this.label2.Text = "Gender";
            // 
            // cmbGender
            // 
            this.cmbGender.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.cmbGender.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cmbGender.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(165, 55);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(254, 21);
            this.cmbGender.TabIndex = 1;
            // 
            // btnSignup
            // 
            this.btnSignup.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSignup.Location = new System.Drawing.Point(186, 393);
            this.btnSignup.Name = "btnSignup";
            this.btnSignup.Size = new System.Drawing.Size(254, 35);
            this.btnSignup.TabIndex = 6;
            this.btnSignup.Text = "Sign up";
            this.btnSignup.UseVisualStyleBackColor = true;
            this.btnSignup.Click += new System.EventHandler(this.btnSignup_Click);
            // 
            // chkShowPassword
            // 
            this.chkShowPassword.AutoSize = true;
            this.chkShowPassword.Location = new System.Drawing.Point(338, 361);
            this.chkShowPassword.Name = "chkShowPassword";
            this.chkShowPassword.Size = new System.Drawing.Size(102, 17);
            this.chkShowPassword.TabIndex = 7;
            this.chkShowPassword.Text = "Show Password";
            this.chkShowPassword.UseVisualStyleBackColor = true;
            this.chkShowPassword.CheckedChanged += new System.EventHandler(this.chkShowPassword_CheckedChanged);
            // 
            // errEmail
            // 
            this.errEmail.ContainerControl = this;
            // 
            // errPassword
            // 
            this.errPassword.ContainerControl = this;
            // 
            // btnClearFields
            // 
            this.btnClearFields.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClearFields.Location = new System.Drawing.Point(186, 434);
            this.btnClearFields.Name = "btnClearFields";
            this.btnClearFields.Size = new System.Drawing.Size(254, 35);
            this.btnClearFields.TabIndex = 8;
            this.btnClearFields.Text = "Clear Fields";
            this.btnClearFields.UseVisualStyleBackColor = true;
            this.btnClearFields.Click += new System.EventHandler(this.btnClearFields_Click);
            // 
            // llbAlreadyRegistered
            // 
            this.llbAlreadyRegistered.AutoSize = true;
            this.llbAlreadyRegistered.Location = new System.Drawing.Point(183, 482);
            this.llbAlreadyRegistered.Name = "llbAlreadyRegistered";
            this.llbAlreadyRegistered.Size = new System.Drawing.Size(152, 13);
            this.llbAlreadyRegistered.TabIndex = 9;
            this.llbAlreadyRegistered.TabStop = true;
            this.llbAlreadyRegistered.Text = "Already Registered? Click here";
            this.llbAlreadyRegistered.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.llbAlreadyRegistered_LinkClicked);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(515, 532);
            this.Controls.Add(this.llbAlreadyRegistered);
            this.Controls.Add(this.btnClearFields);
            this.Controls.Add(this.chkShowPassword);
            this.Controls.Add(this.btnSignup);
            this.Controls.Add(this.tableLayoutPanel1);
            this.Controls.Add(this.pnltaskBar);
            this.Controls.Add(this.pnlMainheading);
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bislerium Café";
            this.pnlMainheading.ResumeLayout(false);
            this.pnlMainheading.PerformLayout();
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errPassword)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel pnlMainheading;
        private System.Windows.Forms.Panel pnltaskBar;
        private System.Windows.Forms.Label lblMainHeading;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblRole;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.Label lblPhoneNumber;
        private System.Windows.Forms.TextBox txtFullName;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnSignup;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.CheckBox chkShowPassword;
        private System.Windows.Forms.ErrorProvider errEmail;
        private System.Windows.Forms.ErrorProvider errPassword;
        private System.Windows.Forms.Button btnClearFields;
        private System.Windows.Forms.LinkLabel llbAlreadyRegistered;
    }
}

