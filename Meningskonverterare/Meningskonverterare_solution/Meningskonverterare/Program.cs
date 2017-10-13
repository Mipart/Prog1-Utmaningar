using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meningskonverterare
{
    //Marcus Forsberg TE16
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Meningskonverterare av Marcus Forsberg \nVälj 1 för att konvertera till stora bokstäver.\nVälj 2 för att konvertera till små bokstäver.\nDitt val: ");

            //Välj vilken process som ska köras med hjälp utav Switch satsen
            int userChoice = UserNumInput(Console.ReadLine(), 2);

            //tar en input till mening, meningen ska konverteras till det användaren valde.
            Console.Write("Din mening: ");
            string userSentence = Console.ReadLine();

            //Använder switch satsen för vilken process som användaren tidigare valde
            switch(userChoice)
            {
                case 1:
                    Console.WriteLine("Konverterad mening: "+userSentence.ToUpper());
                    break;
                case 2:
                    Console.WriteLine("Konverterad mening: " + userSentence.ToLower());
                    break;
            }

            //Har för att programet inte ska stänga av sig själv
            Console.ReadLine();
        }

        //Har en metod för att se om inputen var giltig
        static int UserNumInput(string _stringInput, int _numOfAlternatives)
        {
            //Använder mig utav int.TryParse
            int userChoice = 0;
            bool correctInput = int.TryParse(_stringInput, out userChoice);

            //Om inputen inte överenstämer med de kriterierna som behövs, så körs denna metod en gång till.
            if(!correctInput || userChoice > _numOfAlternatives || userChoice <= 0)
            {
                Console.Write("\n Felaktigt input! \nGe ett nytt värde: ");
                return UserNumInput(Console.ReadLine() ,_numOfAlternatives);
            }

            //Returnerar ett värde som kan användas till switch satsen som bestämmer om man ska 
            //förstora alla bokstäver eller om man ska förminska alla bokstäver
            return userChoice;
        }
    }
}
