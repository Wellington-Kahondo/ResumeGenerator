using System;
using System.Collections.Generic;
using System.Text;
using System.Text.RegularExpressions;

namespace ResumeGenerator.Services.Helpers
{
    public static class ValidateEmailHelper
    {
        public static bool ValidateEmail(string email)
        {
            Regex regex = new Regex("^[a-zA-Z0-9.!#$%&'*+\\/=?^_`{|}~-]+@[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?(?:\\.[a-zA-Z0-9](?:[a-zA-Z0-9-]{0,61}[a-zA-Z0-9])?)*$");
            Match match = regex.Match(email);
            return match.Success;
        }
    }
}
