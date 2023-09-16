using DIPSolutionApp.HLM;
using DIPSolutionApp.LLM;

namespace DIPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //To generate Zero division error
            TaxCalculator t1 = new TaxCalculator(new DbLogger());
            t1.CalculateTax(100, 0);

            TaxCalculator t11 = new TaxCalculator(new TextLogger());
            t11.CalculateTax(100, 0);


            //Normal division
            TaxCalculator t2 = new TaxCalculator(new DbLogger());
            t2.CalculateTax(100, 4);
            //Console.WriteLine(t2.Tax);

            TaxCalculator t3 = new TaxCalculator(new TextLogger());
            t3.CalculateTax(100, 4);
        }
    }
}