using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celcius_x_Fahrenheit
{
    internal class Menu
    {
        CelToFahrenheit c = new CelToFahrenheit();
        FahToCelcius f = new FahToCelcius();
        public void MainMenu()
        {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.SetCursorPosition(50, 11);
                Console.WriteLine("Choose what program to run:");
                Console.SetCursorPosition(50, 12);
                Console.WriteLine("Celcius to Fahrenheit(1)");
                Console.SetCursorPosition(50, 13);
                Console.WriteLine("Fahrenheit to Celcius(2)");
                Console.SetCursorPosition(50, 14);
                Console.WriteLine("Input:");
                Console.SetCursorPosition(56, 14);
                string check = Console.ReadLine();

                switch (check)
                {
                    case "1":
                        c.CelStart();
                        break;
                    case "2":
                    f.FahStart();
                        break;

                    default:
                        Console.Clear();
                        Console.WriteLine("Please only use 1 or 2");
                        Console.ReadKey();
                        MainMenu();
                        break;
                }
            }
        }
}
