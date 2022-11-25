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
    public class PhieuMuonRep : IPhieuMuonRep
    {
        QL_ThuVienDbContext _context;
        public PhieuMuonRep()
        {
            _context = new QL_ThuVienDbContext();
        }
        public bool AddPM(PhieuMuon obj)
        {
            if (obj == null) return false;
            obj.Id = Guid.NewGuid();
            _context.phieuMuons.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<PhieuMuon> GetAllPM()
        {
            return _context.phieuMuons.ToList();
        }

        public bool RemovePM(PhieuMuon obj)
        {
            if (obj == null) return false;
            var tempobj = _context.phieuMuons.FirstOrDefault(c => c.Id == obj.Id);

            _context.Remove(tempobj);
            _context.SaveChanges();
            return true;
        }

        public bool UpdatePM(PhieuMuon obj)
        {
            if (obj == null) return false;
            var tempobj = _context.phieuMuons.FirstOrDefault(c => c.Id == obj.Id);
            tempobj.NgayMuon = obj.NgayMuon;
            tempobj.NgayTra = obj.NgayTra;
            tempobj.GhiChu = obj.GhiChu;
            tempobj.IdTheTV = obj.IdTheTV;
            tempobj.IdNV = obj.IdNV;
            

            _context.Update(tempobj);
            _context.SaveChanges();
            return true;
        }
    }
}
