using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class RegisterUser : Form
    {
       
        
        //Class Variable
        private Users objUsers;
        public RegisterUser()
        {
            InitializeComponent();
        }

        //Combobox fill with Roles
        private void FillComboboxWithNamesRoles()
        {
            objUsers = new Users();
            string[] RolesNames = objUsers.GetArrayNamesFromEnum();
            foreach (string str in RolesNames)
            {
                cmbRoles.Items.Add(str);
            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }//Method Clear controls

        private void ClearControls()
        {
            
            textRegisterEmail.Text = "";
            txtRegisterPassword.Text = "";
            cmbRoles.Text = "Select Role :";
            txtRoleDescription.Clear();
            txtRegisterConfirmPassword.Clear();

            
        }

        //Link my user Interface to my Properties
        private void Userdata()
        {
            objUsers.Email= textRegisterEmail.Text;
            objUsers.Password = txtRegisterPassword.Text;
            objUsers.Role = cmbRoles.Text;
            objUsers.Description = txtRoleDescription.Text;
            
        }
        //Create User
        private void btnRegisterUser_Click(object sender, EventArgs e)
        {
            objUsers = new Users();
            Userdata(); // assign sto email property tou class user

            try
            {
                if (objUsers.AuthorisedUser())
                {
                    MessageBox.Show("User already Exists!");
                    
                }
                else if(textRegisterEmail.Text == "" || txtRegisterPassword.Text == "" || txtRegisterConfirmPassword.Text == "" || cmbRoles.Text == "Select Role :" || txtRoleDescription.Text == "")
                {
                    MessageBox.Show("Fill all fields");
                }
                else
                {
                    //objUsers = new Users();
                    //Userdata();
                    objUsers.AddUSer();
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

            


            // TODO: This line of code loads data into the 'studentdataDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter3.Fill(this.studentdataDataSet2.tblUsers);
            ClearControls();

        }


        //Admin Panel Forl Load
        private void RegisterUser_Load(object sender, EventArgs e)
        {
            FillComboboxWithNamesRoles();
            // TODO: This line of code loads data into the 'studentdataDataSet2.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter3.Fill(this.studentdataDataSet2.tblUsers);
            // TODO: This line of code loads data into the 'studentdataDataSet.tblUsers' table. You can move, or remove it, as needed.
            //this.tblUsersTableAdapter2.Fill(this.studentdataDataSet.tblUsers);


        }


        //Datagridview pass values From Cells to Form Controls
        private void dataGridView1_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewCellCollection cells = dataGridView1.CurrentRow.Cells;
            textRegisterEmail.Text = cells[1].Value.ToString();
            txtRegisterPassword.Text = cells[2].Value.ToString();
            txtRegisterConfirmPassword.Text = cells[2].Value.ToString();
            cmbRoles.Text = cells[3].Value.ToString();
            txtRoleDescription.Text = cells[4].Value.ToString();
        }


        //Button update
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (textRegisterEmail.Text == "" || txtRegisterPassword.Text == "" || txtRegisterConfirmPassword.Text == "" || cmbRoles.Text == "Select Role :" || txtRoleDescription.Text == "")
            {
                MessageBox.Show("Fields are empty!");
            }
            else
            {
                Userdata();
                objUsers.UpdateUser();

            }
                    
                  
                
                


           

            // TODO: This line of code loads data into the 'studentdataDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter3.Fill(this.studentdataDataSet2.tblUsers);

            ClearControls();
        }


        //button Reset
        private void btnReset_Click(object sender, EventArgs e)
        { 
            ClearControls();
        }


        //button delete
        private void btnDelete_Click(object sender, EventArgs e)
        {

            if (textRegisterEmail.Text == "" || txtRegisterPassword.Text == "" || txtRegisterConfirmPassword.Text == "" || cmbRoles.Text == "Select Role :" || txtRoleDescription.Text == "")
            {
                MessageBox.Show("Please Fill all fields");
                
            }
            else
            {
                DialogResult objDialogue = MessageBox.Show("Are you sure you want to delete this user's record?", "Confirm Record Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (objDialogue == DialogResult.Yes)
                {
                    objUsers = new Users();
                    Userdata();
                    objUsers.DeleteUser();
                }
            }
            


            // TODO: This line of code loads data into the 'studentdataDataSet.tblUsers' table. You can move, or remove it, as needed.
            this.tblUsersTableAdapter3.Fill(this.studentdataDataSet2.tblUsers);

            ClearControls();
        }
    }
}
