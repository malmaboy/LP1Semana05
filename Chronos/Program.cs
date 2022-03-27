using System;
using System.Diagnostics;
using System.Threading;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Program program;
            program = new Program();
            program.Run();
        }


        private void Run()
        {
            Stopwatch cron1 = new Stopwatch();
            Stopwatch cron2 = new Stopwatch();
            cron1.Start();
            Thread.Sleep(1000);
            cron2.Start();
            Thread.Sleep(1000);
            cron1.Stop();
            cron2.Stop();

            TimeSpan time1 = cron1.Elapsed;
            TimeSpan time2 = cron2.Elapsed;
            
            
            Console.WriteLine($" The Values are in seconds \n" +
                              $" cron1 = {time1.Seconds}s" +
                              $" \n cron2 = {time2.Seconds}s");
        }
    }
}
