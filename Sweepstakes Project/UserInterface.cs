using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes_Project
{
    static class UserInterface
    {
        public static string ContestantFirstName()
        {
            Console.WriteLine("Enter Your First Name");
            string firstNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return firstNameInput;

        }
        public static string ContestantLastName()
        {

            Console.WriteLine("Enter Your Last Name?");
            string lastNameInput = Console.ReadLine();
            Console.WriteLine(" ");

            return lastNameInput;

        }
        public static string ContestantEmail()
        {
            Console.WriteLine("Enter Your Email Address");
            string emailInput = Console.ReadLine();
            Console.WriteLine(" ");

            return emailInput;

        }
        public static string CreateSweepstakes()
        {
            Console.WriteLine("what is the name of the sweepstakes?");
            string sweepstake = Console.ReadLine();
            return Sweepstakes;


        }
        public static string ChooseManagement()
        {
            Console.WriteLine("Please choose which management to use");
            Console.WriteLine("");
            Console.WriteLine("Input {Q} for Queue Manager");
            Console.WriteLine("");
            Console.WriteLine("or");
            Console.WriteLine("");
            Console.WriteLine("input {S} for Stack Manager");
            string input = Console.ReadLine();
            return input;


        }
            
        








    }
}
