﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    // Figure out why its not inheriting
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> Queue =  new Queue<Sweepstakes>();
        
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            Queue.Enqueue(sweepstakes);

        }

        public Sweepstakes GetSweepstakes()
        {

        }


    }
}
