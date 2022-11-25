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
    public class PhieuMuonChiTietRep : IPhieuMuonCTRep
    {
        QL_ThuVienDbContext _context;
        public PhieuMuonChiTietRep()
        {
            _context = new QL_ThuVienDbContext();
        }
        public bool AddPMCT(PhieuMuonChiTiet obj)
        {
            if (obj == null) return false;
<<<<<<< HEAD
            obj.Id = Guid.NewGuid();
=======
>>>>>>> 8940fc1cc29b98957af892c6825ca4b30cbc89cc
            _context.phieuMuonChiTiets.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<PhieuMuonChiTiet> GetAllPMCT()
        {
            return _context.phieuMuonChiTiets.ToList();
        }

<<<<<<< HEAD
        public bool RemovePMCT(PhieuMuonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _context.nhanViens.FirstOrDefault(c => c.Id == obj.Id);

=======
        public bool RemovePMCT(Guid obj)
        {
            if (obj == null) return false;
            var tempobj = _context.phieuMuonChiTiets.FirstOrDefault(c => c.Id == obj);
>>>>>>> 8940fc1cc29b98957af892c6825ca4b30cbc89cc
            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public bool UpdatePMCT(PhieuMuonChiTiet obj)
        {
            if (obj == null) return false;
            var tempobj = _context.phieuMuonChiTiets.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.IdSach = obj.IdSach;
            tempobj.IdPM = obj.IdPM;
<<<<<<< HEAD
            tempobj.SoLuong = obj.SoLuong;
            tempobj.TienTheChan = obj.TienTheChan;
            tempobj.GhiChu = obj.GhiChu;
            tempobj.DieuKien = obj.DieuKien;
            
=======
            tempobj.DieuKien = obj.DieuKien;
            tempobj.SoLuong = obj.SoLuong;
            tempobj.DieuKien = obj.DieuKien;
            tempobj.GhiChu = obj.GhiChu;
            tempobj.TienTheChan = obj.TienTheChan;
>>>>>>> 8940fc1cc29b98957af892c6825ca4b30cbc89cc
            _context.Update(tempobj);
            _context.SaveChanges();
            return true;
        }
    }
}
