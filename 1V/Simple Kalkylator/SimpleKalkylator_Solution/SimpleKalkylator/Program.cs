using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleKalkylator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Simpel Kalkylator");
            Console.WriteLine("Välj vilket räknesätt du vill använda");

            start();

        }
        static void start()
        {
            printArithmetic();

            //Använder TryParese för att se om användare anger ett giltigt värde.
            //Om värdet är giltigt forstätt med numValid
            int userChoice;
            bool resultant = int.TryParse(Console.ReadLine(), out userChoice);

            if (!resultant || userChoice > 3)
            {
                Console.WriteLine("Du angav ett ogiltigt svar, tryck enter för att försöka igen");
                Console.ReadLine();
                start();
            }

            numValid(userChoice);
        }

        static void printArithmetic ()
        {
            Console.WriteLine("Räknesätt: ");
            Console.WriteLine("1: Addition");
            Console.WriteLine("2: Subtraktion");
            Console.WriteLine("3: Multiplikation");
        }

        static void numValid (int _userChoice)
        {
            //Testar om tal1 , tal2 får ett giltigt värde.
            Console.WriteLine("Ange ett värde för tal 1.");
            int num1;
            bool resultant1 = int.TryParse(Console.ReadLine(), out num1);
            if (!resultant1)
            {
                Console.WriteLine("Du angav ett ogiltigt värde. Tryck enter för att börja om");
                Console.ReadLine();
                start();
            }

            int num2;
            Console.WriteLine("Ange ett värde för tal 2.");
            bool resultant2 = int.TryParse(Console.ReadLine(), out num2);
            if (!resultant2)
            {
                Console.WriteLine("Du angav ett ogiltigt värde. Tryck enter för att börja om");
                Console.ReadLine();
                start();
            }


            //Bestämmer vilken Metod som ska användas, beroende på vad användare tidigare angav i userChoice
            switch(_userChoice)
            {
                case 1:
                    addition(num1, num2);
                    break;
                case 2:
                    subratction(num1, num2);
                    break;
                case 3:
                    multiplication(num1, num2);
                    break;
            }
        }


        //De olika matematiska metoderna.
        static void addition(int _num1,int _num2)
        {
            int sum = _num1 + _num2;
            Console.WriteLine("svaret blev: "+sum);
            Console.ReadLine();
            Console.Clear();
            start();
        }

        static void subratction(int _num1, int _num2)
        {
            int sum = _num1 - _num2;
            Console.WriteLine("svaret blev: " + sum);
            Console.ReadLine();
            Console.Clear();
            start();
        }
        static void multiplication(int _num1, int _num2)
        {
            int sum = _num1 * _num2;
            Console.WriteLine("svaret blev: " + sum);
            Console.ReadLine();
            Console.Clear();
            start();
        }
    }
}