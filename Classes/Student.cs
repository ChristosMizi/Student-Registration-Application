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
    class Student : BaseUser
    {
        private CheckEmailsForm chk1;
        public static DataTable myDatatable;
        public static List<DataRow> listOfMsgHistorySent;

     
        //constructors
        public Student() { }
        public Student(CheckEmailsForm chk1)
        {
            this.chk1 = chk1;
        }


        //Method get History of all emails sent
        public void GetHistory()
        {
            
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            try
            {
                if (objSqlConenction.State == ConnectionState.Closed)
                {
                    objSqlConenction.Open();
                    
                }

               
                SqlCommand command = new SqlCommand("spGetSenders", objSqlConenction);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Sender", Login.strEmail);

                
                SqlDataAdapter dtp = new SqlDataAdapter();
                dtp.SelectCommand = command;

                DataTable dt = new DataTable();
                dtp.Fill(dt);

                
                
                foreach (DataRow dr in dt.Rows)
                {

                    
                     Student.listOfMsgHistorySent = dt.AsEnumerable().ToList();
                }



                objSqlConenction.Close();
                objSqlConenction.Dispose();

                objSqlConenction.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SQL spGetAllSentMessage Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            finally
            {
                objSqlConenction.Close();
                


            }

        }

        
        

    }
}
