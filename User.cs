using System;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public class User
    {
        public string? FirstName;
        public string? LastName;
        public string? PhoneNo;
        public string? Email;
        public string? Password;
        public void RegisterFirstName(string firstName)
        {
            // UC1
            string FirstNameRegex = @"[A-Z][a-z][a-z]+";
            if(Regex.IsMatch(firstName,FirstNameRegex))
            {
                FirstName = firstName;
            }
            else
            {
                throw new ArgumentException("firstName");
            }

        }
        public void RegisterLastName(string lastName)
        {
            // UC2
            string LastNameRegex = @"[A-Z][a-z][a-z]+";
            if (Regex.IsMatch(lastName, LastNameRegex))
            {
                LastName = lastName;
            }
            else
            {
                throw new ArgumentException("lastName");
            }

        }

        public void RegisterEmail(string email)
        {
            // UC3
            string EmailRegex = @"\w+(.[a-z]+)?@[a-z]+.[a-z]+(.[a-z]+)?";
            if(Regex.IsMatch(email, EmailRegex))
            {
                Email = email;
            }
            else
            {
                throw new ArgumentException("email");
            }
        }

        public void RegisterPhoneNo(string phoneNo)
        {
            string PhoneRegex = @"[0-9]{2}\s[0-9]{10}";
            if(Regex.IsMatch(phoneNo,PhoneRegex))
            {
                PhoneNo= phoneNo;
            }
            else
            {
                throw new ArgumentException("phoneNo");
            }
        }

        public void RegisterPassword(string password)
        {
            string PasswordRegex = @"([a-z]*[A-Z]+[a-z]*[0-9]+[a-z]*[^A-Za-z0-9][a-z]*){8,}"; // doubt
            if(Regex.IsMatch(password,PasswordRegex))
            {
                Password = password;
            }
            else
            {
                throw new ArgumentException("password");
            }
        }

        
    }
}
