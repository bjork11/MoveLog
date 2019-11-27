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

        public void AddPreDefinedUsersToList()
        {
            User UserJoel = new User(" Joel ", " Nilsson "," 1997-12-20 " );
            User UserAdam = new User(" Adam ", " Björk ", " 1996-03-15 ");
            User UserEllen = new User(" Ellen ", " Sdogos "," 1994-01-25 " );
        }
    }
}