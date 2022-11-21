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
        bool AddPTCT(PhieuTraChiTiet ptct);

        bool DeletePTCT(PhieuTraChiTiet ptct);

        bool UpdatePTCT(PhieuTraChiTiet ptct);

        PhieuTraChiTiet GetPTCT(Guid id);

        List<PhieuTraChiTiet> GetAllPTCT();
    }
}
