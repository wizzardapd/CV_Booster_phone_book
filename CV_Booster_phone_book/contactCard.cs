using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Booster_phone_book
{
    public class contactCard
    {

        // maybe give it an ID? to better find the contact
        public string name;
        public int phone;
        public string address;
        public string email;
        public string notice;
        public contactCard(string Name, int phoneNumber, string Address, string Email, string Notice)
        {
            name = Name;
            phone = phoneNumber;
            address = Address;
            email = Email;
            notice = Notice; 
        }
    }
}
