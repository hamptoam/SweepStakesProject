using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesProject
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        public Dictionary contestants; 

        public SweepstakesQueueManager()
        {
            GetSweepstakeQueue();
        }
        

        public static void GetSweepstakeQueue()
        {

            Queue contestantQueue = new Queue(contestants);

        }
    }
}
