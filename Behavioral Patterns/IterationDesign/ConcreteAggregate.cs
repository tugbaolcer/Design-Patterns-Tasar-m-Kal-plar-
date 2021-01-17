using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDesign
{
    public class ConcreteAggregate : Aggregate
    {
        private ArrayList _arrayList = new ArrayList();

        public override Iterator CreateIterator()
        {
            return new ConcreteIterator(this);
        }

        //Eleman sayısı
        public int Count => _arrayList.Count;
        //Dizi oluşturucu
        public object this[int index]
        {
            get { return _arrayList[index]; }
            set { _arrayList.Insert(index, value); }
        }
    }
}
