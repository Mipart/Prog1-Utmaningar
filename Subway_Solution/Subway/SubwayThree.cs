using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class SubwayThree
    {
        //Importerar logik
        Logik logik = new Logik("Three");
        public SubwayThree()
        {
            logik.Speakers();
            //Ger användaren ett val, kör kod baserat på val.
            switch (logik.BoardTrain())
            {
                case 0:
                    Console.WriteLine("Exiting the Subway");
                    break;
                case 1:
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    //Går vidare till SubwayTwo
                    new SubwayTwo();
                    break;
                default:
                    Console.WriteLine("You did something wierd\nTry again");
                    new SubwayThree();
                    break;
            }
        }
    }
}
