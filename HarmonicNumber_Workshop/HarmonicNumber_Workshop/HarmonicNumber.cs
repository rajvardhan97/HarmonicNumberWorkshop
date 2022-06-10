using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HarmonicNumber_Workshop
{
    internal class HarmonicNumber
    {
        public void Harmonic()
        {
            float value = 0;
            Console.WriteLine("Enter a number to find Harmonic Number: ");
            int number = Convert.ToInt32(Console.ReadLine());

            while(number == 0)
            {
                Console.WriteLine("Please enter a number which is not zero");
                break;
            }  
            number = Convert.ToInt32(Console.ReadLine());

            for (float i = 1; i <= number; i++)
            {
                value += 1 / i;
            }
            Console.WriteLine("The  Nth harmonic Number is " + value);
        }
    }      
}
