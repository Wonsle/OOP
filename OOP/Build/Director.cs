using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    class Director
    {
        public void Construct(IArmorBuilder builder)
        {
            builder.BuildA();
            builder.BuildB();
        }
    }
}
