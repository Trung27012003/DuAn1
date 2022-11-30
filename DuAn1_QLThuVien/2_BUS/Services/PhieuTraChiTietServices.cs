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
    public class PhieuTraChiTietServices : IPhieuTraChiTietServices
    {//Duc ngu
        public IPhieuTraCTRep _iphieuTraCTRep;
        public PhieuTraChiTietServices()
        {
            _iphieuTraCTRep = new PhieuTraChiTietRep();
        }
        public string AddTN(PhieuTraChiTietView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var phieutraChiTiet = new PhieuTraChiTiet()
            {

                SoLuong = obj.SoLuong,
                TinhTrang = obj.TinhTrang,
                GhiChu = obj.GhiChu
                
            };
            if (_iphieuTraCTRep.AddPTCT(phieutraChiTiet)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<PhieuTraChiTietView> GetPhieuTraChiTiet()
        {
            List<PhieuTraChiTietView> lst = new List<PhieuTraChiTietView>();
            lst =
                (
                from a in _iphieuTraCTRep.GetAllPTCT()
                select new PhieuTraChiTietView()
                {
                    Id = a.Id,
                    IdPT = a.IdPT,
                    IdSach = a.IdSach,
                    SoLuong = a.SoLuong,
                    TinhTrang = a.TinhTrang,
                    GhiChu = a.GhiChu,
                }
                ).ToList();
            return lst;
        }

        public string RemoveTN(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (_iphieuTraCTRep.RemovePTCT(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string UpdateTN(PhieuTraChiTietView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var phieutraChiTiet = new PhieuTraChiTiet()
            {
                Id = obj.Id,
                IdPT = obj.IdPT,
                IdSach = obj.IdSach,
                SoLuong = obj.SoLuong,
                TinhTrang = obj.TinhTrang,
                GhiChu = obj.GhiChu

            };
            if (_iphieuTraCTRep.UpdatePTCT(phieutraChiTiet)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
