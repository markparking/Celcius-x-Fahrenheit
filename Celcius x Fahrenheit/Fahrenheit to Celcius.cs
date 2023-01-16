using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celcius_x_Fahrenheit
{
    public class FahToCelcius
    {
        private double celcius;
        private double fahrenheit;

        public void FahStart()
        {
            Console.Clear();
            Console.WriteLine("Input Fahrenheit: ");
            fahrenheit = Convert.ToDouble(Console.ReadLine());
            celcius = (fahrenheit * 0.5) - 32;
            Console.WriteLine("{0} Fahrenheit is {1} in Celcius.", fahrenheit, celcius);
            Console.ReadLine();
            Menu menu2 = new Menu();  
            menu2.MainMenu();
        }
    }
}
