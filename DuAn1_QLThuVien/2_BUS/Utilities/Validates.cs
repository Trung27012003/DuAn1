
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

        public string checkSo(string s)
        {
            bool rg = Regex.IsMatch(s, @"\d{1,100}");
            try
            {
                if (s.Trim().Length == 0)
                {
                    return "Nhập thông tin đi ? lừa ai?";
                }
                else if (!rg)
                {
                    return "Nhập 1 số đi ";
                }
                else if (int.Parse(s) <= 0)
                {
                    return "Nhập 1 số dương đi";
                }
                return "";
            }
            catch (Exception)
            {
                return "Nhập sai rồi! ";
            }
        }

        public  string checkMk(string c)
        {

            bool regex = Regex.IsMatch(c, @"[A-Za-z0-9]");
           
            if (!regex)
            {
                return "Không được nhập kí tự đặc biệt";
            }
            else
            {
                return "";
            }
        }

        public string checkRong(string s)
        {
            if (s.Trim().Length == 0)
            {
                return "Nhập cái gì vào đi";
            }
            else return "";
        }
        public bool CheckPass(string password)
        {
            if (password.Length < 8)
            {
                return false;
            }
            bool Kitu_dacbiet = false;
            bool Kitu_dacbiet1 = false;
            bool Kitu_dacbiet2 = false;
            for (int i = 0; i < password.Length; i++)
            {
                if (password[i] >= 'a' && password[i] <= 'z')
                    Kitu_dacbiet = true;
                if (password[i] >= 'A' && password[i] <= 'Z')
                    Kitu_dacbiet1 = true;
                if (password[i] >= '0' && password[i] <= '9')
                    Kitu_dacbiet2 = true;
                if (Kitu_dacbiet && Kitu_dacbiet1 && Kitu_dacbiet2)
                    return true;

            }
            return false;

        }
    }
}
