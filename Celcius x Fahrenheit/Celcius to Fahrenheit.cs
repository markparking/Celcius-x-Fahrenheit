using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Celcius_x_Fahrenheit
{
   public class CelToFahrenheit
    {
        private double celcius;
        private double fahrenheit;

        public void CelStart()
        {
            Console.Clear();
            Console.WriteLine("Input Celcius: ");
            celcius = Convert.ToDouble(Console.ReadLine());
            fahrenheit = 32 + (celcius * 1.8);
            Console.WriteLine("{0} Celcius is {1} in Fahrenheit.", celcius, fahrenheit);
            Console.ReadLine();
            Menu menu3 = new Menu();
            menu3.MainMenu();
        }   
    }
}
