using System;
using System.Linq;

namespace PhoneBook
{
    class MainApp
    {

        static void Main()
        {
            PhoneBookList pbl = new PhoneBookList();
            bool loop = true;
            while (loop)
            {

                Console.WriteLine($"\n-----------Menu-----------");
                Console.WriteLine($"1. Show all contacts");
                Console.WriteLine($"2. Show contact by ID");
                Console.WriteLine($"3. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        GetAllContacts.PrintAllContacts(pbl);
                        break;
                    case 2:
                        Console.Write($"Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        Console.Clear();
                        GetOneContact.PrintOneContact(id, pbl);
                        break;
                    default:
                        loop = false;
                        break;
                }
            }
        }
    }
}