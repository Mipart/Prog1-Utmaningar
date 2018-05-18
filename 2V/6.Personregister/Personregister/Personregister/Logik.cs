using System;
namespace Personregister
{
    class Logik
    {
        PersonRegister pr = new PersonRegister();


        public Logik()
        {
            PrintMenu(); //Skriver ut meny info
            bool kw = true; //Kontroll variabel
            do
            {
                Console.Write("\nDitt val: ");
                var input = ManageMenu(); //Tar in ett input 
                if (input.GetType() == typeof(int)) //Kollar om användaren har skrivit in ett värde av typen 'int'
                {
                    switch (input) //Om användaren har gjort ovanstående, så kör nedastående kod
                    {
                        case 0:
                            //Stäng programmet
                            kw = false;
                            break;
                        case 1:
                            //Skriv ut hela personlistan
                            foreach (string item in pr.ReturnNameList())
                            {
                                Console.WriteLine(item);
                            }
                            break;
                        case 2:
                            AddPersonToList();
                            break;
                        default:
                            Console.WriteLine("Kommandot finns inte!");
                            break;
                    }
                }
                else //Om användaren iställer har angett ett annat värde så kör denna kod
                {
                    if ((string)input == "meny") //castar input till string och sedan gämför det med värdet meny
                    {
                        PrintMenu(); //Skriver ut meny
                    }
                    else if((string)input == "clear")
                    {
                        Console.Clear();
                    }
                    else
                    {
                        Person p = pr.ReturnPerson((string)input);//Hämtar en person ifrån personRegistret
                        if (p != null) //Om personen fanns i listan, kör nedanstående kod
                        {
                            PrintPerson(p); // Skriv ut personen
                        }
                        else
                        {
                            Console.WriteLine("Personen fanns inte i listan!");
                        }
                    }
                }
            } while (kw);
        }

        void AddPersonToList()
        {
            Console.WriteLine("Lägg till person");
            Console.Write("Namn : ");
            string name;

            //Kontrollerar så att namnet inte innehåller nummer.
            bool nkb = false; //Kontroll variabel
            do
            {
                if (nkb)
                {
                    Console.Write("Namnet får inte enbart bestå utav siffror!\nNamn : ");
                }
                name = Console.ReadLine(); //Tar in ett input
                int useless; //Användes inte!
                nkb = int.TryParse(name, out useless); //Försöker konvertera string till int, skickar sedan ut ett boolean värde till nkb
            } while (nkb); //Ifall att det gick att konvertera till int, gör om!

            int age;
            bool kr = false; //Kontroll variabel
            do // Testar att göra om string till en int.
            {
                Console.Write("Ålder : ");
                bool r = int.TryParse(Console.ReadLine(), out age); //Konverterar värdet till en string
                kr = r; //Sätter kontroll variabeln till sant ifall att det gick att konvertera string till int.
                if (!r)
                {
                    Console.Write("Felaktigt input!\nFörsök igen\n");
                }
            } while (!kr);

            Console.Write("Stad : ");
            string town = Console.ReadLine();
            pr.AddPerson(name, age, town); //Skickar in värdena till metoden AddPerson i personListan

        }

        void PrintPerson(Person p)
        {
            Console.Write(p.Name + " är " + p.Age + " år gammal, och bor i " + p.Town);
        }

        void PrintMenu()
        {
            Console.Write("Tryck 1 för att se person listan\nTryck 2 för att lägga till en person\nSkriv befintligt namn på en person för att få mer information\nSkriv clear för att rensa fönstret\nSkriv Meny för att få se menyn igen\nTryck 0 för att avsluta\n");
        }


        Object ManageMenu() //Retur typen är Object, vilket gör det möjligt att returnera antingen int eller string
        {
            string input = Console.ReadLine(); //Ta in en input
            int intInput; //Testa o se om det går att konvertera input till en integer

            bool rInput = int.TryParse(input, out intInput); // Testar konvertera input

            if (rInput)
            {
                return intInput;
            }
            else
            {
                return input;
            }
        }
    }
}
