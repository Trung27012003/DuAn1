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
    public class TheLoaiRep:ITheLoaiRep
    {
        QL_ThuVienDbContext _context;
        public TheLoaiRep()
        {
            _context = new QL_ThuVienDbContext();
        }
        public bool AddTL(TheLoai obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.theLoais.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<TheLoai> GetAllTL()
        {
            return _context.theLoais.ToList();
        }

        public bool RemoveTL(Guid obj)
        {
            if (obj == null) return false;
            var tempobj = _context.theLoais.FirstOrDefault(c => c.Id == obj);
            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateTL(TheLoai obj)
        {
            if (obj == null) return false;
            var tempobj = _context.theLoais.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.Name = obj.Name;
            _context.Update(tempobj);
            _context.SaveChanges();
            return true;
        }
    }
}
