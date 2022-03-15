using DI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Services
{
    public class ScopeService : IScopeRepository
    {
        private int _number;
        public ScopeService()
        {
            var random = new Random();
            _number = random.Next(0, 100);
        }
        public int GetNumber()
        {
            return _number;
        }
    }
}
