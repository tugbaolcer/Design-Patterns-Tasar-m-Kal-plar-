using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDesign
{
    public class ConcreteIterator : Iterator
    {
        private ConcreteAggregate _concreteAggregate;
        private int _current =0;

        public ConcreteIterator(ConcreteAggregate concreteAggregate)
        {
            _concreteAggregate = concreteAggregate;
        }

        public override object First()
        {
            return _concreteAggregate[0];
        }

        public override object Next()
        {
            object nextIterator = null;
            if (_current<_concreteAggregate.Count-1)
            {
                nextIterator = _concreteAggregate[++_current];
            }
            return nextIterator;
        }

        public override bool IsDone()
        {
            return _current >= _concreteAggregate.Count;
        }


        public override object CurrentItem()
        {
            return _concreteAggregate[_current];
        }


    }
}
