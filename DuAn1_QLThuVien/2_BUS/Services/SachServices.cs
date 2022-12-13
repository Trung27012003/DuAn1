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
    public class SachServices : ISachServices
    {
        public ISachRep _IsachRep;
        public SachServices()
        {
            _IsachRep = new SachRep();
        }
        public string AddTN(SachView a)
        {
            if (a == null) return "Thêm không thành công!";
            var Sach = new Sach()
            {
                Name = a.Name,
                IdTL = a.IdTL,
                Ma = a.Ma,
                BarCode = a.BarCode,
                TG = a.TG,
                NXB = a.NXB,
                SoLuong =  a.SoLuong,
                GhiChu = a.GhiChu,
                GiaTien = a.GiaTien,

            };
            if (_IsachRep.AddSach(Sach)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<SachView> GetSach()
        {
            List<SachView> lst = new List<SachView>();
            lst =
                (
                from a in _IsachRep.GetAllSach()
                select new SachView()
                {
                    Id = a.Id,
                    Name = a.Name,
                    IdTL = a.IdTL,
                    Ma = a.Ma,
                    BarCode = a.BarCode,
                    TG = a.TG,
                    NXB = a.NXB,
                    SoLuong = a.SoLuong,
                    GhiChu = a.GhiChu,
                    GiaTien = a.GiaTien,
                }
                ).ToList();
            return lst;
        }
        public string RemoveTN(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (_IsachRep.RemoveSach(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }
        public string UpdateTN(SachView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var sach = new Sach()
            {
                Id = obj.Id,
                Name = obj.Name,
                IdTL = obj.IdTL,
                Ma = obj.Ma,
                BarCode = obj.BarCode,
                TG = obj.TG,
                NXB = obj.NXB,
                SoLuong = obj.SoLuong,
                GhiChu = obj.GhiChu,
                GiaTien = obj.GiaTien,

            };
            if (_IsachRep.UpdateSach(sach)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
