using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Personregister
{
    class Logik
    {
        PersonRegister theRegister = new PersonRegister();
        //Börja här!
        public Logik()
        {
            Menu();
        }

        //Skriver ut de olika menyvalen
        void Menu()
        {
            Console.Write("Tryck 1 för att se personregistret\nTryck 2 för att lägga till en person i listan\nSkriv ett namn för att få läsa mer om det\nSkriv 'Meny' för att öppna menyn\nSkriv 0 för att avsluta.");
            UserMenuChoice();
        }

        //Kalla på den eftersökta metoden, skriva / läsa från registret.
        void UserMenuChoice()
        {
            Console.Write("\nDitt val: ");

            //Kollar om användaren ger ett giltigt input, om inte, gör om allt.
            //Se först om inputen är "meny" om så strunta i att parsa till en int
            string userInput = Console.ReadLine();
            int userChoice;
            bool result = int.TryParse(userInput, out userChoice);
            if (!result)
            {
                //Sätter värdet utanför rangen för att hamna på defualt i switch satsen.
                userChoice = 5;
            }
            switch (userChoice)
            {
                case 1:
                    //Läs upp alla personer ur listan
                    theRegister.PrintRegister();
                    UserMenuChoice();
                    break;
                case 2:
                    //Skriv in en ny person i listan
                    AddPerson();
                    UserMenuChoice();
                    break;
                case 0:
                    //Stäng ner programet
                    break;
                default:
                    //Ett sätta att städa upp consolen
                    if(userInput == "clear!")
                    {
                        Console.Clear();
                    }

                    //Printa infon om personen med det här namnet.
                    theRegister.GetPersonIdentety(userInput);
                    Menu();
                    break;

            }
        } 

        void AddPerson()
        {
            //Skaffa data för en ny person
            
            Console.Write("Namn: ");
            string name = Console.ReadLine();
            Console.Write("Ålder: ");
            int age = 0;
            bool ret = int.TryParse(Console.ReadLine(), out age);
            Console.Write("Stad: ");
            string town = Console.ReadLine();
            theRegister.AddPerson(name, age, town);

        }
    }
}
