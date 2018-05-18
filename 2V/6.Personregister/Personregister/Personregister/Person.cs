namespace Personregister
{
    class Person
    {
        string name;
        int age;
        string town;



        public Person(string name, int age, string town) //Constructorn, När en ny person skapas, behöver man skriva in namn ålder och stad.
        {
            this.name = name; //Ger instanc variabeln värdet utav det intagna name
            this.age = age;
            this.town = town;
        }

        public Person ReturnPerson() //Returnerar en person, kan kallas utifrån denna class
        {
            Person person = new Person(name, age, town); //Skapar en ny person utav med samma värden som denna person har
            return person;
        }

        public string Name { //Gör det möjligta att enbart hämta namnet, Detta gör så att det inte går att redigera namnet utifrån scriptet
            get
            {
                return name;
            }
        }

        public float Age
        {
            get
            {
                return age;
            }
        }

        public string Town
        {
            get
            {
                return town;
            }
        }

    }
}
