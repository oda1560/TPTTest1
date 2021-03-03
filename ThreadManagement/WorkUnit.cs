using System;
using System.Threading;

namespace ThreadManagement
{
    public class WorkUnit
    {
        public int Id { get; set; }
        public void PerformWork()
        {
            Console.WriteLine($"Starting unit {Id}");
            Thread.Sleep(new Random().Next(1000, 3000));
            Console.WriteLine($"Finished unit {Id}");
        }
    }
}