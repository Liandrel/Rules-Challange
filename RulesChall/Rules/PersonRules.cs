using RulesChall.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RulesChall.Rules
{
    public class PersonRules
    {
        public static bool CheckForFullName<T>(T data)
        {
            bool output = false;

            if (data is PersonModel person)
            {
                if (person.LastName.ToLower() == "corey" && person.FirstName.ToLower() != "tim")
                {
                    output = true;
                    Console.WriteLine("Possibly related to Tim Corey");
                }
            }

            return output;
        }

        public static bool CheckForInitials<T>(T data)
        {
            bool output = false;

            if (data is PersonModel person)
            {
                if (person.FirstName.ToLower()[0] == 't' && person.LastName.ToLower()[0] == 'c')
                {
                    output = true;
                    Console.WriteLine("Same initials as Tim Corey");
                }
            }

            return output;
        }

        public static bool CheckForPostalCode<T>(T data)
        {
            bool output = false;

            if (data is PersonModel person)
            {
                if (person.PostalCode.StartsWith("18"))
                {
                    output = true;
                    Console.WriteLine("In the same general area as Tim");
                }
            }

            return output;
        }
    }
}
