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
        private string email;

        //properties
        public string FirstName
        {
            get { return firstname;  }
            set { firstname = value; }
        }

        public string LastName
        { 
            get { return lastname; } 
            set { lastname = value; } 
        }

        public string Phone
        { 
            get { return phone;  }
            set 
            {
                if (value.Length == 11)
                {
                    phone = value;
                }
                else
                {
                    phone = "00000000000";
                }
            } 
        }   

        public string Email
        {
            get { return email; }
            set { email = value;}
        }
    
        //class bulding metod

        public Contact()
        {
            FirstName = "José";
            LastName = "Da Silva";
            Phone= "11965122170";
            Email = "josedasilva@gmail.com";
        }

        //metod overcharge

        public Contact(string firstname, string lastname,string phone, string email ) 
        { 
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1}", firstname, lastname);
            saida += String.Format("{0}-{1}-{2}",
                    phone.Substring(0, 2),
                    phone.Substring(2,5),
                    phone.Substring(7,4));
            saida += string.Format("{0}", email);
            return saida;   
        }

    }       
}
