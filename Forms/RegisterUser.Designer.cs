namespace StudentRegistrationSystem
{
    partial class RegisterUser
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cmbRoles = new System.Windows.Forms.ComboBox();
            this.txtRoleDescription = new System.Windows.Forms.TextBox();
            this.lblRegPassword = new System.Windows.Forms.Label();
            this.lblRegConfPasswrd = new System.Windows.Forms.Label();
            this.lblRegRole = new System.Windows.Forms.Label();
            this.lblRegRoleDescription = new System.Windows.Forms.Label();
            this.lblRegEmail = new System.Windows.Forms.Label();
            this.txtRegisterConfirmPassword = new System.Windows.Forms.TextBox();
            this.txtRegisterPassword = new System.Windows.Forms.TextBox();
            this.textRegisterEmail = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.userIdDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.passwordDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.rolesDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descriptionDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblUsersBindingSource3 = new System.Windows.Forms.BindingSource(this.components);
            this.studentdataDataSet2 = new StudentRegistrationSystem.studentdataDataSet2();
            this.tblUsersBindingSource2 = new System.Windows.Forms.BindingSource(this.components);
            this.studentdataDataSet = new StudentRegistrationSystem.studentdataDataSet();
            this.tblUsersBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.studentdataUsersDataSet = new StudentRegistrationSystem.studentdataUsersDataSet();
            this.btnRegisterUser = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnUpdateUser = new System.Windows.Forms.Button();
            this.tblUsersTableAdapter = new StudentRegistrationSystem.studentdataUsersDataSetTableAdapters.tblUsersTableAdapter();
            this.registeredUsersDataSet = new StudentRegistrationSystem.RegisteredUsersDataSet();
            this.tblUsersBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.tblUsersTableAdapter1 = new StudentRegistrationSystem.RegisteredUsersDataSetTableAdapters.tblUsersTableAdapter();
            this.tblUsersTableAdapter2 = new StudentRegistrationSystem.studentdataDataSetTableAdapters.tblUsersTableAdapter();
            this.tblUsersTableAdapter3 = new StudentRegistrationSystem.studentdataDataSet2TableAdapters.tblUsersTableAdapter();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataDataSet2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredUsersDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cmbRoles);
            this.groupBox1.Controls.Add(this.txtRoleDescription);
            this.groupBox1.Controls.Add(this.lblRegPassword);
            this.groupBox1.Controls.Add(this.lblRegConfPasswrd);
            this.groupBox1.Controls.Add(this.lblRegRole);
            this.groupBox1.Controls.Add(this.lblRegRoleDescription);
            this.groupBox1.Controls.Add(this.lblRegEmail);
            this.groupBox1.Controls.Add(this.txtRegisterConfirmPassword);
            this.groupBox1.Controls.Add(this.txtRegisterPassword);
            this.groupBox1.Controls.Add(this.textRegisterEmail);
            this.groupBox1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(373, 330);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Manage User";
            // 
            // cmbRoles
            // 
            this.cmbRoles.ForeColor = System.Drawing.Color.Gray;
            this.cmbRoles.FormattingEnabled = true;
            this.cmbRoles.Location = new System.Drawing.Point(194, 171);
            this.cmbRoles.Name = "cmbRoles";
            this.cmbRoles.Size = new System.Drawing.Size(156, 23);
            this.cmbRoles.TabIndex = 3;
            // 
            // txtRoleDescription
            // 
            this.txtRoleDescription.Location = new System.Drawing.Point(194, 220);
            this.txtRoleDescription.Multiline = true;
            this.txtRoleDescription.Name = "txtRoleDescription";
            this.txtRoleDescription.Size = new System.Drawing.Size(156, 84);
            this.txtRoleDescription.TabIndex = 9;
            // 
            // lblRegPassword
            // 
            this.lblRegPassword.AutoSize = true;
            this.lblRegPassword.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegPassword.ForeColor = System.Drawing.Color.Gray;
            this.lblRegPassword.Location = new System.Drawing.Point(24, 83);
            this.lblRegPassword.Name = "lblRegPassword";
            this.lblRegPassword.Size = new System.Drawing.Size(87, 18);
            this.lblRegPassword.TabIndex = 8;
            this.lblRegPassword.Text = "Password :";
            // 
            // lblRegConfPasswrd
            // 
            this.lblRegConfPasswrd.AutoSize = true;
            this.lblRegConfPasswrd.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegConfPasswrd.ForeColor = System.Drawing.Color.Gray;
            this.lblRegConfPasswrd.Location = new System.Drawing.Point(24, 129);
            this.lblRegConfPasswrd.Name = "lblRegConfPasswrd";
            this.lblRegConfPasswrd.Size = new System.Drawing.Size(154, 18);
            this.lblRegConfPasswrd.TabIndex = 7;
            this.lblRegConfPasswrd.Text = "Confirm Password :";
            this.lblRegConfPasswrd.Click += new System.EventHandler(this.label3_Click);
            // 
            // lblRegRole
            // 
            this.lblRegRole.AutoSize = true;
            this.lblRegRole.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegRole.ForeColor = System.Drawing.Color.Gray;
            this.lblRegRole.Location = new System.Drawing.Point(24, 171);
            this.lblRegRole.Name = "lblRegRole";
            this.lblRegRole.Size = new System.Drawing.Size(52, 18);
            this.lblRegRole.TabIndex = 6;
            this.lblRegRole.Text = "Role :";
            // 
            // lblRegRoleDescription
            // 
            this.lblRegRoleDescription.AutoSize = true;
            this.lblRegRoleDescription.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegRoleDescription.ForeColor = System.Drawing.Color.Gray;
            this.lblRegRoleDescription.Location = new System.Drawing.Point(24, 222);
            this.lblRegRoleDescription.Name = "lblRegRoleDescription";
            this.lblRegRoleDescription.Size = new System.Drawing.Size(140, 18);
            this.lblRegRoleDescription.TabIndex = 5;
            this.lblRegRoleDescription.Text = "Role description :";
            // 
            // lblRegEmail
            // 
            this.lblRegEmail.AutoSize = true;
            this.lblRegEmail.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRegEmail.ForeColor = System.Drawing.Color.Gray;
            this.lblRegEmail.Location = new System.Drawing.Point(24, 30);
            this.lblRegEmail.Name = "lblRegEmail";
            this.lblRegEmail.Size = new System.Drawing.Size(64, 18);
            this.lblRegEmail.TabIndex = 4;
            this.lblRegEmail.Text = "Email :";
            // 
            // txtRegisterConfirmPassword
            // 
            this.txtRegisterConfirmPassword.Location = new System.Drawing.Point(194, 127);
            this.txtRegisterConfirmPassword.Name = "txtRegisterConfirmPassword";
            this.txtRegisterConfirmPassword.Size = new System.Drawing.Size(156, 21);
            this.txtRegisterConfirmPassword.TabIndex = 2;
            // 
            // txtRegisterPassword
            // 
            this.txtRegisterPassword.Location = new System.Drawing.Point(194, 81);
            this.txtRegisterPassword.Name = "txtRegisterPassword";
            this.txtRegisterPassword.Size = new System.Drawing.Size(156, 21);
            this.txtRegisterPassword.TabIndex = 1;
            // 
            // textRegisterEmail
            // 
            this.textRegisterEmail.Location = new System.Drawing.Point(194, 31);
            this.textRegisterEmail.Name = "textRegisterEmail";
            this.textRegisterEmail.Size = new System.Drawing.Size(156, 21);
            this.textRegisterEmail.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView1);
            this.groupBox2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(401, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(434, 330);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Registered Users";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.userIdDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn,
            this.passwordDataGridViewTextBoxColumn,
            this.rolesDataGridViewTextBoxColumn,
            this.descriptionDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblUsersBindingSource3;
            this.dataGridView1.Location = new System.Drawing.Point(21, 30);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(413, 274);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellEnter += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellEnter);
            // 
            // userIdDataGridViewTextBoxColumn
            // 
            this.userIdDataGridViewTextBoxColumn.DataPropertyName = "UserId";
            this.userIdDataGridViewTextBoxColumn.HeaderText = "UserId";
            this.userIdDataGridViewTextBoxColumn.Name = "userIdDataGridViewTextBoxColumn";
            this.userIdDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            // 
            // passwordDataGridViewTextBoxColumn
            // 
            this.passwordDataGridViewTextBoxColumn.DataPropertyName = "Password";
            this.passwordDataGridViewTextBoxColumn.HeaderText = "Password";
            this.passwordDataGridViewTextBoxColumn.Name = "passwordDataGridViewTextBoxColumn";
            // 
            // rolesDataGridViewTextBoxColumn
            // 
            this.rolesDataGridViewTextBoxColumn.DataPropertyName = "Roles";
            this.rolesDataGridViewTextBoxColumn.HeaderText = "Roles";
            this.rolesDataGridViewTextBoxColumn.Name = "rolesDataGridViewTextBoxColumn";
            // 
            // descriptionDataGridViewTextBoxColumn
            // 
            this.descriptionDataGridViewTextBoxColumn.DataPropertyName = "Description";
            this.descriptionDataGridViewTextBoxColumn.HeaderText = "Description";
            this.descriptionDataGridViewTextBoxColumn.Name = "descriptionDataGridViewTextBoxColumn";
            // 
            // tblUsersBindingSource3
            // 
            this.tblUsersBindingSource3.DataMember = "tblUsers";
            this.tblUsersBindingSource3.DataSource = this.studentdataDataSet2;
            // 
            // studentdataDataSet2
            // 
            this.studentdataDataSet2.DataSetName = "studentdataDataSet2";
            this.studentdataDataSet2.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource2
            // 
            this.tblUsersBindingSource2.DataMember = "tblUsers";
            this.tblUsersBindingSource2.DataSource = this.studentdataDataSet;
            // 
            // studentdataDataSet
            // 
            this.studentdataDataSet.DataSetName = "studentdataDataSet";
            this.studentdataDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource
            // 
            this.tblUsersBindingSource.DataMember = "tblUsers";
            this.tblUsersBindingSource.DataSource = this.studentdataUsersDataSet;
            // 
            // studentdataUsersDataSet
            // 
            this.studentdataUsersDataSet.DataSetName = "studentdataUsersDataSet";
            this.studentdataUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // btnRegisterUser
            // 
            this.btnRegisterUser.Location = new System.Drawing.Point(39, 394);
            this.btnRegisterUser.Name = "btnRegisterUser";
            this.btnRegisterUser.Size = new System.Drawing.Size(75, 23);
            this.btnRegisterUser.TabIndex = 2;
            this.btnRegisterUser.Text = "Create User";
            this.btnRegisterUser.UseVisualStyleBackColor = true;
            this.btnRegisterUser.Click += new System.EventHandler(this.btnRegisterUser_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(291, 394);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 3;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(206, 394);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 4;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnUpdateUser
            // 
            this.btnUpdateUser.Location = new System.Drawing.Point(120, 394);
            this.btnUpdateUser.Name = "btnUpdateUser";
            this.btnUpdateUser.Size = new System.Drawing.Size(75, 23);
            this.btnUpdateUser.TabIndex = 5;
            this.btnUpdateUser.Text = "Update User";
            this.btnUpdateUser.UseVisualStyleBackColor = true;
            this.btnUpdateUser.Click += new System.EventHandler(this.btnUpdateUser_Click);
            // 
            // tblUsersTableAdapter
            // 
            this.tblUsersTableAdapter.ClearBeforeFill = true;
            // 
            // registeredUsersDataSet
            // 
            this.registeredUsersDataSet.DataSetName = "RegisteredUsersDataSet";
            this.registeredUsersDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblUsersBindingSource1
            // 
            this.tblUsersBindingSource1.DataMember = "tblUsers";
            this.tblUsersBindingSource1.DataSource = this.registeredUsersDataSet;
            // 
            // tblUsersTableAdapter1
            // 
            this.tblUsersTableAdapter1.ClearBeforeFill = true;
            // 
            // tblUsersTableAdapter2
            // 
            this.tblUsersTableAdapter2.ClearBeforeFill = true;
            // 
            // tblUsersTableAdapter3
            // 
            this.tblUsersTableAdapter3.ClearBeforeFill = true;
            // 
            // RegisterUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gainsboro;
            this.ClientSize = new System.Drawing.Size(878, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.btnUpdateUser);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnRegisterUser);
            this.Controls.Add(this.groupBox1);
            this.Name = "RegisterUser";
            this.Text = "Admin-Form: Manage Users";
            this.Load += new System.EventHandler(this.RegisterUser_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataDataSet2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.registeredUsersDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblUsersBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblRegPassword;
        private System.Windows.Forms.Label lblRegConfPasswrd;
        private System.Windows.Forms.Label lblRegRole;
        private System.Windows.Forms.Label lblRegRoleDescription;
        private System.Windows.Forms.Label lblRegEmail;
        private System.Windows.Forms.TextBox txtRegisterConfirmPassword;
        private System.Windows.Forms.TextBox txtRegisterPassword;
        private System.Windows.Forms.TextBox textRegisterEmail;
        private System.Windows.Forms.TextBox txtRoleDescription;
        private System.Windows.Forms.Button btnRegisterUser;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnUpdateUser;
        private studentdataUsersDataSet studentdataUsersDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource;
        private studentdataUsersDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter;
        private RegisteredUsersDataSet registeredUsersDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource1;
        private RegisteredUsersDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter1;
        private studentdataDataSet studentdataDataSet;
        private System.Windows.Forms.BindingSource tblUsersBindingSource2;
        private studentdataDataSetTableAdapters.tblUsersTableAdapter tblUsersTableAdapter2;
        private System.Windows.Forms.DataGridViewTextBoxColumn userIdDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn passwordDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn rolesDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descriptionDataGridViewTextBoxColumn;
        private studentdataDataSet2 studentdataDataSet2;
        private System.Windows.Forms.BindingSource tblUsersBindingSource3;
        private studentdataDataSet2TableAdapters.tblUsersTableAdapter tblUsersTableAdapter3;
        public System.Windows.Forms.ComboBox cmbRoles;
        public System.Windows.Forms.DataGridView dataGridView1;
    }
}