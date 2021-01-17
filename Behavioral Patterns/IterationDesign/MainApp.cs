using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDesign
{
    class MainApp
    {
        static void Main(string[] args)
        {
            ConcreteAggregate concreteAggregate = new ConcreteAggregate();
            concreteAggregate[0] = "Item A";
            concreteAggregate[1] = "Item B";
            concreteAggregate[2] = "Item c";
            concreteAggregate[3] = "Item D";
            concreteAggregate[4] = "Item E";
            concreteAggregate[5] = "Item F";

            Iterator iterator = concreteAggregate.CreateIterator();

            Console.WriteLine("Dizi Üzerinde Iterasyon :");

            object item = iterator.First();
            while (item != null)
            {
                Console.WriteLine(item);
                item = iterator.Next();
            }

            Console.ReadLine();
        }
    }
}
