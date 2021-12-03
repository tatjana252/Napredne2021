using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AspMVC.Services
{
    public interface ITest : IDisposable
    {
        public string Print();

    }
}
