using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Domain
{
    public class TestRepository : ITestRepository
    {
        private readonly ITest test;

        public TestRepository(ITest test)
        {
            Console.WriteLine("TestRepository");
            this.test = test;
        }

        public void Add()
        {
            Console.WriteLine("TestRepository:Add()");
            test.Print();
        }

        public void Dispose()
        {
            Console.WriteLine("Dispose TestRepository");
        }
    }
}
