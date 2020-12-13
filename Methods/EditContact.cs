using System;

namespace PhoneBook
{
    class EditContact : IEditContact
    {
        GetOneContact getOneContact = new GetOneContact();
        public void Edit(int id, PhoneBookList pbl, CareTaker careTaker)
        {
            getOneContact.PrintOneContact(id,pbl);
            Console.WriteLine($"What do you want to edit?");
            Console.WriteLine($"1. Name");
            Console.WriteLine($"2. Phone");
            Console.WriteLine($"3. Cancel");

            int idx = pbl.BookList.FindIndex(j => j.ID == id);
            var Action = "modified";

            MementoPerson mementoPerson = new MementoPerson(pbl.BookList[idx].ID, pbl.BookList[idx].Name, pbl.BookList[idx].Phone, Action);
            careTaker.Undo = mementoPerson.SaveChange();
            careTaker.AddUndo(careTaker.Undo);

            var choise = Convert.ToInt32(Console.ReadLine());

            switch (choise)
            {
                case 1:
                    Console.Write($"New name:");
                    pbl.BookList[idx].Name = Console.ReadLine();
                    break;
                case 2:
                    Console.Write($"New phone:");
                    pbl.BookList[idx].Phone = Console.ReadLine();

                    break;
                default:
                    break;
            }
        }
    }
}
