using System;
using System.Collections.Generic;
using System.Text;

namespace PhoneBook.Core.Exceptions
{
    public class UnprocessableException : PhoneBookException
    {
        public UnprocessableException(string message) : base(message)
        {
        }
    }
}
