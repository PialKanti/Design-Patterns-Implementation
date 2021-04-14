using Common;
using System;
using System.Threading.Tasks;

namespace ThreadSafeSingleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            IPrinter firstPrinter = null;
            IPrinter secondPrinter = null;

            Task firstTask = Task.Factory.StartNew(() =>
            {
                firstPrinter = LaserPrinter.GetInstance(GeneralUtils.GetAvailblePrintingJobs());
            });

            Task secondTask = Task.Factory.StartNew(() =>
            {
                secondPrinter = LaserPrinter.GetInstance(GeneralUtils.GetAvailblePrintingJobs());
            });

            Task.WaitAll(firstTask, secondTask);

            Console.WriteLine("All printing job done");
            Console.WriteLine($"Is First printer and Second print holding same object reference = {((firstPrinter == secondPrinter) ? "Yes" : "No")}");
        }
    }
}
