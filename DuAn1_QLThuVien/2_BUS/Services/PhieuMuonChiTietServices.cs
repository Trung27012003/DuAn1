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
              SoLuong = obj.SoLuong,
              DieuKien = obj.DieuKien,
              GhiChu = obj.GhiChu,
              TienTheChan = obj.TienTheChan,

            };
            if (_iphieuMuonCTRep.AddPMCT(phieuMuonChiTiet)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<PhieuMuonChiTietView> GetPhieuMuonChiTiet()
        {
            List<PhieuMuonChiTietView> lst = new List<PhieuMuonChiTietView>();
            lst =
                (
                from a in _iphieuMuonCTRep.GetAllPMCT()
                select new PhieuMuonChiTietView()
                {
                    Id = a.Id,
                    IdPM = a.IdPM,
                    IdSach = a.IdSach,
                    SoLuong = a.SoLuong,
                    DieuKien = a.DieuKien,
                    GhiChu = a.GhiChu,
                    TienTheChan = a.TienTheChan
                }
                ).ToList();
            return lst;
        }

        public string RemoveTN(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (_iphieuMuonCTRep.RemovePMCT(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }
        public string UpdateTN(PhieuMuonChiTietView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var phieuMuonChiTiet = new PhieuMuonChiTiet()
            {
                Id = obj.Id,
                IdPM = obj.IdPM,
                IdSach = obj.IdSach,
                SoLuong = obj.SoLuong,
                DieuKien = obj.DieuKien,
                GhiChu = obj.GhiChu,
                TienTheChan = obj.TienTheChan,

            };
            if (_iphieuMuonCTRep.UpdatePMCT(phieuMuonChiTiet)) return "Sửa thành công!";
            return "Sửa không thành công!";
        }
    }
}
