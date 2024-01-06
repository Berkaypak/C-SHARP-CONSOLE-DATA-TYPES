using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace C_SHARP_CONSOLE__DATA_TYPES
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string ad = "Berkay";
            char c = 'E';
            byte yas = 19;
            short s = -5;
            int i = int.MaxValue;
            float f = 0.1f;
            double d = yas + s + i + f;
            long tc = 10000000000;
            decimal m = tc - (decimal)d;
            Console.WriteLine("{0} {1} {2} ", ad, c, yas);
            Console.WriteLine(m);
            bool drm = (m < uint.MaxValue);
            Console.WriteLine(drm);
            Console.ReadLine();
        }
    }
}
