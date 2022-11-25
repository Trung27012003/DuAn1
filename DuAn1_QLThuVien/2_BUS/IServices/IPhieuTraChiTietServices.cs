using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IPhieuTraChiTietServices
    {
        List<PhieuTraChiTiet> GetPhieuTraChiTiet();
        bool AddTN(PhieuTraChiTiet obj);
        bool RemoveTN(PhieuTraChiTiet obj);
        bool UpdateTN(PhieuTraChiTiet obj);
    }
}
