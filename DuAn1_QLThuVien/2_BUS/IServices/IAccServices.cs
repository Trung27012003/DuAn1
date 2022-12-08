using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IAccServices
    {   
        bool CheckEmtyDB();
        Account CheckLogin(string username, string password);
        bool CheckAccountExists(string username);
        string CreateAccount(AccView obj);
        string EditEMPLOYEES(Account sp);
        List<Account> GetAllAccount();
    }
}
