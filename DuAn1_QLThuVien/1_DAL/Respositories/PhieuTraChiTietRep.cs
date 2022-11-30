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
    public class PhieuTraChiTietRep : IPhieuTraCTRep
    {
        QL_ThuVienDbContext _context;
        public PhieuTraChiTietRep()
        {
            _context = new QL_ThuVienDbContext();

        }
        public bool AddPTCT(PhieuTraChiTiet obj)
        {
            if (obj == null) return false;
            _context.phieuTraChiTiets.Add(obj);
            _context.SaveChanges();
            return true;
        }
        public List<PhieuTraChiTiet> GetAllPTCT()
        {
            return _context.phieuTraChiTiets.ToList();
        }

        public bool RemovePTCT(Guid obj)
        {
            if (obj == null) return false;
            var tempobj = _context.phieuTraChiTiets.FirstOrDefault(c => c.Id == obj);
            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public bool UpdatePTCT(PhieuTraChiTiet obj)
        {

            if (obj == null) return false;
            var tempobj = _context.phieuTraChiTiets.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.IdPT = obj.IdPT;
            tempobj.IdSach = obj.IdSach;
            tempobj.SoLuong = obj.SoLuong;
            tempobj.TinhTrang = obj.TinhTrang;
            tempobj.GhiChu = obj.GhiChu;
            _context.Update(tempobj);
            _context.SaveChanges();
            return true;
        }
    }
}
