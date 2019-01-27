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
    public class EmailMessage
    {
        SqlDataAdapter dtp;

        private int counter = 0;
        List<string> ArrayOFDOS = new List<string>();
        private string sender;
       private string receiver;
       private string DataMessage;
       private string DOS;
        

        
        
        public string DOS1 { get => DOS; set => DOS = value; }
        public string DataMessage1 { get => DataMessage; set => DataMessage = value; }
        public string Receiver { get => receiver; set => receiver = value; }
        public string Sender { get => sender; set => sender = value; }

        

        //Constructors
        public EmailMessage() { }
        public EmailMessage(string sender)
        {
            this.Sender = sender;
        }

        public EmailMessage(string sender, string receiver, string datamessage,string dos)
        {
            this.Sender = sender;
            this.Receiver = receiver;
            this.DataMessage = datamessage;
            this.DOS = dos;
        }


        //Method used to Send email
        public void InsertDataToDatabase()

        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("sp_SendMessage", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@Sender", Sender);
            objSqlCommand.Parameters.AddWithValue("@Receiver", receiver);
            objSqlCommand.Parameters.AddWithValue("@DataMessage", DataMessage1);
            objSqlCommand.Parameters.AddWithValue("@DOS", DOS);
            objSqlCommand.Parameters.AddWithValue("@AllInboxRows", EmailForm.countInbox);


            try
            {
                objSqlConenction.Open();
                objSqlCommand.ExecuteNonQuery();
                MessageBox.Show("Email has been sent successfully!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "SQL Insert Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            finally
            {
                objSqlConenction.Close();
               


            }
        }



        //Method has not been used! just an idea
        public bool checkIfNewEmailSent()
        {
           
            FillTableWithDOS();
            if (isLastTimeEmailSentBiggerThanPrevious() == true)
            {
                return true;
            }
            else
                return false;
        }


        
        //Method Fill table with DOS
        private void FillTableWithDOS()
        {

            
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("spSelectAllValuesDOSDependingTheReceiver", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

           

            try
            {
                objSqlConenction.Open();
                SqlDataReader objDataReader = objSqlCommand.ExecuteReader();

                while (objDataReader.Read())
                {
                    ArrayOFDOS.Add(objDataReader[0].ToString());
                }
                counter++;
                objDataReader.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "Compare Dates Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            finally
            {
                objSqlConenction.Close();
                MessageBox.Show("Compare Dates", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }

            
        }


        //I haven't used this method just an idea
         public bool isLastTimeEmailSentBiggerThanPrevious ()
        {
            var lastItem = ArrayOFDOS[ArrayOFDOS.Count - 1];
            DateTime DTLast = Convert.ToDateTime(lastItem);

            var lastItem2 = ArrayOFDOS[ArrayOFDOS.Count - 2];

            DateTime DT2 = Convert.ToDateTime(lastItem2);

            if (DTLast > DT2 && counter!=0)
            {
                return true;
            }
            else
                return false;
        }


       

    }
}
