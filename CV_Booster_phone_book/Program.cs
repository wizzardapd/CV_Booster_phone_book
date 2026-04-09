using CV_Booster_phone_book;
using System.Xml.Serialization;
using static CV_Booster_phone_book.ContactService;
using static CV_Booster_phone_book.ContactCard;


ContactService contactService = new ContactService();
var exit = false;

do
{
    Console.WriteLine("CV_booster_phone_book " +
    "\n  " +
    "\n main menu " +
    "\n 1. add contact " +
    "\n 2. delete contact " +
    "\n 3. update contact " +
    "\n 4. show contacts " +
    "\n 5. search contact " +
    "\n 6. export contacts  " +
    "\n 7. exit");

    int keyInfo = int.Parse(Console.ReadLine());

    switch (keyInfo)
    {
        // ask for required data, string name, phone, address, email and note. Creates new object of class ContactCard. 
        // Uses AddContact Method to save the new object in a List<ContactCard>
        case 1:

            if (keyInfo == 0)
            {
                Console.WriteLine("User input is not correct.");
            }
            Console.Write("Name: ");
            string name = Console.ReadLine();

            Console.Write("Phone: ");
            string phone = Console.ReadLine();

            Console.Write("Address: ");
            string address = Console.ReadLine();

            Console.Write("Email: ");
            string email = Console.ReadLine();

            Console.Write("Note: ");
            string note = Console.ReadLine();

            ContactCard newContact = new ContactCard(name, phone, address, email, note);

            contactService.AddContact(newContact);
            break;

        case 2:
            contactService.DeleteContact();
            break;

        case 3:
            contactService.UpdateContact();
            break;

        case 4:

            var contacts = contactService.GetAllContacts();

            if (contacts.Count == 0)
            {
                Console.WriteLine("No contacts found.");
            }

            else
            {
                foreach (var contact in contacts)
                {
                    Console.WriteLine(contact);
                }
            }
            break;

        case 5:
            contactService.SearchContact();
            break;

        case 6:
            contactService.Export();
            break;

        case 7:
            exit = true;
            break;

        default:
            break;

    }
}

while (exit == false);
