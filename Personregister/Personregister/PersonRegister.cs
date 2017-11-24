using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class PersonRegister
    {
        private List<Person> theRegister = new List<Person>();

        public void AddPerson(string name, int age, string town)
        {
            theRegister.Add(new Person(name, age, town));
        }

        //Skriv ut registret
        public void PrintRegister()
        {
            //Läs in varje person och skriv ut deras namn.
            foreach (Person item in theRegister)
            {
                Console.WriteLine(item.GetName());
            }
        }

        //Få info om en specifik person
        public void GetPersonIdentety(string _name)
        {
            foreach (Person per in theRegister)
            {
                if(per.GetName() == _name)
                {
                    per.printInfo();
                }
            }
        }

    }
}
