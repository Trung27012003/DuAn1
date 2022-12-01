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
    public class TheNgayServices : ITheNgayServices
    {//Duc ngu
        public INhanVienRep _nvRep;
        public ITheNgayRep _itheNgayRep;
        public TheNgayServices()
        {
            _nvRep = new NhanvienRep();
            _itheNgayRep = new TheNgayRep();
        }
        public string AddTN(TheNgayView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var tn = new TheNgay()
            {
                IdNV = obj.IdNV,
               StartTime = obj.StartTime,
               EndTime = obj.EndTime,
               GhiChu = obj.GhiChu

            };
            if (_itheNgayRep.AddTN(tn)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<TheNgayView> GetTheNgay()
        {
            List<TheNgayView> lst = new List<TheNgayView>();
            lst =
                (
                from a in _itheNgayRep.GetAllTNs()

                join b in _nvRep.GetAllNV() on a.IdNV equals b.Id
                select new TheNgayView()
                {
                    Id = a.Id,
                    IdNV = a.IdNV,
                    StartTime = a.StartTime,
                    EndTime = a.EndTime,
                    GhiChu = a.GhiChu
                }
                ).ToList();
            return lst;
        }
        public string RemoveTN(Guid obj)
        {
                if (obj == null) return "Xóa không thành công!";
                if (_itheNgayRep.RemoveTN(obj)) return "Xóa  thành công!";
                return "Xóa không thành công!";
            }

        public string UpdateTN(TheNgayView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var tn = new TheNgay()
            {
                Id = obj.Id,
                IdNV = obj.IdNV,
                StartTime = obj.StartTime,
                EndTime = obj.EndTime,
                GhiChu = obj.GhiChu

            };
            if (_itheNgayRep.UpdateTN(tn)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
