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
    public class PhieuMuonServices : IPhieuMuon
    {//Duc ngu
        public IPhieuMuonRep _iphieuMuonRep;
        public PhieuMuonServices()
        {
            _iphieuMuonRep = new PhieuMuonRep();
        }
        public string AddTN(PhieuMuonView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var phieuMuon = new PhieuMuon()
            {
                NgayMuon = obj.NgayMuon,
                NgayTra = obj.NgayTra,
                GhiChu = obj.GhiChu

            };
            if (_iphieuMuonRep.AddPM(phieuMuon)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<PhieuMuonView> GetPhieuMuon()
        {
            List<PhieuMuonView> lst = new List<PhieuMuonView>();
            lst =
                (
                from a in _iphieuMuonRep.GetAllPM()
                select new PhieuMuonView()
                {
                    Id = a.Id,
                    IdNV = a.IdNV,
                    IdTheTV = a.IdTheTV,
                    NgayMuon = a.NgayMuon,
                    NgayTra = a.NgayTra,
                    GhiChu = a.GhiChu

                }
                ).ToList();
            return lst;
        }

        public string RemoveTN(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (_iphieuMuonRep.RemovePM(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string UpdateTN(PhieuMuonView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var phieuMuon = new PhieuMuon()
            {
                Id = obj.Id,
                IdTheTV = obj.IdTheTV,
                IdNV = obj.IdNV,
                NgayMuon = obj.NgayMuon,
                NgayTra = obj.NgayTra,
                GhiChu = obj.GhiChu

            };
            if (_iphieuMuonRep.UpdatePM(phieuMuon)) return "Sửa thành công!";
            return "Sửa không thành công!";
        }
    }
}
