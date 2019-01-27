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
    class Professor : Teacher
    {
        //Delete Message
        public void DeleteMessage()
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("stDeleteMessage", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@BodyMessage", CheckEmailsForm.oldText);
            objSqlCommand.Parameters.AddWithValue("@Sender", Login.strEmail);
            objSqlCommand.Parameters.AddWithValue("@MSDOS", CheckEmailsForm.cmbDate);


            try
            {
                objSqlConenction.Open();
                objSqlCommand.ExecuteNonQuery();
                MessageBox.Show(" Message has been successfully Deleted ", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SQL Delete Message Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            finally
            {
                objSqlConenction.Close();
               // MessageBox.Show("This is the Finally Block", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }
        }
    }
}
