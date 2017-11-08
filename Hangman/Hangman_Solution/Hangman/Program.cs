using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hangman
{
    class Program
    {

        public static string[] wordsToBeUsed = new string[] { "hej", "vem" ,"hur","arg","sur","röd","bil","såg","tar","bov","bot","ros","fel","blå","fas"};

        static void Main(string[] args)
        {
            do
            {
                char[] goalWord = ChooseWord(wordsToBeUsed);
                char[] userWord = new char[] { '_', '_', '_', };
                //Antal Försök
                int tryes = 5;
                Console.WriteLine("THE HANGMAN");
                while(tryes != 0)
                {
                    PrintUserWord(userWord);
                    Console.Write("\nYour Guess: ");
                    char userInput = UserInput(Console.ReadLine());
                    //Finns denna char i ordet?
                    if (!(CheckIfUserInputIsInWord(goalWord, userWord, userInput)))
                    {
                        tryes--;
                        Console.Write($"\nWrong answer\n{tryes} left\n");
                    }
                    if (CheckIfWon(userWord))
                    {
                        Console.Write($"You have won\nThe word was: {CharToString(goalWord)}\nPress enter to try again"); 
                        break;
                    }
                    if(tryes == 0)
                    {
                        Console.Write($"\n You lost\nThe word was: {CharToString(goalWord)}\nPress enter to try again");
                    }
                }
                //Ränsning och för att inte programet ska stänga ner sig själv
                Console.ReadLine();
                Console.Clear();
            } while (true);

        }

        static string CharToString(char[] _goalWord)
        {
            string myString = "";
            for (int i = 0; i < _goalWord.Length; i++)
            {
                myString += _goalWord[i];
            }
            return myString;
        }

        static bool CheckIfWon(char[] _userWord)
        {
            for (int i = 0; i < _userWord.Length; i++)
            {
                if(_userWord[i] == '_')
                {
                    return false;
                }
            }
            return true;
        }
        static bool CheckIfUserInputIsInWord(char[] _goalWord,char[] _userWord, char _userInput)
        {
            bool returnValu = false;
            for (int i = 0; i < _goalWord.Length ; i++)
            {
                if(_goalWord[i] == _userInput)
                {
                    _userWord[i] = _userInput;
                    returnValu = true;
                }
            }
            return returnValu;
        }

        static void PrintUserWord (char[] _userWord)
        {
            foreach (char ch in _userWord)
            {
                Console.Write(ch);
                Console.Write(" ");
            }
            Console.WriteLine();
        }

        static char UserInput(string _input)
        {
            char[] workedInput = _input.ToCharArray();
            try
            {
                return workedInput[0];
            }
            catch
            {
                return ' ';
            }
        }

        static char[] ChooseWord(string[] _stringArray)
        {
            Random rnd = new Random();
            return _stringArray[rnd.Next(0, _stringArray.Length)].ToCharArray();
        }

    }
}
