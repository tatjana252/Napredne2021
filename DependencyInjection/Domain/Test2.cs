using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Domain
{
    public class Test2 : ITest
    {
        public Test2()
        {
            Console.WriteLine("Ctor Test2");
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose Test2");
        }

        public void Print()
        {
            Console.WriteLine("Test print2");
        }
    }
}
