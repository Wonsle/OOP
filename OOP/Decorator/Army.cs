using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;
namespace OOP
{
    class Army : IArmy
    {
        public void ConveneOperation()
        {
            WriteLine("Call Army");
        }
    }

    abstract class AGeneral : IArmy
    {
        protected IArmy _general;
        public void setGetneral(IArmy general)
        {
            this._general = general;
        }
        public abstract void ConveneOperation();
    }

    class GeneralA : AGeneral
    {
        public override void ConveneOperation()
        {            
            WriteLine("曹仁：吾有萬夫不當之勇  願成為主公堅實的後盾");

        }
    }
}
