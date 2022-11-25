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
        bool AddPM(PhieuMuon x);

        bool RemovePM(PhieuMuon x);

        bool UpdatePM(PhieuMuon x);

        List<PhieuMuon> GetAllPM();
    }
}
