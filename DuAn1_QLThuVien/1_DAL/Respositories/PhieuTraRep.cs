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
    public class PhieuTraRep : IPhieuTraRep
    {
        QL_ThuVienDbContext _context;
        public PhieuTraRep()
        {
            _context = new QL_ThuVienDbContext();
        }
        public bool AddPT(PhieuTra obj)
        {
            if (obj == null) return false;

            obj.Id = Guid.NewGuid();

            _context.phieuTras.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<PhieuTra> GetAllPT()
        {
            return _context.phieuTras.ToList();
        }


        
        public bool RemovePT(Guid obj)
        {
            if (obj == null) return false;
            var tempobj = _context.phieuTras.FirstOrDefault(c => c.Id == obj);

            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

            public bool UpdatePT(PhieuTra obj)
            {
                if (obj == null) return false;
                var tempobj = _context.phieuTras.FirstOrDefault(c => c.Id == obj.Id);
                tempobj.IdPM = obj.IdPM;
                tempobj.NgayTra = obj.NgayTra;
                tempobj.GhiChu = obj.GhiChu;

                _context.Update(tempobj);
                _context.SaveChanges();
                return true;
            }
        
    }
}
