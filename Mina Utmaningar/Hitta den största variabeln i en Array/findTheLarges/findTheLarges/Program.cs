using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace findTheLarges
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] myArray = new int[5]{20,2,3,4,5};


            //Hittar det största värdet i arrayen
            //Sedan för det värdet vidare till en variabel
            int largestNum = 0;
            foreach (int myInt in myArray)
            {
                if (myInt > largestNum)
                    largestNum = myInt;
            }

            //Hittar positionen för Value
            int count = 0;
            foreach (int myInt in myArray)
            {
                if(myInt != largestNum)
                {
                        count++;
                }
                    else
                    {
                        break;
                    }
            }

            //Ger en output för användaren.
            Console.WriteLine("The largest position in the array has an value of : " + largestNum);
            Console.WriteLine("The position of the largest value is : " + count);
            Console.ReadLine();
        }
    }
}
