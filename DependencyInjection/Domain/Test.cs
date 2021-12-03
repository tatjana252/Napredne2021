using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Domain
{
    public class Test : ITest
    {
        public Test()
        {
            Console.WriteLine("Ctor Test");
        }
        public void Dispose()
        {
            Console.WriteLine("Dispose Test");
        }

        public void Print()
        {
            Console.WriteLine("Test print");
        }
    }
}
