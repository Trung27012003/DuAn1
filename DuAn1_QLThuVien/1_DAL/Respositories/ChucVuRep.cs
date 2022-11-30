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
    public class ChucVuRep : IChucVuRep
    {
        QL_ThuVienDbContext _context;
        public ChucVuRep() 
        {
            _context = new QL_ThuVienDbContext();
        } 
        public bool AddNV(ChucVu obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.chucVus.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<ChucVu> GetAllNV()
        {
            return _context.chucVus.ToList();
        }

        public bool RemoveNV(Guid obj)
        {
            if (obj == null) return false;
            var tempobj = _context.chucVus.FirstOrDefault(c => c.Id == obj);
            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateNV(ChucVu obj)
        {
            if (obj == null) return false;
            var tempobj = _context.chucVus.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Name = obj.Name;
            _context.Update(tempobj);
            _context.SaveChanges();
            return true;
        }
    }
}
