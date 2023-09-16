using DIPViolationApp.HLM;

namespace DIPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            TaxCalculator t1 = new TaxCalculator();
            t1.CalculateTax(100,0);

            TaxCalculator t2 = new TaxCalculator();
            t2.CalculateTax(100,4);
        }
    }
}