using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _1_DAL.IRespositories
{
    public interface IPhieuMuonRep
    {
        bool AddPM(PhieuMuon pm);

        bool DeletePM(PhieuMuon pm);

        bool UpdatePM(PhieuMuon pm);

        PhieuMuon GetPM(Guid id);

        List<PhieuMuon> GetAllPM();
    }
}
