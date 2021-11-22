namespace PhoneBook
{
    public class Program
    {
        public static void Main(string[] args)
        {
            string userInput = "";
            var phoneBook = new PhoneBook();

            while(userInput != "6")
            {
                Console.WriteLine("###############################");
                Console.WriteLine("<<<<<<<<MENU>>>>>>>>");
                Console.WriteLine("1. Add new contact");
                Console.WriteLine("2. Display all contacts");
                Console.WriteLine("3. Display contact by name");
                Console.WriteLine("4. Display contact by number");
                Console.WriteLine("5. Remove contact by name");
                Console.WriteLine("6. Exit ");
                Console.WriteLine("###############################");

                userInput = Console.ReadLine();

                switch (userInput)
                {
                    case "1":
                        Console.WriteLine("Enter New Contact Name: ");
                        var name = Console.ReadLine();
                        Console.WriteLine("Enter New Contact Number: ");
                        var number = Console.ReadLine();
                        Contact contact = new Contact(name, number);
                        phoneBook.AddContact(contact);
                        break;
                    case "2":
                        phoneBook.DisplayAllContacts();
                        break;
                    case "3":
                        Console.WriteLine("Enter contact name to find: ");
                        userInput= Console.ReadLine();
                        phoneBook.DisplayContactsByName(userInput);
                        break;
                    case "4":
                        Console.WriteLine("Enter contact number to find: ");
                        userInput = Console.ReadLine();
                        phoneBook.InputValidationName(userInput);
                        phoneBook.DisplayContactsByNumber(userInput);
                        break;
                    case "5":
                        Console.WriteLine("Enter contact name to remove: ");
                        var removeContact = Console.ReadLine();
                        phoneBook.InputValidationName(userInput);
                        phoneBook.RemoveContactByName(removeContact);
                        break;
                    case "6":
                        Console.WriteLine("Bye, Bye!");
                        return;
                    default:
                        Console.WriteLine("Enter numbers (1-6) to choose operation");
                        break;
                }
            }
        }
    }
}
  

