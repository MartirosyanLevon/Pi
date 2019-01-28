using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pi
{
    class Program
    {
        static void Main(string[] args)
        {
            const float pi = 3.141f;
            int r = 15,   //radius
                h = 14;  // height
            Console.WriteLine("Cylinder volume {0}", pi * r * r * h);
            Console.WriteLine("Surface of the cylinder {0}", 2 * pi * r * (r + h));


            Console.ReadKey();
        }
    }
}
