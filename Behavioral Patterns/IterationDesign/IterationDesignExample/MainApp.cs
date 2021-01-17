using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IterationDesignExample
{
    class MainApp
    {
        static void Main(string[] args)
        {
            PersonnelAggregate personnelAggregate = new PersonnelAggregate();
            personnelAggregate.Add(new Personnel {PersonnelId=1, PersonnelName="Tuğba", PersonelLastName="ÖLÇER"});
            personnelAggregate.Add(new Personnel { PersonnelId = 2, PersonnelName = "Fatih", PersonelLastName = "SARAL" });
            personnelAggregate.Add(new Personnel { PersonnelId = 3, PersonnelName = "Pınar", PersonelLastName = "SAVCI" });
            personnelAggregate.Add(new Personnel { PersonnelId = 4, PersonnelName = "Yasemin", PersonelLastName = "ÖZTÜRK" });

            IIteration iteration = personnelAggregate.CreateIterator();

            while (iteration.HasItem())
            {
                Console.WriteLine($"ID : {iteration.CurrentItem().PersonnelId} \n" +
                    $"Personnel Name : {iteration.CurrentItem().PersonnelName} \n" +
                    $"Personnel LastName : {iteration.CurrentItem().PersonelLastName} \n***************************");
                iteration.NextItem();
            }

            Console.ReadLine();
        }
    }
}
