using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPViolationApp.Model
{
    internal class Robot : IWorker
    {
        public void Drink()
        {
            Console.WriteLine("Robot CANNOT drink.");
        }

        public void Eat()
        {
            Console.WriteLine("Robot CANNOT eat.");
        }

        public void StartWork()
        {
            Console.WriteLine("Robot STARTS work.");
        }

        public void StopWork()
        {
            Console.WriteLine("Robot STOPS work.");
        }
    }
}
