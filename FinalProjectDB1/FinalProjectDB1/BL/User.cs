using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace FinalProjectDB1.BL
{
    internal abstract class User
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string Contact { get; set; }
        public long CNIC { get; set; }
        public string City { get; set; }
        public string UserType { get; set; }


        public User(string firstName, string lastName, string email, string password, string contact, long cnic, string city, string userType)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Email = email;
            this.Password = password;
            this.Contact = contact;
            this.CNIC = cnic;
            this.City = city;
            UserType = userType;
        }

        protected User()
        {
        }
    }
    
}
