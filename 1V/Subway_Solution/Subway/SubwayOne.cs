using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class SubwayOne
    {
        //Kommer åt den allmäna logiken
        Logik logik = new Logik("One");
        public SubwayOne()
        {
            //Ropa ut "Welcome to...."
            logik.Speakers();
            //Kollar om man vill kliva på nästa tåg
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
                    new SubwayOne();
                    break;
            }
        }
    }
}
