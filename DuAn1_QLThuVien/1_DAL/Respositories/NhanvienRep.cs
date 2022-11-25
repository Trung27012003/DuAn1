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

    internal class NhanvienRep : INhanVienRep
    {
        QL_ThuVienDbContext _context;
        public NhanvienRep()
        {
            _context = new QL_ThuVienDbContext();
        }

        public bool AddNV(NhanVien obj)
        {

            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.nhanViens.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<NhanVien> GetAllNV()
        {
            return _context.nhanViens.ToList();
        }

        public bool RemoveNV(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _context.nhanViens.FirstOrDefault(c => c.Id == obj.Id);

            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateNV(NhanVien obj)
        {
            if (obj == null) return false;
            var tempobj = _context.nhanViens.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Name = obj.Name;
            tempobj.DiaChi = obj.DiaChi;
            tempobj.NgaySinh = obj.NgaySinh;
            tempobj.SDT = obj.SDT;
            _context.Update(tempobj);
            _context.SaveChanges();
            return true;
        }
    } 
   
}
