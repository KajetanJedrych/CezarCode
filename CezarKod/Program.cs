using System;

namespace CezarKod
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            while ((input = Console.ReadLine()) != null && input != "")
            {
                

                char[] arr;
                arr = input.ToCharArray(0, input.Length);

                foreach (char item in arr) ;
                 // Console.Write(item);
            }
            for (int i = 0; i <= input.Length; i++)
            {
                ConsoleKeyInfo keyInfo;
                do
                  keyInfo =  ;
                    if (keyInfo.KeyChar >= 65 && keyInfo.KeyChar <= 90)
                    {
                        char znak = (char)(((keyInfo.KeyChar - 62) % 28) + 65);
                       Console.WriteLine(znak);
                    }
                    while (keyInfo.Key != ConsoleKey.Escape);
            }
        }
    }
}
