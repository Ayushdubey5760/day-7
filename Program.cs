using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exersice_day_6
{
    public class ValidationException : Exception
    {
        public ValidationException(string message) : base(message) 
        {
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Enter your name (at least 6 characters): ");
                string name = Console.ReadLine();

                Console.WriteLine("Enter your email: ");
                string email = Console.ReadLine();

                Console.WriteLine("Enter your password (at least 6 characters): ");
                string password = Console.ReadLine();

                ValidateRegistrationDetails(name, email, password);

                Console.WriteLine("Registration successful!");
            }
            catch (ValidationException ex)
            {
                Console.WriteLine("Registration failed. Reason: " +ex.message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("An error occured: " + ex.Message);
            }
        }

        static void ValidateRegistrationDetails(string name, string email, string password)

        {
            if (string.IsNullOrEmpty(name) || name.Length < 6
                throw new ValidationException("Name is required and must be atleast 6 characters long.");

            if (string.IsNullOrEmpty(email))
                throw new ValidationException("Email is required");

            if (string.IsNullOrEmpty(password) || password.Length < 6
                throw new ValidationException("Password is required and must be atleast 6 characters long.");

            if (!IsValidEmail(email))
                throw new ValidateException("Invalid email format.");

        }

        static bool IsValidEmail(string email)
        {

            return email.Contains("e") && email.Contains(".");
        }
    }
}
