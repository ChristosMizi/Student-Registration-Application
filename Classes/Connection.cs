using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace StudentRegistrationSystem
{
    class Connection
    {
        SqlConnection con;

        public Connection()
        {
            con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=studentdata; Integrated Security=True");
        }

        public SqlConnection opencon()
        {
            try
            {
                con.Open();
            }
            catch (Exception)
            {

                throw;
            }
            return con;
        }

        public void conclose()
        {
            try
            {
                con.Close();
            }
            catch (Exception)
            {

                throw;
            }

        }
    }
}
