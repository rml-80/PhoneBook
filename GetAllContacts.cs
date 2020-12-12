using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    static class GetAllContacts
    {
        public static void PrintAllContacts(PhoneBookList pbl)
        {
            foreach (Person item in pbl.BookList)
            {
                Console.WriteLine($"ID: {item.ID}\t Name: {item.Name}\t Phone: {item.Phone}");
            }
        }
    }
}
