using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ThreadManagement
{
    class Program
    {
        static void Main(string[] args)
        {
            var maxConcurrentThreads = 10;
            var allWorkUnits = Enumerable.Range(0, 100).Select(id => new WorkUnit { Id = id }).ToList();
            var threadManager = new ThreadManager();
            threadManager.RunAsync(allWorkUnits, maxConcurrentThreads);
            
            Console.WriteLine("Done");
        }
        
    }
}