using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOP
{
    class CompanyA_Car : ToyCar
    {
        public override void MakeToyCar()
        {
            WriteLine("A Car");
        }
    }
    class CompanyA_Cat : ToyCat
    {
        public override void MakeToyCat()
        {
            WriteLine("A Cat");
        }
    }
    class CompanyB_Car : ToyCar
    {
        public override void MakeToyCar()
        {
            WriteLine("B Car");
        }
    }
    class CompanyB_Cat : ToyCat
    {
        public override void MakeToyCat()
        {
            WriteLine("B Cat");
        }
    }
}
