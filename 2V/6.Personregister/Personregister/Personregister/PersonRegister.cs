using System;
using System.Collections.Generic;

namespace Personregister
{
    class PersonRegister
    {
        List<Person> personList = new List<Person>(); //Skapar en ny lista med objectet Person


        public PersonRegister()
        {
            AddPerson("joakim", 20, "Vasteras");
            AddPerson("kim", 22, "Vasteras");
            AddPerson("sophi", 10, "Vasteras");
        }

        public void AddPerson(string name,int age,string town)
        {
            Person newPerson = new Person(name, age, town); //Skapar en ny person
            personList.Add(newPerson); // Lägger till den nya personen i listan
        }

        public Person ReturnPerson(string name)
        {
            foreach (Person item in personList) //Går igenom listan, 
            {
                if(item.Name == name) //försöker finna en person med ett liknande namn som användaren angav
                {
                    return item; //Om man finner en person med samma namn, så returnera den personen
                }
            }
            return null; //Annars returnera null
        }

        public List<String> ReturnNameList()
        {
            List<String> nameList = new List<string>();
            foreach (Person item in personList) //Gör om personListan till en lista med enbart namn
            {
                nameList.Add(item.Name);
            }
            return nameList; //Returnerar hela personListan
        }
    }
}
