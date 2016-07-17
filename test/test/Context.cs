using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace test
{
    class Context
    {
        Strategy strategy;
        //初始化时传入一个具体的对象
        public Context(Strategy strategy)
        {
            this.strategy = strategy;
        }
        //根据具体的对象调用对应的方法。
        public void ContextAlgorithmInterface() 
        {
            strategy.AlgorithmInterface();
        }

    }
}
