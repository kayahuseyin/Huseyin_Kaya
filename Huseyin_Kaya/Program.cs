using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Huseyin_Kaya
{
    class Program
    {
        static void Main(string[] args)
        {
            string m;
            int i;
            Console.WriteLine("İsim");
            m = Console.ReadLine();

            for (i = 1; i <= 20; i++)
            {
                Console.SetCursorPosition(30, i);
                Console.Write(m);
                Console.SetCursorPosition(55, i);
                Console.Write(m);
                Console.SetCursorPosition(42, 10);
                Console.Write(m);
                Console.SetCursorPosition(42, 11);
                Console.Write(m);
            }
            for (i = 1; i <= 20; i++)
            {
                Console.SetCursorPosition(80, i);
                Console.Write(m);
                for (int j = 10; j < 21; j++)
                {
                    Console.SetCursorPosition(j + 80, j);
                    Console.Write(m);
                    Console.SetCursorPosition(110 - j, j - 9);
                    Console.Write(m);
                }

            }




            Console.ReadLine();
        }
    }
}
