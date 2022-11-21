using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _1_DAL.IRespositories
{
    public interface IPhieuMuonCTRep
    {
        bool AddPMCT(PhieuMuonChiTiet pmct);

        bool DeletePMCT(PhieuMuonChiTiet pmct);

        bool UpdatePMCT(PhieuMuonChiTiet pmct);

        PhieuMuonChiTiet GetPMCT(Guid id);

        List<PhieuMuonChiTiet> GetAllPMCT();
    }
}
