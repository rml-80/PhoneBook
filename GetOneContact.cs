using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PhoneBook
{
    static class GetOneContact
    {
        public static void PrintOneContact(int id, PhoneBookList pbl)
        {
            Person person = pbl.BookList.FirstOrDefault(p => p.ID == id);
            Console.WriteLine($"ID: {person.ID}\t Name: {person.Name}\t Phone: {person.Phone}");

        }
    }
}
