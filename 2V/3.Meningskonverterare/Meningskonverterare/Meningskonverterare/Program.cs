//Marcus Forsberg TE16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Meningskonverterare
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Meningskonverterare!\nDin sträng: ");
            string conString = Console.ReadLine();

            switch (Val())  //Gör valet, beroende på vad användaren angav så kommer olika funktioner kallas.
            {
                case 1: //Allt innanför denna kommer att bli kallade på enbart om valet var 1
                    Console.WriteLine(conSmallToLarge(conString));
                    break;
                case 2: //Allt innanför denna kommer att bli kallade på enbart om valet var 2
                    Console.WriteLine(conLargeToSmall(conString));
                    break;
                default:    //Om ingen av de ovanstående blivit anropade, så kallas all kod här
                    Console.WriteLine("Felaktig Input!");
                  break;
            }

            Console.ReadLine();
        }

        static int Val()
        {
            Console.Write("Välj 1 för att konvertera till stora bokstäver \nVälj 2 för att konvertera till små bokstäver\nDitt val: "); //Skriver ut en text i konsolen
            int r = 0;  //Deklarerar en variabel med värdet utav 0
            bool result = int.TryParse(Console.ReadLine(), out r); //Försöker konvertera användarens input från en string till en int.

            return r; //Returnerar det konverterade värdet
        }

        static string conSmallToLarge(string input)
        {
            string r = input.ToUpper(); //Konverterar strängen till Uppercase
            return r;   //Returnerar värdet
        }

        static string conLargeToSmall(string input)
        {
            string r = input.ToLower(); //Konverterar strängen till Lowercase
            return r;   //Returnerar värdet
        }


    }
}
