using System.Collections.Generic;

namespace PersonRegister_Form_
{
    class Register
    {
        List<Person> theList = new List<Person>();

        public void AddPerson(string name, string town, byte age)
        {
            theList.Add(new Person(name, town, age));
        }

        public List<Person> GetList()
        {
            return theList;
        }
    }
}
