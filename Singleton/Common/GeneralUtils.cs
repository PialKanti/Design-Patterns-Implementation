using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class GeneralUtils
    {
        private static readonly int MAXIMUM_JOB_COUNT = 6;

        public static Queue<string> GetAvailblePrintingJobs()
        {
            Queue<string> jobs = new Queue<string>();
            Random random = new Random();
            int count = random.Next(MAXIMUM_JOB_COUNT);

            for (int i = 1; i <= count; i++)
            {
                jobs.Enqueue(i.ToString());
            }

            return jobs;
        }
    }
}
