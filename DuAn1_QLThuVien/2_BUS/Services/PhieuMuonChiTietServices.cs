using _1_DAL.IRespositories;
using _1_DAL.Models;
using _1_DAL.Respositories;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{

    public class PhieuMuonChiTietServices : IPhieuMuonChiTietChiTietServices
    {//Duc ngu
        public IPhieuMuonCTRep _iphieuMuonCTRep;
        public PhieuMuonChiTietServices()
        {
            _iphieuMuonCTRep = new PhieuMuonChiTietRep();
        }
        public string AddTN(PhieuMuonChiTietView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var phieuMuonChiTiet = new PhieuMuonChiTiet()
            {
              

            };
            if (_iphieuMuonCTRep.AddPMCT(phieuMuonChiTiet)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<PhieuMuonChiTietView> GetPhieuMuonChiTiet()
        {
            throw new NotImplementedException();
        }

        public string RemoveTN(Guid obj)
        {
            throw new NotImplementedException();
        }

        public string UpdateTN(PhieuMuonChiTietView obj)
        {
            throw new NotImplementedException();
        }
    }
}
