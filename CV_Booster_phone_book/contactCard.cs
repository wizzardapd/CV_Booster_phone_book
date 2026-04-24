using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace CV_Booster_phone_book
{
    public class ContactCard
    {
        private static int _nextId = 1; // counts upwards globaly

        public int id { get; private set; } // private set, so you can't change it
        public string name { get; set; }
        public string phoneNumber { get; set; }
        public string address { get; set; }
        public string email { get; set; }
        public string note { get; set; }
        public ContactCard(string _name, string _phoneNumber, string _address, string _email, string _note)
        {
            id = _nextId++;
            name = _name;
            phoneNumber = _phoneNumber;
            address = _address;
            email = _email;
            note = _note;
        }


        // returns only the name of the contact 
        public override string ToString()
        {
            return $" [{id}] {name} | {phoneNumber} | {email}";
        }
    }
}
