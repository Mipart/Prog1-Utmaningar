namespace PersonRegister_Form_
{
    class Person
    {
        string name;
        byte age;
        string town;

        public Person(string _name, string _town, byte _age)
        {
            name = _name;
            town = _town;
            age = _age;
        }

        public string GetName()
        {
            return name;
        }

        public string GetAge()
        {
            return age.ToString();
        }

        public string GetTown()
        {
            return town;
        }
    }
}
