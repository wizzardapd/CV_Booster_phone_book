using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CV_Booster_phone_book
{
    public class ContactService
    {
        // list where the added contacts are saved
        List<contactCard> contacts = new List<contactCard>();

        // all the service methods (not finished, still open task to do) 
        //(ofc all the access modifiers and return types are not right atm)

        // method that adds contact, needs all fields to be filled in order to add the concact to the List<contactCard> contacts 
        // maybe a check if all required fields are filled?
        public void AddContact() { }

        // method that deleted the requested contact, maybe use an ID to identify the contact?
        public void DeleteConctact() { }

        // Access an element of List<contactCard> contacts and update it's content
        public void UpdateContact() { }

        // method that returns all the elements of List<contactCard>
        public void GetAllContacts() { }

        // method that searches the requested id of List<contactCard> contacts
        public void SearchContact() { }

        // method that exports all the contacts of List<contactCard> contacts, maybe in a CSV? not quite sure yet
        public void Export() { }

    }
}
