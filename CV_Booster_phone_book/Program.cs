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
        case 1:
            contactService.AddContact();
            break;

        case 2:
            contactService.DeleteContact();
            break;

        case 3:
            contactService.UpdateContact();
            break;

        case 4:
            contactService.GetAllContacts();
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
