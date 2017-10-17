﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQLLibraryKAB
{
    public class Customer
    {
        public int CustomerID { get; set; }
        public int UserID { get; set; }
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Email { get; set; }

        public Customer(string firstname, string lastname, string email)
        {
            this.Firstname = firstname;
            this.Lastname = lastname;
            this.Email = email;
        }

       
    }

   
}
