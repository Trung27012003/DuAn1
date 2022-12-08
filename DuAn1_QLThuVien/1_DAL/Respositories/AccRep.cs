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
        public bool AddAccount(Account ac)
        {
           
                
                
                _context.Accounts.Add(ac); 
                _context.SaveChanges();
                return true;
            
            
        }

        public Account GetAccount(string username, string password)
        {
            Account account = _context.Accounts.FirstOrDefault(
            a => a.UserName == username && a.PassWord == password);
            return account;
        }

        public List<Account> GetAllAccounts()
        {
             return _context.Accounts.ToList();
          
        }
        public string EditEMPLOYEES(Account sp)
        {

            try
            {
                _context.Accounts.Update(sp);
                _context.SaveChanges();
                return "successful";
            }
            catch (Exception e)
            {
                return e.Message;
            }
        }
    }
}
