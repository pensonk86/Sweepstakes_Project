using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    class MarketingFirm
    {
        ISweepstakesManager manager;
        public MarketingFirm(ISweepstakesManager manager)
        {
            this.manager = manager;

        }
        //Instead of whats below
        //public MarketingFirm(SweepstakesStackManager manager)
        //{
        //    this.manager = manager;

        //}
        //public MarketingFirm(SweepstakesQueueManager manager)
        //{
        //    this.manager = manager;

        //}
        public void CreateSweepstakes()
        {
            Sweepstakes sweepstakes = new Sweepstakes();
            sweepstakes.name = UserInterface.CreateSweepstakes();
            manager.InsertSweepstakes(sweepstakes);
            

        }


    }
}
