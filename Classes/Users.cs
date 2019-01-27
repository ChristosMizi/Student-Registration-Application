using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    class Users
    {
        // Variable members
        private string email;
        private string password;
        private string role;
        private string description;
        private int statusmsg;
        private string MSDOS;
        private string inbox;
        public static int initialCountInbox = 0;
        public static int ValueOfInbox = 0;
        public static int ValueInsertedColumnCountInboxBeforeUserSendsEmail =0;
        public static int ValueOfInbox1 = 0;
        public static int getFirstUnread;



        enum Roles
        {
            Student,
            Teacher,
            Professor
        }
        public string [] GetArrayNamesFromEnum()
        {
            
            return    Enum.GetNames(typeof(Roles));
            
        }
       
        //Constructors
        public Users() { }

        //Parameterized Constructor
        public Users(string email,string password,string role, string description)
        {
            this.Email = email;
            this.Password = password;
            this.Role = role;
            this.Description = description;
          
        }

        // Properties

        public string Password { get => password; set => password = value; }
        public string Role { get => role; set => role = value; }
        public string Description { get => description; set => description = value; }
        public string Email { get => email; set => email = value; }
        
        public string MSDOS1 { get => MSDOS; set => MSDOS = value; }
        public string Inbox { get => inbox; set => inbox = value; }
        public int Statusmsg { get => statusmsg; set => statusmsg = value; }
        public int GetFirstUnread { get => getFirstUnread; set => getFirstUnread = value; }


        //Add User Method
        public void AddUSer()
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("spInsertCommand", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@Email", Email);
            objSqlCommand.Parameters.AddWithValue("@Password", Password);
            objSqlCommand.Parameters.AddWithValue("@Roles", Role);
            objSqlCommand.Parameters.AddWithValue("@Description", Description);

            try
            {
                objSqlConenction.Open();
                objSqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SQL Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            finally
            {
                objSqlConenction.Close();
                MessageBox.Show("New User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    

            }



        }

        //Update User Method
        public void UpdateUser()
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("spUpdateCommand", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@Email", Email);
            objSqlCommand.Parameters.AddWithValue("@Password", Password);
            objSqlCommand.Parameters.AddWithValue("@Roles", Role);
            objSqlCommand.Parameters.AddWithValue("@Description", Description);

            try
            {
                objSqlConenction.Open();
                objSqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SQL Update Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            finally
            {
                objSqlConenction.Close();
                MessageBox.Show("New User has been Updated Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        //Delete USer Method
        public void DeleteUser()
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("spUDelete", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@Email", Email);
            

            try
            {
                objSqlConenction.Open();
                objSqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SQL Delete Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            finally
            {
                objSqlConenction.Close();
                MessageBox.Show("User has been Deleted Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }

        //Authorised User Method
        public bool AuthorisedUser()
        {
            bool isUserAuthorised = false;
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("spIsUserDetailsValid", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@Email", Email);
            objSqlCommand.Parameters.AddWithValue("@Password", Password);
            objSqlCommand.Parameters.AddWithValue("@Roles", Role);


            try
            {
                objSqlConenction.Open();
               isUserAuthorised=(bool) objSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "User Authentication failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                

            }
            finally
            {
                objSqlConenction.Close();
                


            }

            return isUserAuthorised;
        }

        //CheckIfEmailExists No use just created it was an idea
        public bool CheckIfEmailExists()
        {
            bool EmailExists = false;
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("spStudentSaveCommandCheckIFEmailExists", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@Email", Email);




            try
            {
                objSqlConenction.Open();
                EmailExists = (bool)objSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "User Authentication failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                objSqlConenction.Close();



            }

            return EmailExists;
        }

        // Method returns total number os rows Inbox messages that user has
        public void FindCount()
        {

            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("stGetAllInbox", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@Receiver", Login.strEmail);
            




            try
            {
                objSqlConenction.Open();
                Users.initialCountInbox = (int)objSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, " SQL Count Inbox Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                objSqlConenction.Close();



            }
             Users.ValueInsertedColumnCountInboxBeforeUserSendsEmail =Users.initialCountInbox;
        }

        // Method insert value to Column 'CountInbox'
        public void AddCounterInbox()
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("spInsertValueColumnInbox", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@counter",EmailForm.countInbox);
            objSqlCommand.Parameters.AddWithValue("@Sender", Login.strEmail);

            try
            {
                objSqlConenction.Open();
                objSqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SQL Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            finally
            {
                objSqlConenction.Close();
                MessageBox.Show("New User Added Successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

           

        }

        //Method get the value of Column Inbox
        public void  GetValueOfInbox()
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("sp_GetValueFromColumnCountInbox", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@Receiver", Login.strEmail);



            try
            {
                objSqlConenction.Open();
                Users.ValueOfInbox = (int)objSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, " SQL GerValueCellCountInbox Error", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                objSqlConenction.Close();



            }
            Users.ValueOfInbox1 = Users.ValueOfInbox;


        }

        //Method Set Status of Email (Read || Unread)
        public void SetStatus()
        {
            
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("spUpdateStatus", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@Receiver", Login.strEmail);
            objSqlCommand.Parameters.AddWithValue("@MSDOS", MSDOS1);
            objSqlCommand.Parameters.AddWithValue("@Status", Statusmsg);
            objSqlCommand.Parameters.AddWithValue("@Data", Inbox);




            try
            {
                objSqlConenction.Open();
                objSqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Status Error Message", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                objSqlConenction.Close();



            }

        }

        // Get the First unread you find in the StatusID didn't use it as i found another workaround
        public int GetTheFirstStatusUnread()

        {


            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("sp_SearchIfUnReadExists", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;


            try
            {
                objSqlConenction.Open();
                GetFirstUnread = (int)objSqlCommand.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Sp Search Unread failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                objSqlConenction.Close();



            }
            getFirstUnread = GetFirstUnread;
            return getFirstUnread;
        }
    }
}
