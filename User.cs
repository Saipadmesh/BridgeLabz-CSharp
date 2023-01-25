using System;
using System.Text.RegularExpressions;


namespace UserRegistration
{
    public enum UserExceptionVar
    {
        FirstName,
        LastName,
        PhoneNo,
        Email,
        Password
    }
    public class UserException : Exception
    {
        // UC12
        private UserExceptionVar? _var = null;

        public UserException() { }

        public UserException(UserExceptionVar var, string message) : base(String.Format("Invalid or Empty Field: {0}\nValue is {1}",var,message))
        {
            _var= var;
        }


    }
    
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
                throw new UserException(UserExceptionVar.FirstName,firstName);
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
                throw new UserException(UserExceptionVar.LastName, lastName);
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
                throw new UserException(UserExceptionVar.Email, email);
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
                throw new UserException(UserExceptionVar.PhoneNo, phoneNo);
            }
        }

        public void RegisterPassword(string password)
        {
            string MinLength = @"(.+){8,}", SpecialChar = @".*[^A-Za-z0-9].*"; // doubt
            string UpperCase = @".*[A-Z]+.*", Numerical = @".*[0-9]+.*";

            bool isValid = Regex.IsMatch(password, MinLength) && Regex.IsMatch(password,SpecialChar) && Regex.IsMatch(password,UpperCase) && Regex.IsMatch(password,Numerical);

            if (isValid)
            {
                Password = password;
            }
            else
            {
                throw new UserException(UserExceptionVar.Password,password);
            }
        }

        
    }
}
