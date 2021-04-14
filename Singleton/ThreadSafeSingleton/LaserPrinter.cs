using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThreadSafeSingleton
{
    public sealed class LaserPrinter : IPrinter
    {
        private static LaserPrinter printer;
        private static readonly object printingLock = new object();

        public Queue<string> JobQueue;
        private LaserPrinter(Queue<string> jobs)
        {
            JobQueue = jobs;
        }

        public static LaserPrinter GetInstance(Queue<string> jobs)
        {
            lock (printingLock)
            {
                if (printer == null)
                {
                    printer = new LaserPrinter(jobs);
                }
            }
            return printer;
        }

        public void Print()
        {
            Console.WriteLine("Printing job is in progress");
            foreach (string job in JobQueue)
            {
                Console.WriteLine($"{job} Done");
            }
        }
    }
}
