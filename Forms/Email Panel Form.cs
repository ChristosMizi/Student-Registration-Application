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
    public partial class Email_Panel_Form : Form
    {
        int StatusForCheckboxWhenCheckingEmail = 0;
        
        Users objUsers;

        
        Connection con = new Connection();
        public Email_Panel_Form()
        {
            InitializeComponent();
        }

        // Load event 
        private void Email_Panel_Form_Load(object sender, EventArgs e)
        {
            ShowInbox();
            LoadCmBoxWithSenders();
            LoadCmBoxWithReceivers();
            label1.Text = "Hello " + Login.strEmail;
            if (comboBox1.Text == "Select Date:")
            {
                chkBxRead.Enabled = false;
                chkBxUnRead.Enabled = false;
                
            }
            else
            {
                
                ReturnResultFromChkBox();

                Assignvalues();
                objUsers.SetStatus();

            }
            if (Login.cmbRolesvar == "Teacher" || Login.cmbRolesvar == "Professor" || Login.cmbRolesvar == "Student")
            {
                button3.Visible = false;
                cmbSenders.Visible = false;
                cmbReceivers.Visible = false;
                cmbMSDOS.Visible = false;
                button4.Visible = false;
                    
            }
            else
            {
                button3.Visible = true;
                cmbSenders.Visible = true;
                cmbReceivers.Visible = true;
                cmbMSDOS.Visible = true;
                button4.Visible = true;
            }


        }

        //Button Send email
        private void btn_Send_Email_Click(object sender, EventArgs e)
        {
            EmailForm objEmailForm = new EmailForm();
            objEmailForm.Show();
            this.Close();
        }

        // Button View Sent emails
        private void btn_View_Sent(object sender, EventArgs e)
        {
            CheckEmailsForm chk = new CheckEmailsForm();

            chk.Show();
            this.Hide();
        }
        //Loads Comboox with all MSDOS where Receiver is Admin Inbox Method
        public void ShowInbox()
        {
            try
            {


                SqlDataAdapter adpt = new SqlDataAdapter("select MSDOS from tblEmailMessage where Receiver='" + Login.strEmail + "'", con.opencon());
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

        //Load Combo Box with Senders
        public void LoadCmBoxWithSenders()
            {
            try
            {


                SqlDataAdapter adpt = new SqlDataAdapter("select distinct Sender from tblEmailMessage", con.opencon());
                DataTable dt = new DataTable();
                adpt.Fill(dt);


                foreach (DataRow dr in dt.Rows)
                {
                    string slot = dr["Sender"].ToString();



                    cmbSenders.Items.Add(slot);

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

        //Load ComboBox with Receivers

        public void LoadCmBoxWithReceivers()
        {
            try
            {


                SqlDataAdapter adpt = new SqlDataAdapter("select distinct Receiver from tblEmailMessage", con.opencon());
                DataTable dt = new DataTable();
                adpt.Fill(dt);


                foreach (DataRow dr in dt.Rows)
                {
                    string slot = dr["Receiver"].ToString();



                    cmbReceivers.Items.Add(slot);

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

        public void LoadMSDOS()
        {
            
        }

        //Button check your Inbox
        private void btn_inbox(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Select Date:")
            {
                MessageBox.Show("Dates are empty.You have no messages!");
            }
            else
            {
                chkBxUnRead.Checked = false;
                chkBxRead.Checked = false;
                try
                {


                    SqlDataAdapter adpt = new SqlDataAdapter("select * from tblEmailMessage where Receiver='" + Login.strEmail + "'" + "and MSDOS='" + comboBox1.Text + "'", con.opencon());
                    DataTable dt = new DataTable();
                    adpt.Fill(dt);


                    foreach (DataRow dr in dt.Rows)
                    {
                        string slot = dr["DataMessage"].ToString();


                        // Inbox.DataBindings.Add("Text", dt, "DataMessage");
                        Inbox.Text = slot;

                    }

                }
                catch (Exception)
                {


                }
                finally
                {
                    con.conclose();
                }
                StatusForCheckboxWhenCheckingEmail = ReturnStatusforCheckBox();

                if (StatusForCheckboxWhenCheckingEmail == 1)
                {
                    chkBxRead.Checked = true;
                }
                else

                {
                    chkBxUnRead.Checked = true;
                }
            }
            
        }

        //Method return Status for checkbox
        private int ReturnStatusforCheckBox()
        {
            int status = 0;
            string cs = ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString;
            // Connection Object
            SqlConnection objSqlConenction = new SqlConnection(cs);

            // Sql Command
            SqlCommand objSqlCommand = new SqlCommand("sp_GetStatusEM", objSqlConenction);
            objSqlCommand.CommandType = CommandType.StoredProcedure;

            objSqlCommand.Parameters.AddWithValue("@Receiver", Login.strEmail);
            objSqlCommand.Parameters.AddWithValue("@MSDOS", comboBox1.Text);
            objSqlCommand.Parameters.AddWithValue("@Inbox", Inbox.Text);
            try
            {
                objSqlConenction.Open();
                status =  (int)(objSqlCommand.ExecuteScalar());
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error:" + ex.Message, "User Authentication failed!", MessageBoxButtons.OK, MessageBoxIcon.Error);


            }
            finally
            {
                objSqlConenction.Close();



            }

            return status;

        }



        // Buttton View others users data
        private void ViewOtherIsersData(object sender, EventArgs e)
        {
            GetDataMessageOtherUsers();
        }

        // MEthod Get Messages of All users
        public void GetDataMessageOtherUsers()
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


                SqlCommand command = new SqlCommand("st_GetDataMessageFromOtherUSers", objSqlConenction);

                command.CommandType = CommandType.StoredProcedure;
                command.Parameters.Clear();
                command.Parameters.AddWithValue("@Sender", cmbSenders.Text);
                command.Parameters.AddWithValue("@Receiver", cmbReceivers.Text);
                command.Parameters.AddWithValue("@MSDOS", cmbMSDOS.Text);

                // command.ExecuteNonQuery();
                SqlDataAdapter dtp = new SqlDataAdapter();
                dtp.SelectCommand = command;

                DataTable dt = new DataTable();
                dtp.Fill(dt);

                //bind Controlls
                Inbox.DataBindings.Clear();
                Inbox.DataBindings.Add("Text", dt, "DataMessage");
                

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

        // Etrxe xwris ti methodo auti ara mporeis na ti sviseis
        private void Selected_IndexReceiver(object sender, EventArgs e)
        {
            try
            {


                SqlDataAdapter adpt = new SqlDataAdapter("select MSDOS from tblEmailMessage where Sender='" + cmbSenders.Text + "'" + "and Receiver='" + cmbReceivers.Text + "'", con.opencon());
                DataTable dt = new DataTable();
                adpt.Fill(dt);


                foreach (DataRow dr in dt.Rows)
                {
                    string slot = ((DateTime)dr["MSDOS"]).ToString("yyyy-MM-dd HH:mm:ss.FFF");



                    cmbMSDOS.Items.Add(slot);

                }

            }
            catch (Exception)
            {


            }
            finally
            {
                con.conclose();
            }


            //    int count = Convert.ToInt32(cmbReceivers.SelectedValue.ToString());
            //    SqlDataAdapter adpt = new SqlDataAdapter("select * from tblEmailMessage where Country_id ='" + count + "'", con.opencon());


            //}
            //    catch (Exception)
            //    {


            //    }
            //    finally
            //    {
            //        con.conclose();
            //    }
        }

       
       
        // Button Get dates 
        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                Inbox.Text = "";
                cmbSenders.DataBindings.Clear();
                cmbReceivers.DataBindings.Clear();
                cmbMSDOS.DataBindings.Clear();
                
                SqlDataAdapter dtp = new SqlDataAdapter("select MSDOS from tblEmailMessage where Sender ='" + cmbSenders.Text + "'" + "AND Receiver='" + cmbReceivers.Text + "'", con.opencon());
                
                DataTable dt = new DataTable();

                dtp.Fill(dt);
                
                    
                foreach (DataRow dr in dt.Rows)
                {
                   
                    string slot = ((DateTime)dr["MSDOS"]).ToString("yyyy-MM-dd HH:mm:ss.FFF");

                    cmbMSDOS.DataBindings.Clear();

                    cmbMSDOS.Items.Add(slot);

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
        int statusResult = 0;

      
        //Method Return result when CheckBox checked or not
        private int ReturnResultFromChkBox()
        {
            if (chkBxRead.Checked)
            {
                statusResult = 1;
                return statusResult;

            }
            else
            {
                statusResult = 2;
                return statusResult;
            }

        }

        //Method Assign values form Form Components to variable members via properties
        private void Assignvalues()
        {
            objUsers = new Users();
            objUsers.MSDOS1= comboBox1.Text;
            objUsers.Inbox = Inbox.Text;
              objUsers.Statusmsg=  statusResult;
            
        }
        


        //Event checkbox state checked
        private void checkState_Event(object sender, EventArgs e)
        {
           
        }

        //Combobox1 selected index event
        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            
                chkBxRead.Enabled = true;
                chkBxUnRead.Enabled = true;
                
           

            }

       
        // Event when Read Box clicked
        private void EventRead(object sender, EventArgs e)
        {
            
                chkBxUnRead.Checked = false;
            
            if (comboBox1.Text == "Select Date:")
            {
                chkBxRead.Enabled = false;
                MessageBox.Show("Select Date first!");
            }
            else
            {
                chkBxRead.Enabled = true;
                ReturnResultFromChkBox();

                Assignvalues();
                objUsers.SetStatus();
                MessageBox.Show("Status Email has been updated");

            }

            chkBxRead.Checked = false;
            chkBxUnRead.Checked = false;
        }

        // Event click when Unread box is clicked
        private void EventUnread(object sender, EventArgs e)
        {
            chkBxRead.Checked = false;
            if (comboBox1.Text == "Select Date:")
            {
                chkBxUnRead.Enabled = false;
                MessageBox.Show("Select Date first!");
            }
            else
            {
                chkBxUnRead.Enabled = true;
                ReturnResultFromChkBox();

                Assignvalues();
                objUsers.SetStatus();
                MessageBox.Show("Status Email has been updated");
                
            }
            chkBxRead.Checked = false;
            chkBxUnRead.Checked = false;
        }


       
    }
}



