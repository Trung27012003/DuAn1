using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _1_DAL.IRespositories
{
    public interface IPhieuTraCTRep
    {
        bool AddPTCT(PhieuTraChiTiet x);

        bool RemovePTCT(PhieuTraChiTiet x);

        bool UpdatePTCT(PhieuTraChiTiet x);

        List<PhieuTraChiTiet> GetAllPTCT();
    }
}
