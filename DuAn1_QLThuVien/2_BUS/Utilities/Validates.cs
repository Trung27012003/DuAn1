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

        public string checkSDT(string s)
        {
            bool startWith0 = s.StartsWith("0");
            bool isNumber = Regex.IsMatch(s, @"^\d+$");
            bool isLength = s.Length == 10;
            bool isLetter = Regex.IsMatch(s, @"^[a-zA-Z]+$");
            bool isEmail = Regex.IsMatch(s, @"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$");
            if (!startWith0)
            {
                return "SDT bắt đầu bằng 0";
            }
            else if (!isNumber)
            {
                return "SDT chỉ chứa số";
            }
            else if (!isLength)
            {
                return "SDT có 10 số";
            }
            return "";


        }


    }
}
