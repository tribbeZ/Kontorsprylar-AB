using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLLibraryKAB
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }
        public string Username { get; set; }
        public string Password { get; set; }



        public Customer(string firstname, string lastname, string email, string username, string password)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
            this.Username = username;
            this.Password = password;

        }
        public Customer()
        {
        }
    }

   
}

