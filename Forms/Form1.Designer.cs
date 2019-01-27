namespace StudentRegistrationSystem
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_log_out = new System.Windows.Forms.Button();
            this.btn_admin_registration = new System.Windows.Forms.Button();
            this.btn_teach_registration = new System.Windows.Forms.Button();
            this.btn_st_registration = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.BurlyWood;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.btn_log_out);
            this.panel1.Controls.Add(this.btn_admin_registration);
            this.panel1.Controls.Add(this.btn_teach_registration);
            this.panel1.Controls.Add(this.btn_st_registration);
            this.panel1.Location = new System.Drawing.Point(2, 63);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1262, 48);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MediumBlue;
            this.label2.Location = new System.Drawing.Point(416, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "UnRead Email!";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(396, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(13, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "!!";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn_log_out
            // 
            this.btn_log_out.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_log_out.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_log_out.ForeColor = System.Drawing.Color.White;
            this.btn_log_out.Image = ((System.Drawing.Image)(resources.GetObject("btn_log_out.Image")));
            this.btn_log_out.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_log_out.Location = new System.Drawing.Point(1062, 11);
            this.btn_log_out.Name = "btn_log_out";
            this.btn_log_out.Size = new System.Drawing.Size(116, 29);
            this.btn_log_out.TabIndex = 5;
            this.btn_log_out.Text = "Log Out";
            this.btn_log_out.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_log_out.UseVisualStyleBackColor = true;
            this.btn_log_out.Click += new System.EventHandler(this.btn_log_out_Click);
            // 
            // btn_admin_registration
            // 
            this.btn_admin_registration.FlatAppearance.BorderSize = 0;
            this.btn_admin_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_admin_registration.Font = new System.Drawing.Font("Modern No. 20", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_admin_registration.ForeColor = System.Drawing.Color.White;
            this.btn_admin_registration.Image = ((System.Drawing.Image)(resources.GetObject("btn_admin_registration.Image")));
            this.btn_admin_registration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_admin_registration.Location = new System.Drawing.Point(888, 6);
            this.btn_admin_registration.Name = "btn_admin_registration";
            this.btn_admin_registration.Size = new System.Drawing.Size(139, 34);
            this.btn_admin_registration.TabIndex = 4;
            this.btn_admin_registration.Text = "Admin Panel";
            this.btn_admin_registration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_admin_registration.UseVisualStyleBackColor = true;
            this.btn_admin_registration.Click += new System.EventHandler(this.btn_admin_registration_Click);
            // 
            // btn_teach_registration
            // 
            this.btn_teach_registration.FlatAppearance.BorderSize = 0;
            this.btn_teach_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_teach_registration.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_teach_registration.ForeColor = System.Drawing.Color.White;
            this.btn_teach_registration.Image = ((System.Drawing.Image)(resources.GetObject("btn_teach_registration.Image")));
            this.btn_teach_registration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_teach_registration.Location = new System.Drawing.Point(237, 3);
            this.btn_teach_registration.Name = "btn_teach_registration";
            this.btn_teach_registration.Size = new System.Drawing.Size(153, 40);
            this.btn_teach_registration.TabIndex = 1;
            this.btn_teach_registration.Text = "Emai Panel";
            this.btn_teach_registration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_teach_registration.UseVisualStyleBackColor = true;
            this.btn_teach_registration.Click += new System.EventHandler(this.btn_teach_registration_Click);
            // 
            // btn_st_registration
            // 
            this.btn_st_registration.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btn_st_registration.FlatAppearance.BorderSize = 0;
            this.btn_st_registration.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_st_registration.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.btn_st_registration.ForeColor = System.Drawing.Color.White;
            this.btn_st_registration.Image = ((System.Drawing.Image)(resources.GetObject("btn_st_registration.Image")));
            this.btn_st_registration.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_st_registration.Location = new System.Drawing.Point(10, 3);
            this.btn_st_registration.Name = "btn_st_registration";
            this.btn_st_registration.Size = new System.Drawing.Size(221, 40);
            this.btn_st_registration.TabIndex = 0;
            this.btn_st_registration.Text = "Student Registration";
            this.btn_st_registration.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btn_st_registration.UseVisualStyleBackColor = true;
            this.btn_st_registration.Click += new System.EventHandler(this.btn_st_registration_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(2, 109);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(1262, 508);
            this.pictureBox1.TabIndex = 1;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1264, 602);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Application Management StudentData";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btn_st_registration;
        private System.Windows.Forms.Button btn_teach_registration;
        private System.Windows.Forms.Button btn_log_out;
        private System.Windows.Forms.PictureBox pictureBox1;
        public System.Windows.Forms.Button btn_admin_registration;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}

