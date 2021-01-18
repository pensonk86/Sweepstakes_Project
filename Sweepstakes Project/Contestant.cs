using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    public class Contestant
    {
        //member Variables

        public string firstName;
        public string lastName;
        public string email;
        public int registrationNumber;




        //Constructor
        public string FirstName { get => firstName; set => firstName = value; }
        public string LastName { get => lastName; set => lastName = value; }
        public string Email { get => email; set => email = value; }
        public int RegistrationNumber { get => registrationNumber; set => registrationNumber = value; }
        

        //Member Variables

          // Why isnt interfaces working? They have same name as UserInterface class.
        public Contestant ContestantInformation()
        {
            Contestant contestant = new Contestant();
            contestant.firstName = UserInterface.ContestantFirstName();
            contestant.lastName = UserInterface.ContestantLastName();
            contestant.email = UserInterface.Contestantemail();
            return contestant;
            

        }



    }
}
