using ISPSolutionApp.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ISPSolutionApp.Model
{
    internal class Robot : IWorkable
    {

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
