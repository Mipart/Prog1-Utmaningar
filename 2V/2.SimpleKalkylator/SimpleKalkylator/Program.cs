using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleKalkylator
{
    class Program
    {
        static int tal1, tal2; //Declarerar två variabler utav typen int, Dessa kommer att senare användas till att föra in värden till addition,subtraktion eller multiplikation

        static void Main(string[] args)
        {
            Console.Write("Simple Kalkylator\nVälj Räknesätt du vill använda"); //skriv ut text i consolen
            while (true)
            {
                int value = VäljRäknesätt(); //Tar in det värde som användaren angav

                if (Input())    //Ifall att det gick att konvertera så kan man fortsätta 
                {
                    switch (value)
                    {
                        case 1:
                            Addition();
                            break;
                        case 2:
                            Subtraktion();
                            break;
                        case 3:
                            Multiplikation();
                            break;
                        default:
                            Console.WriteLine("Felaktigt Input");
                            break;
                    }
                }
            }
        }

        static int VäljRäknesätt()
        {
            Console.Write("\n1.Addition\n2.Subtraktion\n3.Multiplikation\nDitt val: ");
            string input = Console.ReadLine();                           //Tar in en input i form utav string

            int value = 0;                                               //Declarerar en integer för senare använding. sätter den till noll för att ifall användaren anger en felaktig input faller den utanför switch-satsen.
            bool r = int.TryParse(input, out value);                     //Om det går att konverterar stringen till int, så gör det, annars förblir int variabeln noll

            return value;                                               //Returnerar value
        }

        static bool Input()
        {
            Console.Write("Tal 1 : ");      
            string input1 = Console.ReadLine(); //Tar in input

            Console.Write("Tal 2 : ");
            string input2 = Console.ReadLine(); //tar in Input

            //Konvertera strings till int
            bool r1 = int.TryParse(input1, out tal1);
            bool r2 = int.TryParse(input2, out tal2);

            bool r = r1 & r2;   //Sätter ihop resultaten för att se om det gick att konvertera string till int
            return r;   //Reutrnerar r
        }

        //De olika logik metoderna
        static void Addition()
        {
            int r = tal1 + tal2;    //Anger ett resultat
            Console.WriteLine(tal1 + " + " + tal2 + " är lika med : " + r); //Skriver ut resultatet 
        }

        static void Subtraktion()
        {
            int r = tal1 - tal2; //Anger ett resultat
            Console.WriteLine(tal1 + " - " + tal2 + " är lika med : " + r); //Skriver ut resultatet 
        }

        static void Multiplikation()
        {
            int r = tal1 * tal2; //Anger ett resultat
            Console.WriteLine(tal1 + " * " + tal2 + " är lika med : " + r); //Skriver ut resultatet 
        }
    }
}
