using System;
using System.Threading;
using System.Diagnostics;

namespace Chronos
{
    class Program
    {
        static void Main(string[] args)
        {
            Stopwatch cron1 = new Stopwatch(); 
            Stopwatch cron2 = new Stopwatch();

            cron1.Start();
            Thread.Sleep(1000);

            cron2.Start();
            Thread.Sleep(1000);

            cron1.Stop();
            cron2.Stop();

            Console.WriteLine(cron1.ElapsedMilliseconds);
            Console.WriteLine(cron1.ElapsedMilliseconds);

        }
    }
}
