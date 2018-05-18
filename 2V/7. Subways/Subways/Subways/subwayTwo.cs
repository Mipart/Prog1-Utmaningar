using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subways
{
    class subwayTwo : subway
    {
        public subwayTwo()
        {
            setup("Two");
            printSubwayShoutout();

            Console.WriteLine("You see two trains...");
            Console.WriteLine("Go to Subwaystation One : 1\nGo to Subwaystation Three : 2\nExit subway : 3");

            bool b = false; //Kontroll variabel
            do
            {
                Console.Write("Your choice: ");
                b = false;
                switch (ConvertToInt(Console.ReadLine()))
                {
                    case 1:
                        BoardTrainSelector(1);
                        break;
                    case 2:
                        BoardTrainSelector(3);
                        break;
                    case 3:
                        BoardTrainSelector(4);
                        break;
                    default:
                        Console.WriteLine("Can not read input, try again");
                        b = true;
                        PressEnter();
                        break;
                }
            } while (b);
        }
    }
}
