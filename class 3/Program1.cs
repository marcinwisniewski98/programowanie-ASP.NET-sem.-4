using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int letter;
            ConsoleKey key;
            int x = Console.CursorLeft;
            int y = Console.CursorTop;
            char encryptedLetter;
     
            do
            {
                key = Console.ReadKey().Key;

                letter = (int)key;

                x = Console.CursorLeft;
                y = Console.CursorTop;

                encryptedLetter = (char)((letter - 64) % 26 + 97);

                Console.SetCursorPosition(x-1, y+1);
                Console.Write(encryptedLetter);
                Console.SetCursorPosition(x, y);

            } while (key != ConsoleKey.Escape & key != ConsoleKey.Q);

        }
    }
}
