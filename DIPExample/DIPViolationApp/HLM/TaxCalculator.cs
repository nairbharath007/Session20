using DIPViolationApp.LLM;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DIPViolationApp.HLM
{
    internal class TaxCalculator
    {
        DbLogger logger = new DbLogger();
        public double Tax { get; set; }
        public void CalculateTax(int amount, int rate)
        {
            try
            {
                Tax = amount / rate;
            }
            catch(Exception ex)
            {
                new DbLogger().Log("Divide by Zero.");
            }
        }
    }
}
