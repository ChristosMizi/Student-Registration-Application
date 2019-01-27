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
    public partial class CheckEmailsForm : Form
    {
        public static string oldText;
        public static string cmbDate;
        private Teacher objTeacher;
        private Professor objProf;
        Connection con = new Connection();
        private Student student;

        
        
        public CheckEmailsForm()
        {
            InitializeComponent();
        }


        
        //Button Get , brings all the messages
        private void GetMessage_Click(object sender, EventArgs e)
        {
          
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);
            
            try
            {
                if (objSqlConenction.State == ConnectionState.Closed)
                {
                    objSqlConenction.Open();
                    //  MessageBox.Show("DB connected.");
                }

                
                SqlCommand command = new SqlCommand("spGetSenders", objSqlConenction);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.AddWithValue("@Sender", Login.strEmail);
                
                // command.ExecuteNonQuery();
                SqlDataAdapter dtp = new SqlDataAdapter();
                dtp.SelectCommand = command;

                DataTable dt = new DataTable();
                dtp.Fill(dt);

                //bind Controlls

                txtFromSender.DataBindings.Add("Text", dt, "Sender");
               txtReceiver.DataBindings.Add("Text", dt, "Receiver");
                txtDOS.DataBindings.Add("Text", dt, "DOS");
                richTextBox1.DataBindings.Add("Text", dt, "DataMessage");

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
                // MessageBox.Show("You can view the data sent successfully", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


            }


        }


        //Load Form
        private void CheckEmailsForm_Load(object sender, EventArgs e)
        {

            txtFromSender.Text = Login.strEmail;
            ShowDOS();
         }

        //Button Get History Emails
        private void btnGetHistory_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            student = new Student();
            student.GetHistory();
            if ((Student.listOfMsgHistorySent != null) && (Student.listOfMsgHistorySent.Any()))
            {
               
                foreach (DataRow row in Student.listOfMsgHistorySent)
                {
                    listBox1.Items.Add(row["DataMessage"]);
                }


                Student.listOfMsgHistorySent.Clear();

            }

            else
            {
                MessageBox.Show("You have no SENT emails");
            }


        }

        //Load combobox with Dates of Submission
        public void ShowDOS()
        {
            try { 


              SqlDataAdapter adpt = new SqlDataAdapter("select MSDOS from tblEmailMessage where Sender='"+Login.strEmail+"'", con.opencon());
            DataTable dt = new DataTable();
                adpt.Fill(dt);

               
                foreach (DataRow dr in dt.Rows)
                {
                    string slot = ((DateTime)dr["MSDOS"]).ToString("yyyy-MM-dd HH:mm:ss.FFF");
                  


                        comboBox1.Items.Add(slot);
                    
                }

            }
            catch (Exception)
            {


            }
            finally
            {
                con.conclose();
            }

        }

        
        // Combobox Event  --> Selected index
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                richTextBox2.Text = "";
               // System.Int64 count = Convert.ToInt64(comboBox1.SelectedValue.ToString());
               SqlCommand cmd = new SqlCommand("select * from tblEmailMessage where MSDOS ='" + comboBox1.Text + "'"+"AND Sender='"+Login.strEmail+"'", con.opencon());
                cmd.ExecuteNonQuery();
                SqlDataReader dr;
                dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    string dm = dr["DataMessage"].ToString();
                    richTextBox2.Text = dm;
                }
                

            }
            catch (Exception)
            {


            }
            finally
            {
                con.conclose();
            }
        }
        // Button Edit message
        private void btn_Edit_Message(object sender, EventArgs e)
        {

            if (Login.cmbRolesvar == "Teacher" || Login.cmbRolesvar == "Professor" || Login.cmbRolesvar == "Super Admin")
            {
                if (comboBox1.Text== "Select Date:" || richTextBox3.Text == "")
                {
                    MessageBox.Show("Please select Date Sent");
                    comboBox1.Focus();
                }
                else
                {

                    objTeacher = new Teacher();
                    CheckEmailsForm.cmbDate = comboBox1.Text;
                    CheckEmailsForm.oldText = richTextBox2.Text;
                    objTeacher.BodyMessage = richTextBox3.Text;
                    objTeacher.EditMessage();
                    richTextBox2.Text = "";
                    comboBox1.Items.Clear();
                    comboBox1.Text = "Select Date:";
                    //Refresh Combo box with Dates of Submission
                    ShowDOS();
                }

            }
            else
            {
                MessageBox.Show("Please Beat it!");
            }         
        }

        //Button Delete message
        private void btn_DeleteMessage(object sender, EventArgs e)
        {
            if (Login.cmbRolesvar == "Professor" || Login.cmbRolesvar == "Super Admin" )
            {
                if (richTextBox2.Text == "")
                {
                    MessageBox.Show("Please select Date");
                    comboBox1.Focus();
                }
                else
                {
                    objProf = new Professor();
                    CheckEmailsForm.cmbDate = comboBox1.Text;
                    CheckEmailsForm.oldText = richTextBox2.Text;
                    objProf.DeleteMessage();
                    richTextBox2.Text = "";
                    comboBox1.Items.Clear();
                    comboBox1.Text = "Select Date:";
                    //Refresh Combo box with Dates of Submission
                    ShowDOS();
                }

            }
            else
            {
                MessageBox.Show("You don't have permissions for this action!");
            }










            
            

        }
    }
}
