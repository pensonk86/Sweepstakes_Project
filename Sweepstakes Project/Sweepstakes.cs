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

        public Sweepstakes(string name)
        {
            this.name = name;
            dictionary = new Dictionary<int, Contestant>();
 
        }


        public void RegisterContestant(Contestant contestant)
        {
            contestant.RegistrationNumber = dictionary.Count();
            dictionary.Add(contestant.registrationNumber, contestant);


        }
            
        public void PickWinner()
        {
            int contestantWon;
            string name;
            contestantWon = random.Next(1, dictionary.Count());
            for (int i = 0; i < dictionary.Count; i++)
            {
                if (contestantWon == dictionary.Count(i));
                {
                    name = dictionary.Count(i).value.firstName + dictionary.Count(i).value.lastName;
                    return name;

                }


            }
            


        }
       
        public void PrintContestantInfo(Contestant contestant)
        {
            Console.WriteLine("First Name: {0} Last Name: {1} Email: {2} ", contestant.firstName, contestant.lastName, contestant.email);
            Console.ReadLine();

        }





    }




}
