using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modifiers
{
    class Bus:Car
    {
        public int PasengerCount;

        public override string Info()
        {
            return $"{base.Info()} {PasengerCount}";
        }

        public void Test()
        {
            Console.WriteLine(Model);
        }
    }
}
