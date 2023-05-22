using System;
using System.Collections.Generic;
using System.Text;

namespace SpeedyAir.OrderProcessor.Repositories
{
    internal interface IRepository<T>
    {
        public IList<T> GetAll();
    }
}
