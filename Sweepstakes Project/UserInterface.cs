using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    class UserInterface
    {
        public string ContestantFirstName()
        {
            Console.WriteLine("Enter Your First Name");
            string firstNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return firstNameInput;

        }
        public string ContestantLastName()
        {

            Console.WriteLine("Enter Your Last Name?");
            string lastNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return lastNameInput;

        }
        public string ContestantEmail()
        {
            Console.WriteLine("Enter Your Email Address");
            string emailInput = Console.ReadLine();
            Console.WriteLine(" ");

            return emailInput;

        }
        public int ContestantRegistrationNumber()
        {



        }








    }
}
