using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Figgle;

namespace t5mHax
{
    class Program
    {
        static void ascii(string text)
        {
            Console.WriteLine(FiggleFonts.Standard.Render(text));
        }
        static void Main(string[] args)
        {
            Memory.Mem m = new Memory.Mem();
            Console.Title = "t5mHax";
            Console.ForegroundColor = ConsoleColor.Red;

            ascii("t5mHax");
            Console.WriteLine("\n\nMessage IcyJake#1200 on Discord for help/questions.");
            Console.Write("\nPlease enter the amount of money you would like: ");

            int amountOfMoney = int.Parse(Console.ReadLine());

            m.OpenProcess(Process.GetProcessesByName("t5m").FirstOrDefault().Id);

            if (amountOfMoney > 2147483647)
            {
                Console.Write("Please enter a little bit of a smaller number: ");

                int amountOfMoney2 = int.Parse(Console.ReadLine());

                if (amountOfMoney2 > 2147483647)
                {
                    Console.WriteLine("\nAn error has occurred! Please restart t5mHax.");
                    Console.ReadKey();
                }

                else
                {
                    m.WriteMemory("t5m.exe+024C4FE0,A0", "int", Convert.ToString(amountOfMoney2));
                    Console.WriteLine("\nSuccessfully transfered: $" + amountOfMoney2);
                    Console.ReadKey();
                }
            }

            else
            {
                m.WriteMemory("t5m.exe+024C4FE0,A0", "int", Convert.ToString(amountOfMoney));
                Console.WriteLine("\nSuccessfully transfered: $" + amountOfMoney);
                Console.ReadKey();
            }
        }
    }
}
