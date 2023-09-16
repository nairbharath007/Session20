using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.LLM
{
    internal class TextLogger : ILogger
    {
        public void Log(string message)
        {
            string file = @"C:\Users\acer\Desktop\Aurionpro\Training\Classes\Session20\DIPExample\DIPSolutionApp\log.txt";
            using(StreamWriter sw = new StreamWriter(file, true))
            {
                sw.WriteLine($"Error occured at {DateTime.Now}: {message}");
            }
        }
    }
}
