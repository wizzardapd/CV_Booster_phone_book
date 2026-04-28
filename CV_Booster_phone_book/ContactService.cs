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
        List<ContactCard> contacts = new List<ContactCard>();

        // all the service methods (not finished, still open task to do) 
        //(ofc all the access modifiers and return types are not right atm)

        // method that adds contact, needs all fields to be filled in order to add the concact to the List<contactCard> contacts 
        // maybe a check if all required fields are filled?
        public void AddContact(ContactCard contact) 
        {
            contacts.Add(contact);
        }

        // method that deleted the requested contact, maybe use an ID to identify the contact?
        public void DeleteContact() 
        { 
            Console.WriteLine("2 has been pressed"); 
        }

        // Access an element of List<contactCard> contacts and update it's content
        public void UpdateContact(

            string newName,
            string newPhoneNumber,
            string newAddress,
            string newEmail,
            string newNote)
        {
            ContactCard contact = contacts.FirstOrDefault();

            if (contact == null)
            {
                Console.WriteLine("Contact not found.");
                return;
            }

            contact.name = newName;
            contact.phoneNumber = newPhoneNumber;
            contact.address = newAddress;
            contact.email = newEmail;
            contact.note = newNote;

            Console.WriteLine("Contact updated successfully.");
        }

        // method that returns all the elements of List<contactCard>

        public List<ContactCard> GetAllContacts()
        {
            return contacts;
        }

        // method that searches the requested searchTerm of all elements List<contactCard> contacts
        public List<ContactCard> SearchContact (string searchTerm) 
        { 
            if (searchTerm == " ")
            {
                return new List<ContactCard>();
            }

            else
            {
                return contacts
                .Where(contact =>
                    contact.name.ToLower().Contains(searchTerm) ||
                    contact.phoneNumber.ToLower().Contains(searchTerm) ||
                    contact.email.ToLower().Contains(searchTerm) ||
                    contact.address.ToLower().Contains(searchTerm))
                .ToList();
            }
        }

        // method that exports all the contacts of List<contactCard> contacts, maybe in a CSV? not quite sure yet
        public void Export() 
        { 
            Console.WriteLine("6 has been pressed"); 
        }

    }
}
