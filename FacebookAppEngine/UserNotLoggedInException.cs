using System;
using FacebookWrapper.ObjectModel;

namespace FacebookAppEngine
{
    public class UserNotLoggedInException : Exception
    {
        public UserNotLoggedInException() 
            : base("The user is not logged, please login before fetching")
        {
        }
    }
}
