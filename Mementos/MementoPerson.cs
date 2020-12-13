namespace PhoneBook
{
    public class MementoPerson : Person
    {
        public MementoPerson(int id, string name, string phone, string action)
        {
            ID = id;
            Name = name;
            Phone = phone;
            Action = action;
        }
        public string Action { get; set; }
        public MementoPerson SaveChange()
        {
            return new MementoPerson(this.ID, this.Name, this.Phone, this.Action);
        }
    }
}
