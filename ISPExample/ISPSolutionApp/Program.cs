using ISPSolutionApp.Model;

namespace ISPSolutionApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Labour labour = new Labour();
            Robot robot = new Robot();
            labour.StartWork();
            labour.StopWork();
            labour.Eat();
            labour.Drink();
            Console.WriteLine(new string('-',20));
            robot.StartWork();
            robot.StopWork();

        }
    }
}