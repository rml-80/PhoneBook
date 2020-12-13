using System;
using System.Linq;

namespace PhoneBook
{
    public class GetOneContact : IGetOneContact
    {
        public void PrintOneContact(int id, PhoneBookList pbl)
        {
            Person person = pbl.BookList.FirstOrDefault(p => p.ID == id);
            //Console.Clear();
            Console.WriteLine($"ID: {person.ID}\t Name: {person.Name}\t Phone: {person.Phone}");
        }
    }
}
