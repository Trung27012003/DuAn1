using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ITheThanhVienServices
    {
        List<TheThanhVien> GetTheThanhVien();
        bool AddTN(TheThanhVien obj);
        bool RemoveTN(TheThanhVien obj);
        bool UpdateTN(TheThanhVien obj);
    }
}
