using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    class Sweepstakes
    {
        Dictionary<int, Contestant> dictionary;
        public string name;
        public int registrationNumber;



        public void RegisterContestant(Contestant contestant)
        {
            registrationNumber = dictionary.Count();
            dictionary.Add(registrationNumber, contestant);


        }
            
        public void PickWinner()
        {



        }
       
        public void PrintContestantInfo(Contestant contestant)
        {



        }





    }




}
