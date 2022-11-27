using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ITheThanhVienServices
    {//Duc ngu
        List<TheThanhVien> GetTheThanhVien();
        string AddTN(TheThanhVien obj);
        string RemoveTN(TheThanhVien obj);
        string UpdateTN(TheThanhVien obj);
    }
}
