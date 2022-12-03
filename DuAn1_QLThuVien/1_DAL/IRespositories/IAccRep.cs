using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRespositories
{
    public interface IAccRep
    {
         List<Account> GetAllAccounts();
         Account GetAccount(string username, string password);
         bool AddAccount(Account ac);
    }
}
