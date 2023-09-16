using DIPSolutionApp.LLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPSolutionApp.HLM
{
    internal class TaxCalculator
    {
        ILogger _logger;
        public double Tax { get; set; }
        public TaxCalculator(ILogger logger)
        {
            _logger = logger;
            
        }

        public void CalculateTax(int amount, int rate)
        {
            try
            {
                //Tax = 0;
                Tax = amount / rate;
                //Console.WriteLine(Tax);
                //return Tax;
                _logger.Log($"{Tax}");
            }
            catch(Exception ex)
            {
                _logger.Log("Divide by Zero.");
            }
            //return Tax;
        }
    }
}
