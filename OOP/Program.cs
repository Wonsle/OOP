using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using static System.Console;
namespace OOP
{
    class Program
    {
        static void Main(string[] args)
        {
            var green = new GreenArmorBuilder();
            var direct = new Director();
            for (int i = 0; i < 3; i++)
            {
                direct.Construct(green);
                green.GetArmor();
                WriteLine();
            }
            

            ReadLine();
        }
    }
}
