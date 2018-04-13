//Marcus Forsberg TE16

using System;
namespace Hangman
{
    class Program
    {
        static void Main(string[] args)
        {
            bool inGame; //Kontroll variabel

            string[] wordArray = new string[]{"hej","hello","Varsava","Bäst","Alltid","soya"};  //En lista med ord, som programet kan välja mellan
            char[] goalWord = pickGoalWord(wordArray);  //Plockar fram ett ord
            char[] userWord = new char[goalWord.Length]; //Sätter upp en till array som användaren får föra in bokstäver i.

            UserWordSetup(userWord);    //Anropar metoden UserWordSetup, den gör bara så att variabeln userWord får blanklines för alla platser i arrayen.

            inGame = true;  //En kontroll variabel, när spelaren får GameOver så ska den slås av.
            bool win = false; //Kontroll variabel, om man har vunnit eller inte
            int lives = 5;  //Antalet liv som spelaren har
            while (inGame)  //Loopar igenom nedanstående kod så länge inGame är sant.
            {
                Console.Clear();    //Städare upp consol fönstret
                Console.WriteLine("Hangman : Lives left " + lives); //Skriver ut texten och hur mycket liv spelaren har kvar
                PrintWord(userWord);    //Skriver ut userWord, så att man kan se vilka bokstäver som var rätt


                char alph;  //output variabel för nedanstående kod. Kommer att hålla i den bokstav som matats in utav användaren
                char.TryParse(Console.ReadLine(), out alph); //Försöker omvandla användarens input till typen char, om man lyckas matas den in i variabeln alph

                if (!CheckIfAlphIsInWord(alph, goalWord, userWord)) //CheckIfAlphIsInWord returnerar en bool, om bokstaven finns i ordet så returenerar den true. Finns inte bokstaven i ordet så försvinner ett liv
                    lives--; //Ett liv tas bort

                if (CheckIfWon(userWord))
                {
                    inGame = false;
                    win = true;
                }

                if (lives <= 0) //kollar ifall att antalet liv är lika med eller under noll, om så är spelet över => while loopen bryts och spelet är slut.
                    inGame = false;
            }

            //Game Over
            Console.Clear(); //Ränsar consol fönstret
            if (!win) //Kollar ifall att man har förlorat
            {
                Console.WriteLine("----Hangman---- \nGameOver"); //Skriver ut en text
            }
            else //Om man har vunnit
            {
                Console.WriteLine("Winner!"); // Skriver ut en text
            }

            Console.ReadLine(); //Failsafe så att inte programet stänger ner sig själv direkt (Så att det inte ska likna en crash)

        }

        static bool CheckIfWon(char[] userWord)
        {
            foreach (char item in userWord) //Iterarar igenom userWord, om en blankLine finns kvar så har man inte klarat av spelet.
            {
                if (item == '_') //Kollar ifall att '_' finns med i arrayen
                    return false; //Omså returnera false
            }
            return true; //Anars returnera true
        }

        static bool CheckIfAlphIsInWord(char input,char[] goal,char[] user)
        {
            bool r = false; //Retur värde, för om bokstaven fanns i ordet eller inte
            for (int i = 0; i < goal.Length; i++) //Loopar igenom alla bokstäver i ordet!, för att gämföra med användarens input
            {
                if(input == goal[i])    //Om bokstaven finns i ordet lägg till den på samma position, fast i user word
                {
                    user[i] = input; //sätter in värdet utav input, i det värde i userWord med position som vara funnen lika i goalWord
                    r = true; //Sätter så att r får värdet utav true
                }
            }

            return r; //Returnerar r
        }

        static void UserWordSetup(char[] c)
        {
            for (int i = 0; i < c.Length; i++)  //Sätter up UserWord, så att den börjar med blankLines
            {
                c[i] = '_'; //Get alla positioner i c ett värde utav blanklines '_'
            }
        }

        static void PrintWord(char[] c)
        {
            foreach (char item in c)    //Iterarar igenom alla items i arrayen,
            {
                Console.Write(item+ " "); //Skriver ut varje enstaka char
            }
            Console.Write("\n"); //Gör en blank line
        }

        static char[] pickGoalWord(string[] input)
        {
            Random rnd = new Random();  //Skapar ett objekt utav Random så att det kan anropas.

            int i = input.Length;   //tar längden hos input in i en int
            string word = input[rnd.Next(0, i)].ToLower(); //Plockar ut ett slumpmässigt ord ifrån arrayen

            char[] cWordArray = word.ToCharArray(); //Konverterar om strängen word till en char array

            return cWordArray; // returnerar cWordArray
        }
    }
}
