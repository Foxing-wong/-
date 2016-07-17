using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    //B算法(派生类)
    class ConsoleStrategyB : Strategy
    {
        public override void AlgorithmInterface()
        {
            Console.WriteLine('B');
        } 

    }
}
