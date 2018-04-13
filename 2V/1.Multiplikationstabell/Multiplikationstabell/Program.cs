//Marcus Forsberg TE16

using System;

namespace Multiplikationstabell
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Multiplikationstabeller\nSkriv in ett valfritt heltal: "); //Skriv ut en text i konsolen
            string input = Console.ReadLine(); //Ta in ett värde i form utav string

            int workedInput;        //Declarerar en variable
            bool value = int.TryParse(input, out workedInput); //Försöker att konvertera string till int
            if (value)  //Tittar om man lyckades konvertera från string till int
            {
                WriteBlankLine();   //Anropar metoden WriteBlankLine
                for (int i = 0; i < 11; i++) //Itererar nedanstående kod tio ggr
                {
                    Console.WriteLine(workedInput + " gånger " + i + " är lika med " + (workedInput * i)); // Skriver ut en rad med text
                }
                WriteBlankLine();
            }

            Console.ReadLine(); //Så att programet inte stängs av direkt efter att all kod har körts

        }

        static void WriteBlankLine()    //Skapar en metod
        {
            Console.WriteLine("---------------------"); //Skriver ut en rad med text varje gång metoden anropas
        }
    }
}
