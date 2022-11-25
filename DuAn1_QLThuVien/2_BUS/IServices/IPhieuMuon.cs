using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IPhieuMuon
    {
        List<PhieuMuon> GetPhieuMuon();
        bool AddTN(PhieuMuon obj);
        bool RemoveTN(PhieuMuon obj);
        bool UpdateTN(PhieuMuon obj);
    }
}
