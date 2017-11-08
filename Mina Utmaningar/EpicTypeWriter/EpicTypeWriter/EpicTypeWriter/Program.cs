using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EpicTypeWriter
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                StartMenu();
                Console.Write("Pick an Action : ");
                switch (StringToInt(Console.ReadLine()))
                {
                    case 0:
                        Console.Clear();
                        Console.WriteLine("Invalid Input");
                        Console.WriteLine("Press enter to try again");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 1:
                        Console.Clear();
                        Console.Write("char to find: ");
                        char[] charToFind = StringToCharArray(Console.ReadLine());
                        char workedCharToFind = charToFind[0];
                        Console.Write("Input: ");
                        int amountOfChar = FindAmountOfChar(workedCharToFind, Console.ReadLine());

                        Console.Clear();
                        Console.WriteLine($"Found {amountOfChar} of ¨{workedCharToFind}¨ in your Sentence");
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    case 2:
                        Console.Clear();
                        Console.Write("Input: ");
                        PrintWithEpicStyle(Console.ReadLine());
                        Console.ReadLine();
                        Console.Clear();
                        break;
                    default:
                        Console.Clear();
                        break;


                }
            } while (true);
        }

        static void StartMenu()
        {
            Console.WriteLine("Welcome to the ¨Epic Typewriter¨ application \n1. Find an nuber of char\n2. Epic TypeWriter ");
        }

        static int FindAmountOfChar(char _cInput, string _sInput)
        {
            char[] charArray = StringToCharArray(_sInput);
            int counter = 0;
            foreach(char ch in charArray)
            {
                if(ch == _cInput)
                {
                    counter++;
                }
            }
            return counter;
        }

        static int StringToInt(string _sInput)
        {
            //Om felaktigt input, returnera noll.
            int value = 0;
            bool validation = int.TryParse(_sInput, out value);
            if(!validation)
            {
                return value;
            }
            return value;
        }

        static char[] StringToCharArray(string _sInput)
        {
            return _sInput.ToCharArray();
        }

        static void PrintWithEpicStyle(string _sInput)
        {
            char[] workedInput = StringToCharArray(_sInput);
            foreach(char ch in workedInput)
            {
                Console.Write(ch);
                System.Threading.Thread.Sleep(50);

            }
        }
    }
}
