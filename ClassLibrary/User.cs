using System;

namespace ClassLibrary
{
    class User
    {
        string firstName;
        string lastName;
        DateTime dateOfBirth;
        string userName;
        string password;
        
        public User(string _FirstName, string _LastName, DateTime _DateOfBirth)
        {
            firstName = _FirstName;
            lastName = _LastName;
            dateOfBirth = _DateOfBirth;
        }
    }
}