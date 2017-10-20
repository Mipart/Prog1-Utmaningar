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
            Console.Write("Skriv ett tal: ");
            int userNumInput = UserInput(Console.ReadLine());
            Console.WriteLine();

            //För första loppen är för varje ny linje.
            for (int i = 0; i < userNumInput; i++)
            {
                //Denna loop är för att generara rätt mängd utav ett nummer för just denna linje.
                for (int j = 0; j < i + 1; j++)
                {
                    //Använder Write istället för writeline för att få numrena att hamna på samma rad.
                    Console.Write(userNumInput);
                }
                //Använde CW för att gå ner till nästa rad.
                Console.WriteLine();
            }
            Console.ReadLine();
        }

        //Ser till så att användare bara kan ange ett giltigt input.
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
