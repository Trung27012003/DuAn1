using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IPhieuTraServices
    {
        List<PhieuTra> GetPhieuTra();
        bool AddTN(PhieuTra obj);
        bool RemoveTN(PhieuTra obj);
        bool UpdateTN(PhieuTra obj);
    }
}
