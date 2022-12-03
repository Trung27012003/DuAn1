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
        private IAccRep _iAccRep;
        public AccServices()
        {
            _iAccRep = new AccRep();
        }
            
        public bool CheckEmtyDB()
        {
            return _iAccRep.GetAllAccounts() == null;
        }
       
        public Account CheckLogin(string username, string password)
        {
            Account ac = _iAccRep.GetAccount(username, password);
            return ac;

        }
        
        public string CreateAccount(AccView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var acc = new Account()
            {
               UserName = obj.UserName,
               PassWord = obj.PassWord

            };
            if (_iAccRep.AddAccount(acc)) return "Thêm  thành công!";
            return "Thêm không thành công!";
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
