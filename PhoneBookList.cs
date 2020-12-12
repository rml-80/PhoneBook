using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook
{
    public class PhoneBookList
    {
        //Create a List and populate it with random data
        public List<Person> BookList = new List<Person>()
        {
            new Person() { ID = 1,Name = "Test 1", Phone = "202-555-1242" },
            new Person() { ID = 2,Name = "Test 2", Phone = "202-555-1392" },
            new Person() { ID = 3,Name = "Test 3", Phone = "202-555-1278" },
            new Person() { ID = 4,Name = "Test 4", Phone = "202-545-1879" },
            new Person() { ID = 5,Name = "Test 5", Phone = "202-444-7242" },
            new Person() { ID = 6,Name = "Test 6", Phone = "202-445-1299" },
            new Person() { ID = 7,Name = "Test 7", Phone = "202-557-1942" },
            new Person() { ID = 8,Name = "Test 8", Phone = "202-525-9742" },
            new Person() { ID = 9,Name = "Test 9", Phone = "202-665-3242" },
            new Person() { ID = 10,Name = "Test 10", Phone = "202-325-1872" }
        };
    }
}
