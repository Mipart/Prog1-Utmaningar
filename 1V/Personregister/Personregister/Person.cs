using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Person
    {
        private string name, town;
        private int age;

        public Person(string _name, int _age,string _town)
        {
            name = _name;
            town = _town;
            age = _age;
        }

        public void printInfo()
        {
            Console.Write($"\nNamn: {name}\nÅlder: {age}\nStad: {town}\n\n");
        }

        public string GetName()
        {
            return name;
        }
    }
}
