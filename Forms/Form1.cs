using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class Form1 : MaterialSkin.Controls.MaterialForm
    {
        private Email_Panel_Form empf;
        private Users objUsers;
         private int countInbox = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void btn_st_registration_Click(object sender, EventArgs e)
        {
            if (Login.cmbRolesvar == "Student" || Login.cmbRolesvar == "Super Admin")
            {
                st_registration_form obj = new st_registration_form();
                obj.Show();
            }
            else
            {
                MessageBox.Show("You have no Permissions");
            }

        }

        private void btn_log_out_Click(object sender, EventArgs e)
        {
            Login lg = new Login();
            lg.Show();
            this.Close();
        }

        private void btn_admin_registration_Click(object sender, EventArgs e)
        {
            RegisterUser rg = new RegisterUser();
            rg.Show();
        }

        private void btn_teach_registration_Click(object sender, EventArgs e)
        {
            if (Login.cmbRolesvar == "Student" || Login.cmbRolesvar == "Teacher" || Login.cmbRolesvar == "Professor" || Login.cmbRolesvar == "Super Admin")
            {
                Email_Panel_Form emp = new Email_Panel_Form();
                emp.Show();
                label1.Visible = false;
                label2.Visible = false;
            }
            else
            {
                MessageBox.Show("Please Beat it!");
            }

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

       
           

        private void Form1_Load(object sender, EventArgs e)
        {
            objUsers = new Users();
            

            objUsers.FindCount();
            int AllRowsInbox = Users.ValueInsertedColumnCountInboxBeforeUserSendsEmail;
            if (AllRowsInbox > Users.ValueOfInbox1)
            {
                label1.Visible = true;
                label2.Visible = true;


            }
            else
            {
                label1.Visible = false;
                label2.Visible = false;

            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
