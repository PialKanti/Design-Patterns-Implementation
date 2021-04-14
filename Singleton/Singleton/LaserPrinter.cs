﻿using Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Singleton
{
    public sealed class LaserPrinter : IPrinter
    {
        private static LaserPrinter printer;
        public Queue<string> JobQueue;
        private LaserPrinter(Queue<string> jobs)
        {
            JobQueue = jobs;
        }

        public static LaserPrinter GetInstance(Queue<string> jobs)
        {
            if(printer == null)
            {
                printer = new LaserPrinter(jobs);
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
