using ISPViolationApp.Model;

namespace ISPViolationApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShowTask(new Labour());
            Console.WriteLine(new string('-',20));
            ShowTask(new Robot());

        }

         static void ShowTask(IWorker worker)
        {
            worker.StartWork();
            worker.StopWork();
            worker.Drink();
            worker.Eat();
        }
    }
}