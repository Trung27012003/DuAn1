using _1_DAL.Context;
using _1_DAL.IRespositories;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Respositories
{
    public class AccRep : IAccRep
    {
        
        QL_ThuVienDbContext _context;
        public AccRep()
        {
            _context = new QL_ThuVienDbContext();
        }
        public bool AddAccount(string username, string password)
        {
            try
            {
                Account ac = new Account();
                ac.UserName = username;
                ac.PassWord = password;
                _context.Accounts.Add(ac); 
                _context.SaveChanges();
                
                return true;
            }
            catch (Exception e)
            {
               
                return false;
            }
        }

        public Account GetAccount(string username, string password)
        {
            Account account = _context.Accounts.FirstOrDefault(
            a => a.UserName == username && a.PassWord == password);
            return account;
        }

        public List<Account> GetAllAccounts()
        {
            List<Account> accounts = _context.Accounts.ToList();
            return accounts;
        }
    }
}
