using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subways
{
    class subway
    {
        string subwayNumber;

        public void setup(string subwayNumber)
        {
            this.subwayNumber = subwayNumber; //Ger subwaynumber ett värde
        }

        public void printSubwayShoutout()
        {
            Console.WriteLine($"Welcome to Subwaystation {subwayNumber}"); //Skriver ut subwaynumber
        }

        //Försöker att konvertera string till int, för att använda för menyer
        public int ConvertToInt(string i)
        {
            int r = -1; //Default till -1, då -1 inte kommer att användas i meny som ett val.
            int.TryParse(i, out r);  //Testar konvertera input, om det lyckas så ge r det värde som angets.
            return r; // Returnera r
        }

        //Konvertera string till boolean, true kommer att vara standard
        public bool ConvertToBoolean(string i)
        {
            i = i.ToLower(); //gör så att all input blir till lowercase
            if(i == "n") //testar om inputen är n, omså returnera false
            {
                return false;
                
            }
            else {
                return true;
            }
        }

        //Skriv ut en textrad och fråga användaren om hen vill gå ombord på tåget
        public bool BoardTrain()
        {
            Console.Write("Board the train Y/n : ");
            string s = Console.ReadLine();
            return ConvertToBoolean(s);
        }

        public void PressEnter()
        {
            Console.WriteLine("You are now leaving subway "+ subwayNumber);
            Console.WriteLine("Press Enter to continue");
            Console.ReadLine();
        }
        public void BoardTrainSelector(int i) 
        {
            //Öppna vägar till de olika classerna one two eller three, beroende på inputen
            switch (i)
            {
                case 1:
                    PressEnter();
                    new subwayOne();
                    break;
                case 2:
                    PressEnter();
                    new subwayTwo();
                    break;
                case 3:
                    PressEnter();
                    new subwayThree();
                    break;
                case 4:
                    PressEnter();
                    break;
                    //Exit
                default:
                    Console.WriteLine("!ERROR! : Stationen finns inte");
                    break;
            }
        }
    }
}
