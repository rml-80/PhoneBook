using System.Collections.Generic;

namespace PhoneBook
{
    public class PhoneBookList
    {
        //Create a List and populate it with random data
        public List<Person> BookList = new List<Person>()
        {
            new Person() { ID = 1,Name = "Zakir Piper", Phone = "202-555-1242" },
            new Person() { ID = 10,Name = "Tonicha Alston", Phone = "202-555-1392" },
            new Person() { ID = 3,Name = "Connar Lancaster", Phone = "202-555-1278" },
            new Person() { ID = 4,Name = "Pranav Short", Phone = "202-545-1879" },
            new Person() { ID = 2,Name = "Herbert Espinosa", Phone = "202-444-7242" },
            new Person() { ID = 6,Name = "Lilly-May Hanson", Phone = "202-445-1299" },
            new Person() { ID = 9,Name = "Dexter Hancock", Phone = "202-557-1942" },
            new Person() { ID = 8,Name = "Layton Zhang", Phone = "202-525-9742" },
            new Person() { ID = 7,Name = "Allan Lord", Phone = "202-665-3242" },
            new Person() { ID = 5,Name = "Remi Dillon", Phone = "202-325-1872" }
        };
    }
}
