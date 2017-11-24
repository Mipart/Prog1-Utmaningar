using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Subway
{
    class Logik
    {
        string subwayNum;
        //Tar in en SubwayNum för att senare kunna ropa ut "Welcome to subway..." där
        // "..." är det nummer på stationen
        public Logik(string _subwayNum)
        {
            subwayNum = _subwayNum;
        }

        //Ropa ut vilken station man är på
        public void Speakers()
        {
            Console.WriteLine($"Speakers: Welcome to Subwaystation ¨{subwayNum}¨");
        }

        //Logik för en station med flera val av tåg.
        //Tar in de tåg som man kan ta.
        public int BoardMultipleTrain(string stationOOne, string stationOTwo)
        {
            int myOutInt;
            Console.Write($"You see two trains...\nGo to subway {stationOOne} : 1\nGo to subway {stationOTwo} : 2\nLeave the subway : 3\nYour Choice : ");
            //Behöver inte spara ner boolean värdet, för att om användaren anger ett felaktig input så kommer returvärdet att vara noll
            //Vilket då den Subwayen behandlar.
            int.TryParse(Console.ReadLine(), out myOutInt);
            return myOutInt;
        }

        //Logik för att gå på ett tåg.
        //Användaren kan bara ange Y eller N
        public byte BoardTrain()
        {
            Console.Write("Board the train? y/n : ");
            string userInput = Console.ReadLine().ToLower();
            if (userInput == "y")
            {
                return 1;
            }else if(userInput == "n")
            {
                return 0;
            }

            //Om användaren angav något annat än y/n returnera något konstigt så att man hamnar i default(I switch satsen)
            return 3;
            
        }
    }
}
