using System;

namespace ClassLibrary
{
    class User
    {
        string firstName;
        string lastName;
        string DateOfBirth;
        string userName;
        string password;
        
        public User(string aFirstName, string aLastName, string aDateOfBirth)
        {
            firstName = aFirstName;
            lastName = aLastName;
            DateOfBirth = aDateOfBirth;
        }
    }
}