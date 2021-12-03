using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVC.Services
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

        public string Print()
        {
            Console.WriteLine("Test print");
            return "Test print";
        }
    }
}
