using _1_DAL.IRespositories;
using _1_DAL.Respositories;
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
    public class NhanVienServices : INhanVienServices
    {//Duc ngu
        INhanVienRep _INhanVienRep;
        IChucVuRep _IChucVuRep;
        public NhanVienServices()
        {
            _INhanVienRep = new NhanvienRep();
            _IChucVuRep = new ChucVuRep();
        }
        public string AddTN(NhanVienView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var NhanVien = new NhanVien()
            {

                Name = obj.Name,
                IdCV = obj.IdCV,
                DiaChi = obj.DiaChi,
                SDT =obj.SDT,
                NgaySinh = obj.NgaySinh,

            };
            if (_INhanVienRep.AddNV(NhanVien)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<NhanVienView> GetAllNv()
        {
            List<NhanVienView> lst = new List<NhanVienView>();
            lst =
                (
                from a in _INhanVienRep.GetAllNV() 
                select new NhanVienView()
                {
                    Id = a.Id,
                    Name = a.Name,
                    IdCV =a.IdCV,
                    DiaChi = a.DiaChi,
                    SDT = a.SDT,
                    NgaySinh = a.NgaySinh,
                }
                ).ToList();
            return lst;
        }

        public string RemoveTN(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (_INhanVienRep.RemoveNV(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";

        }

        public string UpdateTN(NhanVienView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var NhanVien = new NhanVien()
            {
                Id = obj.Id,
                Name = obj.Name,
                IdCV = obj.IdCV,
                DiaChi = obj.DiaChi,
                SDT = obj.SDT,
                NgaySinh = obj.NgaySinh,

            };
            if (_INhanVienRep.UpdateNV(NhanVien)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
