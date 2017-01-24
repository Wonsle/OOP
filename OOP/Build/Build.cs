using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOP
{

    class GreenArmorBuilder : IArmorBuilder
    {
        public override void BuildA()
        {
            hasPartA = true;
            WriteLine("Green");
        }

        public override void BuildB()
        {
            hasPartB = true;
            WriteLine("Green Iron");
        }

        public override void GetArmor()
        {
            if (hasPartA == false) WriteLine("No Green");
            else if (hasPartB == false) WriteLine("NO Iron");
            else WriteLine("Get");
        }
    }
    class WhiteArmorBuilder : IArmorBuilder
    {
        public override void BuildA()
        {
            hasPartA = true;
            WriteLine("White");
        }

        public override void BuildB()
        {
            hasPartB = true;
            WriteLine("White Iron");
        }

        public override void GetArmor()
        {
            if (hasPartA == false) WriteLine("No White");
            else if (hasPartB == false) WriteLine("NO White Iron");
            else WriteLine("Get");
        }
    }
}
