using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Profile
{
    class Program
    {
        static void Main(string[] args)
        {
            switch(StartMenu())
            {
                case 1:
                    break;
                case 2:
                    CreateProfile();
                    break;
            }

        }

        static int StartMenu()
        {
            Console.Clear();
            //Lägg till en extra på antalet alternativ
            int _numOfAlternativs = 3;

            //Ger de alternativ som finns för användaren
            Console.WriteLine("Welcome to Marcus profile manager v0.0.0.1");
            Console.WriteLine();
            Console.WriteLine("1. Find a profile");
            Console.WriteLine("2. Create a new profile");

            //Skicka vidare vad användaren angav
            return UserInput(2);

        }

        static void CreateProfile()
        {

            Console.Clear();
            Console.WriteLine("-----Create Profile-----");
            Console.WriteLine();

            Console.WriteLine("Firstname :");
            string _profileFirstName = Console.ReadLine();

            Console.WriteLine("Lastname : ");
            string _profileLastName = Console.ReadLine();

            Console.WriteLine("Age : ");
            string _profileAge = Console.ReadLine();

            Console.WriteLine("Sex : ");
            string _profileSex = Console.ReadLine();

            //Börja skriv!!!!
            string path = @"..\..\..\..\pm\" + _profileFirstName+_profileLastName + ".txt";
            FileStream fs = File.Create(path);
            StreamWriter writer = new StreamWriter(fs);
            StringBuilder output = new StringBuilder();

            output.AppendLine("First name : "+_profileFirstName);
            output.AppendLine("Last name : "+_profileLastName);
            output.AppendLine("Age : " + _profileAge);
            output.AppendLine("Sex : " + _profileSex);
            writer.WriteLine(output.ToString());
            output.Clear();
            writer.Close();

            Console.Clear();
            Console.WriteLine("-----Profile manager-----");
            Console.WriteLine("");
            Console.WriteLine("1. Start screen");
            Console.WriteLine("2. Create another profile");
            Console.WriteLine("3. Close program");

            int _userChoice = UserInput(3);

            switch(_userChoice)
            {
                case 1:
                    StartMenu();
                    break;
                case 2:
                    CreateProfile();
                    break;
                case 3:
                    //Do nothing
                    break;
            }
        }

        static int UserInput(int _numOfAlternativs)
        {
            _numOfAlternativs++;
            string _userInput = Console.ReadLine();

            int _userChoice = 0;
            bool _validOption = int.TryParse(_userInput, out _userChoice);
            if (_validOption && _userChoice < _numOfAlternativs && _userChoice > 0)
            {
                return _userChoice;
            }
            else
            {
                Console.Clear();
                Console.WriteLine("Invalid Input");
                Console.WriteLine("Try again");
                Console.ReadLine();
                return UserInput(_numOfAlternativs--);
            }
        }
    }
}
