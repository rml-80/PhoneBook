using System;

namespace PhoneBook
{
    public class DeleteContact : IDeleteContact
    {
        public void Delete(PhoneBookList pbl, CareTaker careTaker)
        {
            Person p = new Person();
            Console.Write($"Which contact do you want to delete? ");
            var idToDelete = Convert.ToInt32(Console.ReadLine());
            var idx = pbl.BookList.FindIndex(i => i.ID == idToDelete);

            p.ID = pbl.BookList[idx].ID;
            p.Name = pbl.BookList[idx].Name;
            p.Phone = pbl.BookList[idx].Phone;

            var Action = "delete";

            MementoPerson mementoPerson = new MementoPerson(p.ID, p.Name, p.Phone, Action);
            careTaker.Undo = mementoPerson.SaveChange();
            careTaker.AddUndo(careTaker.Undo);

            pbl.BookList.RemoveAt(idx);
        }
    }
}
