using System;

namespace PhoneBook
{
    class MainApp
    {
        static void Main()
        {
            GetAllContacts getAllContacts = new GetAllContacts();
            GetOneContact getOneContact = new GetOneContact();
            AddNewContact addNewContact = new AddNewContact();
            DeleteContact deleteContact = new DeleteContact();
            EditContact editContact = new EditContact();
            PhoneBookList pbl = new PhoneBookList();
            CareTaker careTaker = new CareTaker();
            bool loop = true;
            while (loop)
            {
                Console.WriteLine($"\n-----------Menu-----------");
                Console.WriteLine($"1. Show all contacts (sorted by ID)");
                Console.WriteLine($"2. Show all contacts (sorted by Name)");
                Console.WriteLine($"3. Show contact by ID");
                Console.WriteLine($"4. Edit contact");
                Console.WriteLine($"5. Add new contact");
                Console.WriteLine($"6. Delete contact");
                if (careTaker.UndoStack.Count >= 1)
                {
                    Console.WriteLine($"7. Undo changes");
                }if (careTaker.RedoStack.Count >= 1)
                {
                    Console.WriteLine($"8. Redo changes");
                }
                Console.WriteLine($"0. Exit");

                int choice = Convert.ToInt32(Console.ReadLine());
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        getAllContacts.PrintAllContactsByID(pbl);
                        break;
                    case 2:
                        //Console.Clear();
                        getAllContacts.PrintAllContactsByName(pbl);
                        break;
                    case 3:
                        Console.Write($"Enter ID: ");
                        int id = Convert.ToInt32(Console.ReadLine());
                        getOneContact.PrintOneContact(id, pbl);
                        break;
                    case 4:
                        Console.Write($"Enter ID: ");
                        id = Convert.ToInt32(Console.ReadLine());
                        editContact.Edit(id, pbl, careTaker);
                        break;
                    case 5:
                        addNewContact.AddContact(pbl, careTaker);
                        break;
                    case 6:
                        deleteContact.Delete(pbl, careTaker);
                        break;
                    case 7:
                        careTaker.MakeUndo(pbl);
                        break;
                    case 8:
                        careTaker.MakeRedo(pbl);
                        break;
                    default:
                        loop = false;
                        break;
                }
            }
        }
    }
}