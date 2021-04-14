using System;

namespace projeto_P1.exceptions
{
    public class SearchStockException : Exception
    {
        public SearchStockException(string message) : base(message)
        {

        }
    }
}