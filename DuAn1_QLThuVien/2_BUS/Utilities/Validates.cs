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
        
       public void checkSDT(string s)
        {
            bool rg = Regex.IsMatch(s,@"[0-9]");
           
        }
    }
}
