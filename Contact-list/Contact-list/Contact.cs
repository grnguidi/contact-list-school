using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Contact_list
{
    internal class Contact
    {
        //internal var contact class
        private string firstname;
        private string lastname;
        private string phone;

        //properties
        public string FirstName
        {
            get { return FirstName;  }
            set { FirstName = value; }
        }

        public string LastName
        { 
            get { return LastName; } 
            set { LastName = value; } 
        }

        public string Phone
        { 
            get { return Phone;  }
            set { Phone = value; } 
        }   
    }
}
