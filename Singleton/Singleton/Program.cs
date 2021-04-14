using Common;
using System;
using System.Collections.Generic;

namespace Singleton
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LaserPrinter printer = LaserPrinter.GetInstance(GeneralUtils.GetAvailblePrintingJobs());
            printer.Print();
        }
    }
}
