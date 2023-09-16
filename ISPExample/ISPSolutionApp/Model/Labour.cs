using ISPSolutionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    internal class Labour : IWorkable, ILunchInterval 
    {
        public void Drink()
        {
            Console.WriteLine("Labourer CAN drink.");
        }

        public void Eat()
        {
            Console.WriteLine("Labourer CAN eat.");
        }

        public void StartWork()
        {
            Console.WriteLine("Labourer STARTS work.");
        }

        public void StopWork()
        {
            Console.WriteLine("Labourer STOPS work.");
        }
    }
}
