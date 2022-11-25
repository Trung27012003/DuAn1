using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IPhieuMuonChiTietChiTietServices
    {
        List<PhieuMuonChiTiet> GetPhieuMuonChiTiet();
        bool AddTN(PhieuMuonChiTiet obj);
        bool RemoveTN(PhieuMuonChiTiet obj);
        bool UpdateTN(PhieuMuonChiTiet obj);
    }
}
