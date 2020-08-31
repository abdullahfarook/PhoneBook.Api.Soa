using PhoneBook.Core.Exceptions;
using PhoneBook.Core.Extensions;
using System;

namespace PhoneBook.Core.Parser
{
    // Streatigy Pattern child class
    public class CsvParserStreatigy : IStringParseStreatigy
    {
        private const string Delimiter = ",";
        public string StringToParse { get; private set; }
        public CsvParserStreatigy(string stringToParse)
        {
            if (stringToParse.IsNull()) 
                throw new Exception("No string is provided to parse");

            if (!stringToParse.Contains(Delimiter)) 
                throw new UnprocessableException("Not a valid CSV string");

            StringToParse = stringToParse;
        }
    }
}
