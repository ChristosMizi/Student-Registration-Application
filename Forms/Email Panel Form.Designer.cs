namespace StudentRegistrationSystem
{
    partial class Email_Panel_Form
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.chkBxUnRead = new System.Windows.Forms.CheckBox();
            this.chkBxRead = new System.Windows.Forms.CheckBox();
            this.button4 = new System.Windows.Forms.Button();
            this.cmbMSDOS = new System.Windows.Forms.ComboBox();
            this.button3 = new System.Windows.Forms.Button();
            this.cmbSenders = new System.Windows.Forms.ComboBox();
            this.cmbReceivers = new System.Windows.Forms.ComboBox();
            this.Inbox = new System.Windows.Forms.RichTextBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_Send_Email = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.Controls.Add(this.button4);
            this.groupBox1.Controls.Add(this.cmbMSDOS);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.cmbSenders);
            this.groupBox1.Controls.Add(this.cmbReceivers);
            this.groupBox1.Controls.Add(this.Inbox);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.btn_Send_Email);
            this.groupBox1.Location = new System.Drawing.Point(30, 62);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(758, 320);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Email Operations";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.chkBxUnRead);
            this.groupBox2.Controls.Add(this.chkBxRead);
            this.groupBox2.Location = new System.Drawing.Point(249, 77);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(146, 100);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Status";
            // 
            // chkBxUnRead
            // 
            this.chkBxUnRead.AutoSize = true;
            this.chkBxUnRead.Location = new System.Drawing.Point(17, 54);
            this.chkBxUnRead.Name = "chkBxUnRead";
            this.chkBxUnRead.Size = new System.Drawing.Size(61, 17);
            this.chkBxUnRead.TabIndex = 2;
            this.chkBxUnRead.Text = "Unread";
            this.chkBxUnRead.UseVisualStyleBackColor = true;
            this.chkBxUnRead.Click += new System.EventHandler(this.EventUnread);
            // 
            // chkBxRead
            // 
            this.chkBxRead.AutoSize = true;
            this.chkBxRead.Location = new System.Drawing.Point(17, 20);
            this.chkBxRead.Name = "chkBxRead";
            this.chkBxRead.Size = new System.Drawing.Size(52, 17);
            this.chkBxRead.TabIndex = 1;
            this.chkBxRead.Text = "Read";
            this.chkBxRead.UseVisualStyleBackColor = true;
            this.chkBxRead.Click += new System.EventHandler(this.EventRead);
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.Color.Olive;
            this.button4.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button4.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button4.Location = new System.Drawing.Point(158, 238);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(115, 23);
            this.button4.TabIndex = 9;
            this.button4.Text = "Get Dates";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // cmbMSDOS
            // 
            this.cmbMSDOS.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.cmbMSDOS.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbMSDOS.ForeColor = System.Drawing.Color.Snow;
            this.cmbMSDOS.FormattingEnabled = true;
            this.cmbMSDOS.Location = new System.Drawing.Point(279, 239);
            this.cmbMSDOS.Name = "cmbMSDOS";
            this.cmbMSDOS.Size = new System.Drawing.Size(135, 23);
            this.cmbMSDOS.TabIndex = 8;
            this.cmbMSDOS.Text = "Select Date:";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button3.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button3.Location = new System.Drawing.Point(20, 196);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(115, 53);
            this.button3.TabIndex = 7;
            this.button3.Text = "View Other USers Data";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.ViewOtherIsersData);
            // 
            // cmbSenders
            // 
            this.cmbSenders.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.cmbSenders.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSenders.ForeColor = System.Drawing.Color.Snow;
            this.cmbSenders.FormattingEnabled = true;
            this.cmbSenders.Location = new System.Drawing.Point(161, 210);
            this.cmbSenders.Name = "cmbSenders";
            this.cmbSenders.Size = new System.Drawing.Size(112, 23);
            this.cmbSenders.TabIndex = 6;
            this.cmbSenders.Text = "Select Sender:";
            // 
            // cmbReceivers
            // 
            this.cmbReceivers.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.cmbReceivers.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbReceivers.ForeColor = System.Drawing.Color.Snow;
            this.cmbReceivers.FormattingEnabled = true;
            this.cmbReceivers.Location = new System.Drawing.Point(279, 210);
            this.cmbReceivers.Name = "cmbReceivers";
            this.cmbReceivers.Size = new System.Drawing.Size(135, 23);
            this.cmbReceivers.TabIndex = 5;
            this.cmbReceivers.Text = "Select Receiver:";
            // 
            // Inbox
            // 
            this.Inbox.Location = new System.Drawing.Point(441, 29);
            this.Inbox.Name = "Inbox";
            this.Inbox.Size = new System.Drawing.Size(297, 204);
            this.Inbox.TabIndex = 4;
            this.Inbox.Text = "";
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.Silver;
            this.comboBox1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.ForeColor = System.Drawing.SystemColors.WindowText;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(256, 29);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(158, 23);
            this.comboBox1.TabIndex = 3;
            this.comboBox1.Text = "Select Date:";
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button2.Location = new System.Drawing.Point(20, 19);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(115, 37);
            this.button2.TabIndex = 2;
            this.button2.Text = "Check Inbox";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.btn_inbox);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.button1.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.button1.Location = new System.Drawing.Point(20, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(115, 37);
            this.button1.TabIndex = 1;
            this.button1.Text = "View Sent";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.btn_View_Sent);
            // 
            // btn_Send_Email
            // 
            this.btn_Send_Email.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(22)))), ((int)(((byte)(160)))), ((int)(((byte)(133)))));
            this.btn_Send_Email.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Send_Email.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.btn_Send_Email.Location = new System.Drawing.Point(20, 131);
            this.btn_Send_Email.Name = "btn_Send_Email";
            this.btn_Send_Email.Size = new System.Drawing.Size(115, 37);
            this.btn_Send_Email.TabIndex = 0;
            this.btn_Send_Email.Text = "Send Email";
            this.btn_Send_Email.UseVisualStyleBackColor = false;
            this.btn_Send_Email.Click += new System.EventHandler(this.btn_Send_Email_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Peru;
            this.label1.Location = new System.Drawing.Point(27, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(0, 18);
            this.label1.TabIndex = 1;
            // 
            // Email_Panel_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.WhiteSmoke;
            this.ClientSize = new System.Drawing.Size(800, 419);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.Name = "Email_Panel_Form";
            this.Text = "Email Panel ";
            this.Load += new System.EventHandler(this.Email_Panel_Form_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btn_Send_Email;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.RichTextBox Inbox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSenders;
        private System.Windows.Forms.ComboBox cmbReceivers;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox cmbMSDOS;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.CheckBox chkBxUnRead;
        private System.Windows.Forms.CheckBox chkBxRead;
    }
}