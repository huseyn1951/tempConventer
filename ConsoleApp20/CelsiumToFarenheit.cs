using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp20
{
    internal class CelsiumToFarenheit
    {
        public void CelsiumToFaren()

        {
            Console.WriteLine("farenheite cevirmek istediyiniz temperaturu daxil edin:");
            double C=double.Parse(Console.ReadLine());
            double F = (9 / 5 * C) +(32);
            Console.WriteLine($"farenheite cevirilmis temperatur:{F}");
        }

        public void FarenToCels()
        {
            Console.WriteLine("celsiye cevirmek istediyiniz temperaturu daxil edin: ");
            double F=double.Parse(Console.ReadLine());
            double C = ((F - 32) * 5 )/ 9;
            Console.WriteLine($"celsiye cevirilmis temperatur:{C}");
        }
       
    }
}
