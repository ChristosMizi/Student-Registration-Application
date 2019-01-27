using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    class Teacher : Student
    {
        private string bodyMessage;

        public string BodyMessage { get => bodyMessage; set => bodyMessage = value; }


        // Constructors
        public Teacher() { }
        public Teacher(string body)
        {
            this.bodyMessage = body;
        }

        //Method Edit Message
        public void EditMessage()
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("spEditMessage10", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;
            objSqlCommand.Parameters.AddWithValue("@ComboBoxDate", CheckEmailsForm.cmbDate);           
            objSqlCommand.Parameters.AddWithValue("@OldText",CheckEmailsForm.oldText);
            objSqlCommand.Parameters.AddWithValue("@BodyMessage", BodyMessage);
            objSqlCommand.Parameters.AddWithValue("@Sender",Login.strEmail);
            

            try
            {
                objSqlConenction.Open();
                objSqlCommand.ExecuteNonQuery();
                MessageBox.Show("Message has been successfully changed");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SQL Edit Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            finally
            {
                objSqlConenction.Close();
                


            }
        }
    }
}
