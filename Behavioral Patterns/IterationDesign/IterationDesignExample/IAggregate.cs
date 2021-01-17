using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDesignExample
{
    public interface IAggregate
    {
        IIteration CreateIterator();
    }
}
