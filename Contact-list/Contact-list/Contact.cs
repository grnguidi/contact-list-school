﻿using System;
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
            set 
            {
                if (value.Length == 11)
                {
                    Phone = value;
                }
                else
                {
                    Phone = "00-00000-0000";
                }
            } 
        }   
    
        //class bulding metod

        public Contact()
        {
            FirstName = "José";
            LastName = "Da Silva";
            Phone= "11-96512-2170";
        }

        //metod overcharge

        public Contact(string firstname, string lastname,string phone ) 
        { 
            FirstName = firstname;
            LastName = lastname;
            Phone = phone;
        }

        public override string ToString()
        {
            string saida = string.Empty;
            saida += String.Format("{0}, {1}", FirstName, LastName);
            saida += String.Format("{0}-{1}-{2}",
                    Phone.Substring(0, 1),
                    Phone.Substring(2,4),
                    Phone.Substring(7,3));
            return saida;
        }

    }       
}
