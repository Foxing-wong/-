using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    //A算法(派生类)
    class ConsoleStrategyA : Strategy
    {
        //A算法
        public override void AlgorithmInterface()
        {
            Console.WriteLine('A');
        }
    }
}
