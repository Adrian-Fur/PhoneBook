namespace PhoneBook
{
    public class PhoneBook
    {
        public List<Contact> Contacts { get; set; } = new List<Contact>();

        public void AddContact(Contact contact)
        {
            if(InputValidationName(contact.Name) && InputValidationNumber(contact.Number))
            {
                Console.Clear();
                Contacts.Add(contact);
                Console.WriteLine("Contact Added\n");
            }
            else
            {
                Console.WriteLine("Name should contain at least 3 letters and Number should contain at least 9 numbers\n");
            }
        }

        public void DisplayAllContacts()
        {
            Console.Clear();
            if(Contacts.Count == 0)
            {
                Console.WriteLine("Phonebook is empty\n");
            }
            else
            {
                foreach (Contact contact in Contacts)
                {
                    Console.WriteLine($"Name: {contact.Name}");
                    Console.WriteLine($"Number: {contact.Number}\n");
                }
            }
        }

        public void DisplayContactsByNumber(string number)
        {
            Console.Clear();
            if (InputValidationNumber(number))
            {
                var contact = Contacts.FirstOrDefault(n => n.Number == number);

                Console.WriteLine($"Name: {contact.Name}");
                Console.WriteLine($"Number: {contact.Number}\n");
            }
            else
            {
                Console.WriteLine("Number should contain at least 9 numbers\n");
            }
        }

        public void DisplayContactsByName(string name)
        {
            Console.Clear();
            if (InputValidationName(name))
            {
                List<Contact> nameSearch = Contacts.Where(n => n.Name == name).ToList();

                foreach (Contact contact in nameSearch)
                {
                    Console.WriteLine($"Name: {contact.Name}");
                    Console.WriteLine($"Number: {contact.Number}\n");
                }
            }
            else
            {
                Console.WriteLine("Name should contain at least 3 letters\n");
            }

        }
        public void RemoveContactByName(string name)
        {
            Console.Clear();
            if (InputValidationName(name))
            {
                var contact = Contacts.FirstOrDefault(n => n.Name == name);

                Contacts.Remove(contact);
                Console.WriteLine("Contact Removed\n");
            }
            else
            {
                Console.WriteLine("Name should contain at least 3 letters\n");
            }

        }
        public bool InputValidationName(string input)
        {
           if(input.Length < 3)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool InputValidationNumber(string input)
        {
            if (input.Length < 9)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
    }
}

