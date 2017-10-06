using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MultiplikationsTabel
{
    class Program
    {
        static void Main(string[] args)
        {
            //Har allt i en oändlig While loop för att enkelt kunna 
            //göra en ny tabell utan att behöva start upp programet igen
            while (true)
            {
                Console.WriteLine("Multiplikationstabeller");
                Console.WriteLine();
                Console.Write("Skriv in ett valfritt heltal : ");
                int userInput = UserInput();

                Console.WriteLine("----------------------------------");

                //Skriver ut tabellen
                for (int i = 0; i < 11; i++)
                {
                    Console.WriteLine(userInput+" gånger "+i+" är lika med: "+(userInput*i));
                }

                Console.WriteLine("----------------------------------");

                //Mekanismen för att göra en "stilig" övergång till en ny tabell
                Console.WriteLine("Tryck Enter för att använda ett annat nummer");
                Console.ReadLine();
                Console.Clear();
            }
        }

        //UserInput används för att enkelt och snyggt se om användaren angav ett giltigt input.
        static int UserInput()
        {
            string _userInput = Console.ReadLine();

            int _num = 0;
            bool _validNum = int.TryParse(_userInput, out _num);
            if(_validNum)
            {
                return _num;
            }
            else
            {
                Console.WriteLine("Ogiltig input");
                Console.WriteLine();
                Console.Write("Skriv in ett valfritt heltal : ");
                return UserInput();
            }
        }
    }
}
