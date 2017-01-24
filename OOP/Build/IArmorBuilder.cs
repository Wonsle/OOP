using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOP
{
    abstract class IArmorBuilder
    {

        protected bool hasPartA = false;
        protected bool hasPartB = false;

        public abstract void BuildA();
        public abstract void BuildB();
        public abstract void GetArmor();
    }
}
