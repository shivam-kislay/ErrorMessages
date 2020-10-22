using System;
using System.Collections.Generic;

namespace ErrorMessages
{
    public class SqlErrorMessages
    {
        private static Dictionary<int, string> ErrorMessages = new Dictionary<int, string>() 
        {
            {547, "Error Message"}
        };

        public string getErrorMessage(int code) 
        {
            return ErrorMessages[code];
        }
    }
}
