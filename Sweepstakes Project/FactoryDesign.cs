using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    class FactoryDesign
    {
        public ISweepstakesManager ChooseManager()
        {
            string input = UserInterface.ChooseManagement();
            switch ()
            {
                case "Q":
                    return new SweepstakesQueueManager();
                case "S":
                    return new SweepstakesStackManager();
                default:
                    throw new ApplicationException("not a valid choice");


            }



        }

    }
}
