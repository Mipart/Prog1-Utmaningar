using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool worked = false;

            Console.Write("Welcome to Marcus Encrypeter\n1.Encrypt a messege\n2.Decrypt a messege\nYour Input: ");

            int userChoice = int.Parse(Console.ReadLine());
            
            switch(userChoice)
            {
                case 1:
                    Encrypt();
                    break;

                case 2:
                    Decrypt();
                    break;
            }

            Console.ReadLine();
        }

        static void Encrypt()
        {
            Random rnd = new Random();
            Console.Clear();
            Console.Write("Your Input: ");
            char[] input = Console.ReadLine().ToCharArray();

            Console.Write("\nThe Key: ");
            byte[] generatedKey = new byte[input.Length];
            for (int i = 0; i < generatedKey.Length; i++)
            {
                generatedKey[i] += Convert.ToByte(rnd.Next(0, 9));
                Console.Write(generatedKey[i]);
            }

            for (int i = 0; i < input.Length; i++)
            {
                byte preChar = Convert.ToByte(input[i]);
                preChar += generatedKey[i];

                input[i] = Convert.ToChar(preChar);
            }

            Console.Write("\nYour Encrypted sentence : ");
            foreach (char item in input)
            {
                Console.Write(item);
            }


        }

        static void Decrypt()
        {
            Console.Clear();
            Console.Write("Your Input: ");
            char[] input = Console.ReadLine().ToCharArray();

            byte[] generatedKey = new byte[input.Length];
            for (int i = 0; i < generatedKey.Length; i++)
            {
                Console.Write("\nThe Key: ");
                generatedKey[i] += Convert.ToByte(Console.ReadLine());
                Console.Write(generatedKey[i]);
                Console.Clear();
            }

            for (int i = 0; i < input.Length; i++)
            {
                byte preChar = Convert.ToByte(input[i]);
                preChar -= generatedKey[i];

                input[i] = Convert.ToChar(preChar);
            }

            Console.Write("\nYour Decrypted sentence : ");
            foreach (char item in input)
            {
                Console.Write(item);
            }
        }

    }
}
