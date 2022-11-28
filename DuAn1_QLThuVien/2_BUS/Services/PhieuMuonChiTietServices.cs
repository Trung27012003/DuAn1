using _1_DAL.IRespositories;
using _1_DAL.Models;
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
        public IPhieuMuonCTRep _phieuMuonCTRep;
        public PhieuMuonChiTietServices()
        {

        }
        public string AddTN(PhieuMuonChiTietView obj)
        {
             throw new NotImplementedException();
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
