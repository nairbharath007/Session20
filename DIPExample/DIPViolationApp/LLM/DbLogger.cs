using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.LLM
{
    internal class DbLogger
    {
        public void Log(string message)
        {
            Console.WriteLine($"Error occured at {DateTime.Now}: {message}");
        }
    }
}
