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
    public class PhieuTraServices : IPhieuTraServices
    {//Duc ngu
        public IPhieuTraRep _iphieuTraRep;
        public PhieuTraServices()
        {
            _iphieuTraRep = new PhieuTraRep();
        }
        public string AddTN(PhieuTraView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var phieutra = new PhieuTra()
            {

                NgayTra = obj.NgayTra,
                GhiChu = obj.GhiChu

            };
            if (_iphieuTraRep.AddPT(phieutra)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }
        public List<PhieuTraView> GetPhieuTra()
        {
            List<PhieuTraView> lst = new List<PhieuTraView>();
            lst =
                (
                from a in _iphieuTraRep.GetAllPT()
                select new PhieuTraView()
                {
                    Id = a.Id,
                    IdPM = a.IdPM,
                    NgayTra = a.NgayTra,
                    GhiChu = a.GhiChu,

                }
                ).ToList();
            return lst;
        }
         public string RemoveTN(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (_iphieuTraRep.RemovePT(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string UpdateTN(PhieuTraView obj)
        {
            if(obj == null) return "Sửa không thành công!";
            var phieutra = new PhieuTra()
            {
                Id = obj.Id,
                IdPM = obj.IdPM,
                NgayTra = obj.NgayTra,
                GhiChu = obj.GhiChu

            };
            if (_iphieuTraRep.AddPT(phieutra)) return "Sửa thành công!";
            return "Sửa không thành công!";
        }
    }
}
