using System.Collections.Generic;

namespace ThreadManagement
{
    public class ThreadManager
    {
        public void RunTasksSynchronous(List<WorkUnit> tasks)
        {
            foreach (var task in tasks)
            {
                task.PerformWork();
            }
        }

        public void RunAsync(List<WorkUnit> task, int maxConcurrentThreads)
        {
            // TODO: Please implement a task manager that runs only the given (maxConcurrentThreads) number of threads at one time
            // Do not use Parrallel.ForEach, this test is meant to test your thread management skills specifically
            // Implement this using any thread management technique of your choice
            // There should be no more than maxConcurrentThreads running at the same time
            // Ideally as close to the max number as possible should be running
        }
    }
}