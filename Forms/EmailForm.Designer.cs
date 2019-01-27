namespace StudentRegistrationSystem
{
    partial class EmailForm
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
            this.lblSender = new System.Windows.Forms.Label();
            this.txtEmailFormSender = new System.Windows.Forms.TextBox();
            this.lblReceiver = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblDOS = new System.Windows.Forms.Label();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.cmbEmailFormReceiver = new System.Windows.Forms.ComboBox();
            this.btnSendEmail = new System.Windows.Forms.Button();
            this.studentdataDataSet1 = new StudentRegistrationSystem.studentdataDataSet1();
            this.tblEmailMessageBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tblEmailMessageTableAdapter = new StudentRegistrationSystem.studentdataDataSet1TableAdapters.tblEmailMessageTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.studentdataDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmailMessageBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblSender
            // 
            this.lblSender.AutoSize = true;
            this.lblSender.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSender.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblSender.Location = new System.Drawing.Point(25, 29);
            this.lblSender.Name = "lblSender";
            this.lblSender.Size = new System.Drawing.Size(68, 18);
            this.lblSender.TabIndex = 0;
            this.lblSender.Text = "Sender :";
            // 
            // txtEmailFormSender
            // 
            this.txtEmailFormSender.Location = new System.Drawing.Point(222, 30);
            this.txtEmailFormSender.Name = "txtEmailFormSender";
            this.txtEmailFormSender.ReadOnly = true;
            this.txtEmailFormSender.Size = new System.Drawing.Size(164, 20);
            this.txtEmailFormSender.TabIndex = 1;
            // 
            // lblReceiver
            // 
            this.lblReceiver.AutoSize = true;
            this.lblReceiver.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReceiver.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblReceiver.Location = new System.Drawing.Point(25, 62);
            this.lblReceiver.Name = "lblReceiver";
            this.lblReceiver.Size = new System.Drawing.Size(80, 18);
            this.lblReceiver.TabIndex = 0;
            this.lblReceiver.Text = "Receiver :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(25, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 18);
            this.label2.TabIndex = 0;
            this.label2.Text = "Message :";
            // 
            // lblDOS
            // 
            this.lblDOS.AutoSize = true;
            this.lblDOS.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDOS.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.lblDOS.Location = new System.Drawing.Point(25, 94);
            this.lblDOS.Name = "lblDOS";
            this.lblDOS.Size = new System.Drawing.Size(167, 18);
            this.lblDOS.TabIndex = 0;
            this.lblDOS.Text = "Date Of Submission :";
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CustomFormat = "dd/MM/yyyy hh:mm:ss";
            this.dateTimePicker1.Location = new System.Drawing.Point(222, 92);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(164, 20);
            this.dateTimePicker1.TabIndex = 3;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(222, 141);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(460, 204);
            this.richTextBox1.TabIndex = 4;
            this.richTextBox1.Text = "";
            // 
            // cmbEmailFormReceiver
            // 
            this.cmbEmailFormReceiver.FormattingEnabled = true;
            this.cmbEmailFormReceiver.Location = new System.Drawing.Point(222, 62);
            this.cmbEmailFormReceiver.Name = "cmbEmailFormReceiver";
            this.cmbEmailFormReceiver.Size = new System.Drawing.Size(164, 21);
            this.cmbEmailFormReceiver.TabIndex = 2;
            // 
            // btnSendEmail
            // 
            this.btnSendEmail.Location = new System.Drawing.Point(146, 322);
            this.btnSendEmail.Name = "btnSendEmail";
            this.btnSendEmail.Size = new System.Drawing.Size(61, 23);
            this.btnSendEmail.TabIndex = 5;
            this.btnSendEmail.Text = "Send";
            this.btnSendEmail.UseVisualStyleBackColor = true;
            this.btnSendEmail.Click += new System.EventHandler(this.btnSendEmail_Click);
            // 
            // studentdataDataSet1
            // 
            this.studentdataDataSet1.DataSetName = "studentdataDataSet1";
            this.studentdataDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tblEmailMessageBindingSource
            // 
            this.tblEmailMessageBindingSource.DataMember = "tblEmailMessage";
            this.tblEmailMessageBindingSource.DataSource = this.studentdataDataSet1;
            // 
            // tblEmailMessageTableAdapter
            // 
            this.tblEmailMessageTableAdapter.ClearBeforeFill = true;
            // 
            // EmailForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Peru;
            this.ClientSize = new System.Drawing.Size(710, 365);
            this.Controls.Add(this.btnSendEmail);
            this.Controls.Add(this.cmbEmailFormReceiver);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.lblDOS);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblReceiver);
            this.Controls.Add(this.txtEmailFormSender);
            this.Controls.Add(this.lblSender);
            this.Name = "EmailForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Send Email Form";
            this.Load += new System.EventHandler(this.EmailForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.studentdataDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblEmailMessageBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblSender;
        private System.Windows.Forms.Label lblReceiver;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblDOS;
        public System.Windows.Forms.TextBox txtEmailFormSender;
        public System.Windows.Forms.DateTimePicker dateTimePicker1;
        public System.Windows.Forms.RichTextBox richTextBox1;
        public System.Windows.Forms.ComboBox cmbEmailFormReceiver;
        private System.Windows.Forms.Button btnSendEmail;
        private studentdataDataSet1 studentdataDataSet1;
        private System.Windows.Forms.BindingSource tblEmailMessageBindingSource;
        private studentdataDataSet1TableAdapters.tblEmailMessageTableAdapter tblEmailMessageTableAdapter;
    }
}