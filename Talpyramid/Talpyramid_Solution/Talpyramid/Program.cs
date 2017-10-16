using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Talpyramid
{
    class Program
    {
        static void Main(string[] args)
        {
            int userNumInput = UserInput(Console.ReadLine());

            for (int i = 0; i < userNumInput; i++)
            {
                for (int j = 0; j < i; j++)
                {
                    Console.Write(userNumInput);

                }
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        static int UserInput(string _userInput)
        {
            int userInput = 0;

            bool validInput = int.TryParse(_userInput, out userInput);
            if(!validInput)
            {
                Console.Write("Felaktig input \nSkriv ett tal: ");
                return UserInput(Console.ReadLine());
            }
            return userInput;
        }
    }
}
