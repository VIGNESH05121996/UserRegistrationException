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

        public string ValidEmail(string mail)
        {
            string email = "^[a-z]{3}[.][a-z]*[@]{1}[bl]{2}[.]{1}[co]{2}[.]{1}[a-z]*$"; //Regular Expression shows Email should have 3 mandatory parts(abc,bl &co) and 2 optional(xyz & in) with precise @ and . position
            Regex regex = new Regex(email); //calling Regex function

            try
            {
                if (regex.IsMatch(mail))
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

        public string MobileNumber(string number)
        {
            string mobileNumber = "^[1-9]{2}[ ]{1}[0-9]{10}$"; //Regular Expression shows that number should contain country code followed by space and 10 digit number
            Regex regex = new Regex(mobileNumber); //calling Regex function

            try
            {
                if (regex.IsMatch(number))
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

        public string ValidPasword(string pass)
        {
            string password = "^(?=.*[a-z])(?=.*[A-Z])(?=.*[0-9])(?=.*[^a-zA-Z0-9]).{8,}$"; //Regular Expression shows that to pass all password rule
            Regex regex = new Regex(password); //calling Regex function

            try
            {
                if (regex.IsMatch(pass))
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
                return "Invalid";
            }
        }

        public string AllValidEmail(string mail)
        {
            string email = @"^[a-zA-Z0-9]+[+-._]?[a-zA-Z0-9]*[+-._]?[a-zA-Z0-9]+@[a-zA-Z0-9]+[.]{1}[a-zA-Z]{2,3}[.]?[a-zA-Z]{0,3}$"; //Regular Expression shows to test all valid email
            Regex regex = new Regex(email); //calling Regex function

            try
            {
                if (regex.IsMatch(mail))
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
