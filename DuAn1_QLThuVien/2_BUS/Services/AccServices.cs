using _1_DAL.IRespositories;
using _1_DAL.Models;
using _1_DAL.Respositories;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class AccServices : IAccServices
    {
        public IAccRep _iAccRep = new AccRep();
        public bool CheckEmtyDB()
        {
            return _iAccRep.GetAllAccounts() == null;
        }
        public bool AddAccount(string username, string password)
        {
            throw new NotImplementedException();
        }
        public Account CheckLogin(string username, string password)
        {
            Account ac = _iAccRep.GetAccount(username, password);
            return ac;

        }
        
        public string CreateAccount(string username, string password)
        {
            if (_iAccRep.AddAccount(username, password))
            {
                return "Them thanh cong";

            }
            else
                return "Them that bai";
        }
        
        public bool CheckAccountExists(string username) // kiem tra xem ten tk da ton tai hay chua
        {
            var x = _iAccRep.GetAllAccounts().Find(x => x.UserName == username);
            if (x != null)
            {
                return true;
            }
            else return false;
        }

    }
}
