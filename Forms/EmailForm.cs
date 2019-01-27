using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudentRegistrationSystem
{
    public partial class EmailForm : Form
    {
        //Class Variable
       private  EmailMessage objEmm;
        private Student student;
        private Users objusers;
        public static int countInbox=0;
       

        public EmailForm()
        {
            
            InitializeComponent();
        }
        // Load Form 
        private void EmailForm_Load(object sender, EventArgs e)
        {
            
            txtEmailFormSender.Text = Login.strEmail;
            GetReceivers();
        }

        //Method Bring all Registered users
        private void GetReceivers()
        {
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("spGetAllRegisteredUsers", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;



            try
            {
                objSqlConenction.Open();
                //Now we are reading from our database so we have to use our datareader object

                SqlDataReader objDataReader = objSqlCommand.ExecuteReader();

                //While Data Reader can read, I add Items to the combo box
                while (objDataReader.Read())
                {
                    cmbEmailFormReceiver.Items.Add(objDataReader[0]);
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

        //Method assign values
        private void AssignValuesOfControlsToClassProperties()
        {
            objEmm = new EmailMessage();

            //  objEmm.SetSender(txtEmailFormSender.Text);
            objEmm.Sender = txtEmailFormSender.Text;
             objEmm.Receiver = cmbEmailFormReceiver.Text;
            objEmm.DOS1 = dateTimePicker1.Value.ToString("dd/MM/yyyy hh:mm:ss");
            objEmm.DataMessage1 = richTextBox1.Text;
        }

        string userProfileDesktop = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);

        //button Send email
        private void btnSendEmail_Click(object sender, EventArgs e)
        {

            objEmm = new EmailMessage();
            AssignValuesOfControlsToClassProperties();
            objusers = new Users();
            objusers.FindCount();
            countInbox = Users.ValueInsertedColumnCountInboxBeforeUserSendsEmail;
            objEmm.InsertDataToDatabase();

            string csvPath = Path.Combine(userProfileDesktop, "Message.csv");

            if (!File.Exists(csvPath))
            {

                StringBuilder csvContent = new StringBuilder();
                string HeaderLine = "Sender,Receiver,DOS,DataMessage" + Environment.NewLine;
                File.WriteAllText(csvPath, HeaderLine);
                csvContent.AppendLine($"{Login.strEmail},{cmbEmailFormReceiver.Text},{dateTimePicker1.Value.ToString("yyyy-MM-dd")},{richTextBox1.Text}");
                File.AppendAllText(csvPath, csvContent.ToString());

            }
            else
            {

                StringBuilder csvContent = new StringBuilder();
                csvContent.AppendLine($"{Login.strEmail},{cmbEmailFormReceiver.Text},{dateTimePicker1.Value.ToString("yyyy-MM-dd")},{richTextBox1.Text}");
                File.AppendAllText(csvPath, csvContent.ToString());

            }
        }

       
    }
}
