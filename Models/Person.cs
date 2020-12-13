namespace PhoneBook
{
    public class Person
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }

        public void SavePerson(int id, string name, string phone)
        {
            ID = id;
            Name = name;
            Phone = phone;
        }
    }
}
