using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.LLM
{
    internal class DbLogger: ILogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Error occured at {DateTime.Now}: {message}");
        }
    }
}
