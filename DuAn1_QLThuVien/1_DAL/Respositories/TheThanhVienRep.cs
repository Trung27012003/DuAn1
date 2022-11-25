using _1_DAL.Context;
using _1_DAL.IRespositories;
using _1_DAL.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Respositories
{

    public class TheThanhVienRep : ITheThanhVienRep
    {
        QL_ThuVienDbContext _context;
        public TheThanhVienRep()
        {
            _context = new QL_ThuVienDbContext();
        }
        public bool AddTTV(TheThanhVien obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.theThanhViens.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<TheThanhVien> GetAllTTVs()
        {
            return _context.theThanhViens.ToList();
        }

        public bool RemoveTTV(TheThanhVien obj)
        {
            if (obj == null) return false;
            var tempobj = _context.theThanhViens.FirstOrDefault(c => c.Id == obj.Id);

            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateTTV(TheThanhVien obj)
        {
            if(obj == null) return false;
            var tempobj = _context.theThanhViens.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.TenThanhVien = obj.TenThanhVien;
            tempobj.NgayDangKi = obj.NgayDangKi;
            tempobj.NgayHetHan = obj.NgayHetHan;
            tempobj.SDT = obj.SDT;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.GhiChu = obj.GhiChu;
            _context.Update(tempobj);
            _context.SaveChanges();
            return true;
        }

        
    }
}
