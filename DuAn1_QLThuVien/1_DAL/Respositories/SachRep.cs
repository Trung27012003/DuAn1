using _1_DAL.Context;
using _1_DAL.IRespositories;
using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Respositories
{
    public class SachRep : ISachRep
    {
        QL_ThuVienDbContext _context;
        public SachRep()
        {
            _context = new QL_ThuVienDbContext();
        }
        public bool AddSach(Sach obj)
        {
            if (obj == null) return false;

            obj.Id = Guid.NewGuid();

            _context.sachs.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<Sach> GetAllSach()
        {
            return _context.sachs.ToList();
        }


        
        public bool RemoveSach(Guid  obj)
        {
            if (obj == null) return false;
            var tempobj = _context.sachs.FirstOrDefault(c => c.Id == obj);

            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateSach(Sach obj)
        {

            if (obj == null) return false;
            var tempobj = _context.sachs.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.IdTL = obj.IdTL;
            tempobj.TG = obj.TG;

            tempobj.Name = obj.Name;
            tempobj.SoLuong = obj.SoLuong;
            tempobj.GiaTien = obj.GiaTien;
            tempobj.NXB = obj.NXB;
            tempobj.GhiChu = obj.GhiChu;


            

            _context.Update(tempobj);
            _context.SaveChanges();
            return true;
        }
    }
}
