using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Caesar_Cipher
{
    class Program
    {


        public static char cipher(char ch, int key = 3)
        {
            if (!char.IsLetter(ch))
            {

                return ch;
            }

            char d = char.IsUpper(ch) ? 'A' : 'a';
            return (char)((((ch + key) - d) % 26) + d);


        }


        public static string Encipher(string input, int key = 3)
        {
            string output = string.Empty;

            foreach (char ch in input)
                output += cipher(ch, key);

            return output;
        }



        static void Main(string[] args)
        {

            string UserString;

            while ((UserString = Console.ReadLine()) != null && UserString != "")
            {

                int key = 3;

                string cipherText = Encipher(UserString, key);
                Console.WriteLine(cipherText);
            }
            Console.ReadKey();

        }
    }
}