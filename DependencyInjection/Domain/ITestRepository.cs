using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyInjection.Domain
{
    public interface ITestRepository : IDisposable
    {
        public void Add();
    }
}
