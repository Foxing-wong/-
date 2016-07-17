using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            Context context;
            context = new Context(new ConsoleStrategyA()); //调用A的方法
            context.ContextAlgorithmInterface();

            context = new Context(new ConsoleStrategyB()); //调用A的方法
            context.ContextAlgorithmInterface();

            Console.ReadLine();
        }
    }
}
