using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ITheThanhVienServices
    {
        List<TheThanhVienView> GetTheThanhVien();
        string AddTN(TheThanhVienView obj);
        string RemoveTN(Guid obj);
        string UpdateTN(TheThanhVienView obj);
    }
}
