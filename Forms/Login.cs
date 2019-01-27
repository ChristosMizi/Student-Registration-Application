using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using System.Data.SqlClient;

namespace StudentRegistrationSystem
{
    public partial class Login : MaterialSkin.Controls.MaterialForm
    {
        private Form1 f1;
        public static String strEmail;
        public static String cmbRolesvar;
        private Users objUser2;
        public Login()
        {
            InitializeComponent();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
        // Load Form
        private void Login_Load(object sender, EventArgs e)
        {
            GetRoles();
        }

        // Method Get Roles
        private void GetRoles()
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("spSelectDistictRoles", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

           

            try
            {
                objSqlConenction.Open();
                //Now we are reading from our database so we have to use our datareader object

                SqlDataReader objDataReader = objSqlCommand.ExecuteReader();

                //While Data Reader can read, I add Items to the combo box
                while (objDataReader.Read())
                {
                    cmbRoles.Items.Add(objDataReader[0]);
                }
                objDataReader.Close();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message);
                return;

            }
            finally
            {
                objSqlConenction.Close();
               // MessageBox.Show("New User has been Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

        }

        // button sign in
        private void btn_SignIn_Click(object sender, EventArgs e)
        {
            objUser2 = new Users();
            AssignUserDataToControls(); // assign sto email property tou class user

            try
            {
                if (objUser2.AuthorisedUser())
                {
                     f1 = new Form1();

                    f1.Show();
                    this.Hide();


                    if (cmbRoles.Text == "Super Admin")
                    {
                        f1.btn_admin_registration.Enabled = true;
                    }
                    else
                    {
                        f1.btn_admin_registration.Enabled = false;
                        f1.btn_admin_registration.Visible = false;

                    }

                }
                else
                {
                    MessageBox.Show("Unauthorized Credentials Provided!", "Unauthorised User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }
            

        }
        //Assign my properties to my cmb comntrol, txt Email txt Password
        private void AssignUserDataToControls()
        {
            objUser2.Email = txtLogInEmail.Text;
            objUser2.Password = txtPassword.Text;
            objUser2.Role = cmbRoles.Text;
            strEmail = txtLogInEmail.Text;
            cmbRolesvar = cmbRoles.Text;
        }


        //Exit button
        private void btnExitApp_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
