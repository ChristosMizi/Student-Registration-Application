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
   public abstract class BaseUser
    {
        // member variables
        private string firstName;
        private string lastName;
        private string FatherName;
        private string FatherId;
        private string Email;
        private string Mobile;
        private string DOB;
        private string DOR;
        private string address;
        private string gender;
        EmailMessage emailM;
        EmailForm emailF;


        // properties
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string FatherName1 { get => FatherName; set => FatherName = value; }
        public string FatherId1 { get => FatherId; set => FatherId = value; }
        public string Address { get => address; set => address = value; }
        public string Gender { get => gender; set => gender = value; }
        public string Email1 { get => Email; set => Email = value; }
        public string Mobile1 { get => Mobile; set => Mobile = value; }
        public string DOB1 { get => DOB; set => DOB = value; }
        public string DOR1 { get => DOR; set => DOR = value; }
        //public EmailMessage EmailM { get => emailM; set => emailM = value; }
        //public EmailForm EmailF { get => emailF; set => emailF = value; }

        public BaseUser() { }

        
        // constructor with parameters
        public BaseUser(string fname, string lname, string fathername, string fatherid, string email, string mobile, string dob, string dor, string address, string gender)
        {
            this.firstName = fname;
            this.lastName = lname;
            this.FatherName = fathername;
            FatherId = fatherid;
            this.Email = email;
            this.Mobile = mobile;
            this.DOB = dob;
            this.DOR = dor;
            this.address = address;
            this.gender = gender;
            //this.EmailM = emailmessage;
            //this.EmailF = emailform;


        }
        //Every USer should have a View method
       

        

    }
}
