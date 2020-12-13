using System;

namespace PhoneBook
{
    public class GetAllContacts : IGetAllContacts
    {
        public void PrintAllContactsByID(PhoneBookList pbl)
        {
            pbl.BookList.Sort((x, y) => x.ID.CompareTo(y.ID));
            PrintList(pbl);
        }
        public void PrintAllContactsByName(PhoneBookList pbl)
        {
            pbl.BookList.Sort((x, y) => x.Name.CompareTo(y.Name));
            PrintList(pbl);
        }
        public void PrintList(PhoneBookList pbl)
        {
            foreach (Person item in pbl.BookList)
            {
                Console.WriteLine($"ID: {item.ID}\t Name: {item.Name}\t Phone: {item.Phone}");
            }
        }
    }
}
