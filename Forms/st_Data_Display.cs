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
    public partial class st_Data_Display : MaterialSkin.Controls.MaterialForm
    {
        Connection con = new Connection();
        SqlDataAdapter adpt;
        DataTable dt;
        SqlCommand cmd;
        public static int st_Id;

        public st_Data_Display()
        {
            InitializeComponent();
        }

        private void st_Data_Display_Load(object sender, EventArgs e)
        {
            adpt = new SqlDataAdapter("select tblStudentInfo.id, tblStudentInfo.FNanme,tblStudentInfo.LName,tblStudentInfo.FatherName,tblStudentInfo.FatherId,tblStudentInfo.Email,tblStudentInfo.Mobile,tblStudentInfo.DOBirth,tblStudentInfo.DORegistration,tblClass.ClassName,tblStudentInfo.Adress,tblStudentInfo.gender,country.CountryName,tblprovince.ProvinceName,tblcity.CityName from tblStudentInfo inner join tblClass on tblStudentInfo.Class_Id = tblClass.Id inner join country on tblStudentInfo.Country_Id = country.country_id inner join tblprovince on tblStudentInfo.Prov_Id = tblprovince.Id inner join tblcity on tblStudentInfo.City_Id = tblcity.Id", con.opencon());
            dt = new DataTable();
            adpt.Fill(dt);
            dataGridView1.DataSource = dt;
        }

        private void dataGridView1_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            st_registration_form obj = new st_registration_form();

            st_Id = Convert.ToInt32(dataGridView1.Rows[e.RowIndex].Cells[0].Value.ToString());
            obj.txt_st_name.Text = dataGridView1.Rows[e.RowIndex].Cells[1].Value.ToString();
            obj.txt_st_lname.Text = dataGridView1.Rows[e.RowIndex].Cells[2].Value.ToString();
            obj.txt_st_fname.Text = dataGridView1.Rows[e.RowIndex].Cells[3].Value.ToString();
            obj.txt_st_father_id.Text = dataGridView1.Rows[e.RowIndex].Cells[4].Value.ToString();
            obj.txt_st_email.Text = dataGridView1.Rows[e.RowIndex].Cells[5].Value.ToString();
            obj.txt_st_mobile.Text = dataGridView1.Rows[e.RowIndex].Cells[6].Value.ToString();
            obj.date_of_birth.Text = dataGridView1.Rows[e.RowIndex].Cells[7].Value.ToString();
            obj.date_of_registration.Text = dataGridView1.Rows[e.RowIndex].Cells[8].Value.ToString();
            obj.cmb_st_class.Text = dataGridView1.Rows[e.RowIndex].Cells[9].Value.ToString();
            obj.txt_st_address.Text = dataGridView1.Rows[e.RowIndex].Cells[10].Value.ToString();

            obj.rbtn_male.Checked = true;
            obj.rbtn_female.Checked = false;


            if (dataGridView1.Rows[e.RowIndex].Cells[11].Value.ToString()== "Female")
            {
                obj.rbtn_male.Checked = false;
                obj.rbtn_female.Checked = true;
            }

            obj.cmb_country.Text= dataGridView1.Rows[e.RowIndex].Cells[12].Value.ToString();
            obj.cmb_province.Text= dataGridView1.Rows[e.RowIndex].Cells[13].Value.ToString();
            obj.cmb_city.Text= dataGridView1.Rows[e.RowIndex].Cells[14].Value.ToString();

            obj.Show();
            obj.btn_st_delete.Enabled = true;
            obj.btn_st_update.Enabled = true;

            this.Close();
        }

        private void txtBx_Search_TextChanged(object sender, EventArgs e)
        {
            searchData(txtBx_Search.Text);
        }

        public void searchData(string search)
        {
            try
            {
                using (SqlConnection cn = new SqlConnection(ConfigurationManager.ConnectionStrings["StudentDataConnection"].ConnectionString))
                {
                    if (cn.State == ConnectionState.Closed)
                    {
                        cn.Open();
                    }
                    using (SqlDataAdapter adpt = new SqlDataAdapter("select * from tblStudentInfo where FNanme like '%" + search + "%' ",cn))
                    {
                        dt= new DataTable();
                        adpt.Fill(dt);
                        dataGridView1.DataSource = dt;

                    }
                }
               
            }
          

            catch (Exception ex)
            {
                MessageBox.Show("The following error occured : " + ex.Message, "Search Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            st_registration_form st = new st_registration_form();
            st.Show();
            this.Close();
        }
    }
}
