using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Configuration;

namespace StudentRegistrationSystem
{
    public partial class st_registration_form : MaterialSkin.Controls.MaterialForm
    {
        string gender;
        private Users objUsers;
        SqlDataAdapter adpt;
        DataTable dt;
        Connection con = new Connection();

        
        public st_registration_form()
        {
            InitializeComponent();
            ShowDataCountry();
            ShowDataCity();
            ShowDataProvince();
            ShowDataClass();
            ShowToComboBoxClassNames();
            btn_st_update.Enabled = false;
            btn_st_delete.Enabled = false;
        }


        public void ShowDataCountry()
        {
            try
            {
                adpt = new SqlDataAdapter("select * from country", con.opencon());
                dt = new DataTable();
                adpt.Fill(dt);

                cmb_country.DataSource = dt;
                cmb_country.DisplayMember = "CountryName";
                cmb_country.ValueMember = "country_id";

            }
            catch (Exception)
            {

               
            }
            finally
            {
                con.conclose();
            }
          
        }
        public void ShowDataCity()
        {
            try
            {
                adpt = new SqlDataAdapter("select * from tblcity", con.opencon());
                dt = new DataTable();
                adpt.Fill(dt);
                
                cmb_city.DataSource = dt;
                cmb_city.DisplayMember = "CityName";
                cmb_city.ValueMember = "Id";


            }
            catch (Exception)
            {


            }
            finally
            {
                con.conclose();
            }

        }
        public void ShowDataProvince()
        {
            try
            {
                adpt = new SqlDataAdapter("select * from tblprovince", con.opencon());
                dt = new DataTable();
                adpt.Fill(dt);

                cmb_province.DataSource = dt;
                cmb_province.DisplayMember = "ProvinceName";
                cmb_province.ValueMember = "Id";


            }
            catch (Exception)
            {

               
            }
            finally
            {
                con.conclose();
            }
          
        }

        public void ShowDataClass()
        {
            try
            {
                adpt = new SqlDataAdapter("select * from tblClass", con.opencon());
                dt = new DataTable();
                adpt.Fill(dt);

                cmb_st_class.DataSource = dt;
                cmb_st_class.DisplayMember = "ClassName";
                cmb_st_class.ValueMember = "Id";


            }
            catch (Exception)
            {


            }
            finally
            {
                con.conclose();
            }

        }


        private void cmb_country_SelectedIndexChanged(object sender, EventArgs e)
        {

            try
            {
                int count = Convert.ToInt32(cmb_country.SelectedValue.ToString());
                adpt = new SqlDataAdapter("select * from tblcity where Country_id ='" + count + "'", con.opencon());

                dt = new DataTable();

                adpt.Fill(dt);
                cmb_city.DataSource = dt;
                cmb_city.DisplayMember = "CityName";
                cmb_city.ValueMember = "Id";
            }
            catch (Exception)
            {
              

            }
            finally
            {
                con.conclose();
            }

        }

        private void cmb_province_SelectedIndexChanged(object sender, EventArgs e)
        {
            
        }

        private void cmb_city_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int city = Convert.ToInt32(cmb_city.SelectedValue.ToString());
                adpt = new SqlDataAdapter("select * from tblprovince where City_id ='" + city + "'", con.opencon());

                dt = new DataTable();

                adpt.Fill(dt);
                cmb_province.DataSource = dt;
                cmb_province.DisplayMember = "ProvinceName";
                cmb_province.ValueMember = "Id";
            }
            catch (Exception)
            {


            }
            finally
            {
                con.conclose();
            }
        }

        public void ShowToComboBoxClassNames()
        {
            try
            {
               
                adpt = new SqlDataAdapter("select * from tblClass ", con.opencon());

                dt = new DataTable();

                adpt.Fill(dt);
                cmb_st_class.DataSource = dt;
                cmb_st_class.DisplayMember = "ClassName";
                cmb_st_class.ValueMember = "Id";
            }
            catch (Exception)
            {


            }
            finally
            {
                con.conclose();
            }
        }

        private bool isDataValid()
        {

            // First Name Validation
            if (string.IsNullOrEmpty(txt_st_name.Text))
            {
                MessageBox.Show("Please, Enter first Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_st_name.Focus();
                txt_st_name.BackColor = Color.Silver;
                return false;
            }
           
            else
            {
                txt_st_name.BackColor = Color.White;
            }

            //Last Name Validation
            if (txt_st_lname.Text == "")
            {
                MessageBox.Show("Please Enter Last Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_st_lname.Focus();
                txt_st_lname.BackColor = Color.Silver;
                return false;
            }
           
            else
            {
                txt_st_lname.BackColor = Color.White;
            }

            // Father Name Validation
            if (string.IsNullOrEmpty(txt_st_fname.Text))
            {
                MessageBox.Show("Please, Enter Father Name", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_st_fname.Focus();
                txt_st_fname.BackColor = Color.Silver;
                return false;
            }

            else
            {
                txt_st_fname.BackColor = Color.White;
            }

            // Father Name Id
            if (string.IsNullOrEmpty(txt_st_father_id.Text))
            {
                MessageBox.Show("Please, Enter Father Id", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_st_father_id.Focus();
                txt_st_father_id.BackColor = Color.Silver;
                return false;
            }

            else
            {
                txt_st_father_id.BackColor = Color.White;
            }

            // Email Address Validation
            if (txt_st_email.Text == "")
            {
                MessageBox.Show("Please Enter Email Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_st_email.Focus();
                txt_st_email.BackColor = Color.Silver;
                return false;
            }

            else
            {
                txt_st_email.BackColor = Color.White;
            }

            //Mobile Number Validation
            if (txt_st_mobile.Text.Length == 0)
            {
                MessageBox.Show("Please Enter Mobile Number", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_st_mobile.Focus();
                txt_st_mobile.BackColor = Color.Silver;
                return false;
            }
            else
            {
                txt_st_mobile.BackColor = Color.White;
            }

            
            //Class Validation
            if (cmb_st_class.SelectedIndex == 0 || cmb_st_class.SelectedIndex == -1)
            {
                MessageBox.Show("Please Select a Class from the list", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_st_class.Focus();
                cmb_st_class.BackColor = Color.Silver;

                return false;
            }
            else
            {
                cmb_st_class.BackColor = Color.White;
            }

            // Address Validation
            if (txt_st_address.Text == "")
            {
                MessageBox.Show("Please Enter Address", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                txt_st_address.Focus();
                txt_st_address.BackColor = Color.Silver;

                return false;
            }
            else
            {
                txt_st_address.BackColor = Color.White;
            }

            // Gender Validation
            if (rbtn_male.Checked == false && rbtn_female.Checked == false)
            {
                MessageBox.Show("Please check either Male or Female", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                grbGender.Focus();
                rbtn_male.BackColor = Color.Silver;
                rbtn_female.BackColor = Color.Silver;
                return false;
            }
            else
            {
                rbtn_male.BackColor = Color.CornflowerBlue;
                rbtn_female.BackColor = Color.CornflowerBlue;
            }

            //Country Validation
            int countryid = Convert.ToInt32(cmb_country.SelectedValue);
            if (countryid == 0 || countryid == -1) //cmb_country.SelectedIndex 
            {
                MessageBox.Show("Please Select a Country from the list", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_country.Focus();
                cmb_country.BackColor = Color.Silver;

                return false;
            }
            else if (cmb_country.Text =="")
            {
                return false;
            }
            else
            {
                cmb_country.BackColor = Color.White;
            }
            //City Validation
            int cityid = Convert.ToInt32(cmb_city.SelectedValue);
            //if (cityid == 0 || cityid == -1)
            //{
            //    MessageBox.Show("Please Select a City from the list", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    cmb_city.Focus();
            //    cmb_city.BackColor = Color.Silver;

            //    return false;
            //}
            if (cmb_city.Text == "")
            {
                MessageBox.Show("Please Select a City from the list", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_city.Focus();
                cmb_city.BackColor = Color.Silver;
                return false;
            }
            else
            {
                cmb_city.BackColor = Color.White;
            }
            //Province Validation
            int provid = Convert.ToInt32(cmb_province.SelectedValue);
            //if (provid == 0 || provid== -1)
            //{
            //    MessageBox.Show("Please Select a Province from the list", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            //    cmb_province.Focus();
            //    cmb_province.BackColor = Color.Silver;

            //    return false;
            //}
             if (cmb_province.Text == "")
            {
                MessageBox.Show("Please Select a Province from the list", "Data Entry Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                cmb_province.Focus();
                cmb_province.BackColor = Color.Silver;
                return false;
            }

            else
            {
                cmb_province.BackColor = Color.White;
            }
            return true;
        }
        // Checked Controls Method
        private void CheckedItems()
        {
            // Checked Gender

            if (rbtn_male.Checked)
            {
                gender = "Male";
            }
            else
            {
                gender = "Female";
            }
        }

        private void ResetControlls()
        {
            txt_st_name.Text = "";
            txt_st_lname.Text = "";
            txt_st_fname.Text = "";
            txt_st_father_id.Text = "";
            txt_st_email.Text = "";
            txt_st_mobile.Clear();
            date_of_birth.Value = new DateTime(1980, 12, 30);
            date_of_registration.Value = new DateTime(1980, 12, 30);
            cmb_st_class.SelectedIndex = 0;
            txt_st_address.Clear();
            rbtn_male.Checked = false;
            rbtn_female.Checked = false;
            cmb_country.SelectedIndex = 0;
            cmb_province.SelectedIndex = 0;
            cmb_city.SelectedIndex = 0;

        }

       
        private void AssignValuesFromControlsToClassProperties()
        {
            objUsers = new Users();
            objUsers.Email= Login.strEmail;

            try
            {
                if (objUsers.CheckIfEmailExists() == false)
                {
                    btn_st_save.Enabled = true;
                }
                else
                {
                    btn_st_save.Enabled = false;
                    //MessageBox.Show("You have already Registered as Student", "Unauthorised User", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show("Error: " + ex.Message);
            }

        }
        private void btn_st_save_Click(object sender, EventArgs e)
        {
            if (isDataValid())
            {
                CheckedItems();


                int countryId = Convert.ToInt32(cmb_country.SelectedValue);
                int provinceId = Convert.ToInt32(cmb_province.SelectedValue);
                int cityId = Convert.ToInt32(cmb_city.SelectedValue);
                int classId = Convert.ToInt32(cmb_st_class.SelectedValue);
                //con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=studentdata; Integrated Security=True");
                string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
                SqlConnection objSqlConnection = new SqlConnection(cs);

                string insertCommand = "INSERT INTO dbo.tblStudentInfo" +
                        "(FNanme,LName,FatherName,FatherId,Mobile,Email,DOBirth,DORegistration,Class_Id,Adress,gender,Country_Id,Prov_Id,City_Id)" +
                        "VALUES(@FNanme,@LName,@FatherName,@FatherId,@Email,@Mobile,@DOBirth,@DORegistration,@Class_Id,@Adress,@gender,@Country_Id,@Prov_Id,@City_Id)";

                SqlCommand objInsertCommand = new SqlCommand(insertCommand, objSqlConnection);
                objInsertCommand.Parameters.AddWithValue("@FNanme", txt_st_name.Text);
                objInsertCommand.Parameters.AddWithValue("@LName", txt_st_lname.Text);
                objInsertCommand.Parameters.AddWithValue("@FatherName", txt_st_fname.Text);
                objInsertCommand.Parameters.AddWithValue("@FatherId", txt_st_father_id.Text);
               objInsertCommand.Parameters.AddWithValue("@Email", txt_st_email.Text);
                objInsertCommand.Parameters.AddWithValue("@Mobile", txt_st_mobile.Text);
                objInsertCommand.Parameters.AddWithValue("@DOBirth", date_of_birth.Value.ToString("dd-MM-yyyy"));
                objInsertCommand.Parameters.AddWithValue("@DORegistration", date_of_registration.Value.ToString("dd-MM-yyyy"));
                objInsertCommand.Parameters.AddWithValue("@Class_Id", classId);
                objInsertCommand.Parameters.AddWithValue("@Adress", txt_st_address.Text);
                objInsertCommand.Parameters.AddWithValue("@gender", gender);
                objInsertCommand.Parameters.AddWithValue("@Country_Id", countryId);
                objInsertCommand.Parameters.AddWithValue("@Prov_Id", provinceId);
                objInsertCommand.Parameters.AddWithValue("@City_Id", cityId);

                try
                {
                    objSqlConnection.Open();
                    objInsertCommand.ExecuteNonQuery();


                    MessageBox.Show("Data has been saved successfully in the Database!");
                }
                catch (SqlException ex)
                {

                    MessageBox.Show("The following error occured : " + ex.Message + ex.StackTrace, "Query Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                finally
                {
                    objSqlConnection.Close();
                }
                ResetControlls();

            }

        }

        //Button New
        private void btn_st_new_Click(object sender, EventArgs e)
        {
            txt_st_name.Text = "";
            txt_st_lname.Text = "";
            txt_st_fname.Text = "";
            txt_st_father_id.Text = "";
            txt_st_email.Text = "";
            txt_st_mobile.Clear();
            date_of_birth.Value = new DateTime(1980, 12, 30);
            date_of_registration.Value = new DateTime(1980, 12, 30);
            cmb_st_class.SelectedIndex = 0;
            txt_st_address.Clear();
            rbtn_male.Checked = false;
            rbtn_female.Checked = false;
            cmb_country.Text= "";
            cmb_province.Text = "";
            cmb_city.Text = "";

           
        }

        //
        private void btn_st_get_data_Click(object sender, EventArgs e)
        {
            st_Data_Display objStDataDisplay = new st_Data_Display();
            objStDataDisplay.Show();
            
            this.Close();
        }
        //Update Student method
        private void btn_st_update_Click(object sender, EventArgs e)
        {
            if (Login.strEmail != txt_st_email.Text)
            {
                MessageBox.Show("You have to permissions to update this record");
            }
            else
            {
                if (isDataValid())
                {
                    CheckedItems();
                    int countryId = Convert.ToInt32(cmb_country.SelectedValue);
                    int provinceId = Convert.ToInt32(cmb_province.SelectedValue);
                    int cityId = Convert.ToInt32(cmb_city.SelectedValue);
                    int classId = Convert.ToInt32(cmb_st_class.SelectedValue);

                    //Connection String
                    string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
                    SqlConnection objSqlConnection = new SqlConnection(cs);

                    try
                    {
                        // Open Connection
                        objSqlConnection.Open();
                        // prepare Update Command

                        string UpdateCommand = "UPDATE dbo.tblStudentInfo SET FNanme= '" + this.txt_st_name.Text + "',LName = '" + this.txt_st_lname.Text + "',FatherName ='"
                            + this.txt_st_fname.Text + "' ,FatherId = '" + this.txt_st_father_id.Text + "',Email = '"+txt_st_email.Text+"',Mobile='" + this.txt_st_mobile.Text + "',DOBirth = '" + this.date_of_birth.Value.ToString("dd-MM-yyyy") + "',DORegistration ='"
                            + this.date_of_registration.Value.ToString("dd-MM-yyyy") + "',Class_Id = '" + classId + "',Adress='" + this.txt_st_address.Text + "',gender='" + gender + "',Country_Id ='" + countryId + "',Prov_Id='"
                            + provinceId + "',City_Id='" + cityId + "' WHERE id = " + st_Data_Display.st_Id + "";

                        // Instantiate SqlCommand and Pass in CommandText and Connection Object
                        SqlCommand objSqlCommand = new SqlCommand(UpdateCommand, objSqlConnection);

                        // Execute the query identified within our command object
                        objSqlCommand.ExecuteNonQuery();
                        MessageBox.Show("Data has been successfully updated!");

                        DataSet ds = new DataSet();
                        //TODO: This line of code loads data into the table
                        this.adpt.Fill(ds);
                    }
                    catch (Exception ex)
                    {

                        MessageBox.Show("The following error occured : " + ex.Message, "Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }

                }
            }
            
        }

        //Delete Method
        private void btn_st_delete_Click(object sender, EventArgs e)
        {

            if (Login.strEmail != txt_st_email.Text)
            {
                MessageBox.Show("You have to permissions to Delete this record");
            }
            else
            {
                DialogResult objDialogResult = MessageBox.Show("Are you sure want to permanently delete Your Student Profile ?", "Confirm Record Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (objDialogResult == DialogResult.Yes)
                {
                    //Connention String
                    string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;

                    //Instantiate the SqlConnection
                    SqlConnection objSqlConnection = new SqlConnection(cs);

                    try
                    {
                        // Open Connection
                        objSqlConnection.Open();
                        // prepare Delete Command

                        string DeleteCommand = "DELETE FROM dbo.tblStudentInfo WHERE  id = " + st_Data_Display.st_Id + "";

                        // Instantiate SqlCommand and Pass in CommandText and Connection Object
                        SqlCommand objSqlCommand = new SqlCommand(DeleteCommand, objSqlConnection);

                        // Execute the query identified within our command object
                        objSqlCommand.ExecuteNonQuery();



                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("The following error occured : " + ex.Message, "Deletion Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    finally
                    {
                        objSqlConnection.Close();
                    }
                }
            }
                
        }

        //Load form

        private void st_registration_form_Load(object sender, EventArgs e)
        {

            AssignValuesFromControlsToClassProperties();

            lblNameAfterLogin.Text = "Hello " + Login.strEmail;
            txt_st_email.Text = Login.strEmail;
                
        }

        //btn send email
        private void btn_SendEmail_Click(object sender, EventArgs e)
        {
            EmailForm objEmailForm = new EmailForm();
            objEmailForm.Show();
            this.Close();
        }

        
    }
 }
