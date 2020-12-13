using System;
using System.Linq;

namespace PhoneBook
{
    class AddNewContact : IAddNewContact
    {
        public void AddContact(PhoneBookList pbl, CareTaker careTaker)
        {
            var i = pbl.BookList.Max(t => t.ID)+1;

            Person p = new Person();

            Console.Clear();
            p.ID = i;     //Needs to be modyfied

            Console.Write($"Name: ");
            p.Name = Console.ReadLine();
            Console.Write($"Phone: ");
            p.Phone = Console.ReadLine();

            pbl.BookList.Add(p);
            var Action = "add";

            MementoPerson mementoPerson = new MementoPerson(p.ID, p.Name, p.Phone, Action);
            careTaker.Undo = mementoPerson.SaveChange();
            careTaker.AddUndo(careTaker.Undo);
        }
    }
}
