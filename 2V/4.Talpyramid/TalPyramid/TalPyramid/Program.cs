//Marcus Forsberg TE16

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TalPyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            string x = Console.ReadLine();  //Tar in en input
            for (int i = 0; i < 9; i++) //Lopar allt nedanför 9 ggr
            {
                for (int j = 0; j < i; j++) //Lopar denanstående kod beroende på vilket varv den ovanståående lopen är på
                {
                    Console.Write(x); // Skriv ut x
                }
                Console.Write("\n");//Hoppar till nästa rad
            }
            Console.ReadLine();//Så att programet inte stänger av sig själv direkt efter all kod har körts
        }
    }
}
