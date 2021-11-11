using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace UserRegistrationException
{
    public class UserRegistration
    {
        //UserRegistration Implementation
       
        public string FirstName(string name)
        {
            string firstName = "^[A-Z]{1}[a-z]{2,}$"; //Regular Expression shows that firstName starts with caps and minimum of 3 character
            Regex regex = new Regex(firstName); //calling Regex function

            try
            {
                if (regex.IsMatch(name))
                {
                    return "Valid";
                }
                else
                {
                    return "Invalid";
                }
            }
            catch(Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "invalid";
            }   
        }

        public string LastName(string name)
        {
            string lastName = "^[A-Z]{1}[a-z]{2,}$"; //Regular Expression shows that lastName starts with caps and minimum of 3 character
            Regex regex = new Regex(lastName); //calling Regex function

            try
            {
                if (regex.IsMatch(name))
                {
                    return "Valid";
                }
                else
                {
                    return "Invalid";
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "invalid";
            }
        }

    }
}
