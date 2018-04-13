using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class SubwayTwo
    {
        //Importerar logik
        Logik logik = new Logik("Two");
        public SubwayTwo()
        {
            logik.Speakers();
            //Ger användaren ett val, kör kod baserat på vad användaren anger.
            switch(logik.BoardMultipleTrain("One", "Three"))
            {
                case 1:
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    new SubwayOne();
                    break;
                case 2:
                    Console.WriteLine("Press enter to continue...");
                    Console.ReadLine();
                    new SubwayThree();
                    break;
                case 3:
                    Console.WriteLine("You left the subwaystation");
                    break;
                default:
                    //Om användaren anger något konstigt, gör om allt igen!
                    new SubwayTwo();
                    break;
            }
        }
    }
}
