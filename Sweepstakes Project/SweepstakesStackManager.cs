using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    
     // Figure out why its not inheriting
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> stack = new Stack<Sweepstakes>();
       public void InsertSweepstakes(Sweepstakes sweepstakes)
       {
            stack.Push(sweepstakes);

       }
        public Sweepstakes GetSweepstakes()
        {



        }




    }




}
