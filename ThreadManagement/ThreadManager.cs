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
            
        }
    }
}