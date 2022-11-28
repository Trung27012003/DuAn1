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
    public class TheThanhVienServices : ITheThanhVienServices
    {//Duc ngu
        public ITheThanhVienRep _iTheThanhVienrep;
        public TheThanhVienServices()
        {
            _iTheThanhVienrep = new TheThanhVienRep();
        }
        public string AddTN(TheThanhVienView obj)
        {
            
            if (obj == null) return "Thêm không thành công!";
            var tn = new TheThanhVien()
             {
                        TenThanhVien = obj.TenThanhVien, 
                        NgayDangKi = obj.NgayDangKi,
                        NgayHetHan = obj.NgayHetHan,
                        SDT = obj.SDT,
                        DiaChi = obj.DiaChi,
                        NgaySinh = obj.NgaySinh,
                        GhiChu = obj.GhiChu

            };
            if (_iTheThanhVienrep.AddTTV(tn)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<TheThanhVienView> GetTheThanhVien()
        {
            List<TheThanhVienView> lst = new List<TheThanhVienView>();
            lst =
                (
                from a in _iTheThanhVienrep.GetAllTTVs()
                select new TheThanhVienView()
                {
                    Id = a.Id,
                    TenThanhVien = a.TenThanhVien,
                    NgayDangKi = a.NgayDangKi,
                    NgayHetHan = a.NgayHetHan,
                    SDT = a.SDT,
                    DiaChi = a.DiaChi,
                    NgaySinh = a.NgaySinh,
                    GhiChu = a.GhiChu
                }
                ).ToList();
            return lst;
        }

        public string RemoveTN(Guid obj)
        {

            if (obj == null) return "Xóa không thành công!";
            if (_iTheThanhVienrep.RemoveTTV(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string UpdateTN(TheThanhVienView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var tn = new TheThanhVien()
            {
                Id = obj.Id,
                TenThanhVien = obj.TenThanhVien,
                NgayDangKi = obj.NgayDangKi,
                NgayHetHan = obj.NgayHetHan,
                SDT = obj.SDT,
                DiaChi = obj.DiaChi,
                NgaySinh = obj.NgaySinh,
                GhiChu = obj.GhiChu

            };
            if (_iTheThanhVienrep.UpdateTTV(tn)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
