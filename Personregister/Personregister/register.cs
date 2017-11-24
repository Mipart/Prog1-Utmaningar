using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class register
    {
        List<person> listOfPerson = new List<person>();

        //Konstruktor
        public register()
        {

        }

        public void AddPerson()
        {

        }

        public void ReadList()
        {
            foreach (person person in listOfPerson)
            {
                person.GetName();
            }
        }
    }
}
