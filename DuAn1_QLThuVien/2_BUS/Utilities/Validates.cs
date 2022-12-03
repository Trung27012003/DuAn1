using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _2_BUS.Utilities
{
    public class Validates
    {

        public bool checkSo(string text)
        {
            // return Regex.IsMatch(text, "^[0-9]*$");
            return Regex.IsMatch(text, "\\d+");
        }

    }
}
