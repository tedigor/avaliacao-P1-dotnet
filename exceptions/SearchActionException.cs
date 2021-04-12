using System;

namespace projeto_P1.exceptions
{
    public class SearchActionException : Exception
    {
        public SearchActionException(string message) : base(message)
        {

        }
    }
}