using DI.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DI.Services
{
    public class SingletonService : ISingletonRepository
    {
        private int _number;
        public SingletonService()
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
