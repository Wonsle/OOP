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
            var Acar = new CompanyA_Car();
            Acar.MakeToyCar();
            var Acat = new CompanyA_Cat();
            Acat.MakeToyCat();
            var Bcar = new CompanyB_Car();
            Bcar.MakeToyCar();
            var Bcat = new CompanyB_Cat();
            Bcat.MakeToyCat();

            ReadLine();
        }
    }
}
