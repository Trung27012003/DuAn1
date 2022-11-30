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

            obj.Id = Guid.NewGuid();

            _context.phieuMuonChiTiets.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<PhieuMuonChiTiet> GetAllPMCT()
        {
            return _context.phieuMuonChiTiets.ToList();
        }


        


            public bool RemovePMCT(Guid obj)
            {
                if (obj == null) return false;
                var tempobj = _context.phieuMuonChiTiets.FirstOrDefault(c => c.Id == obj);

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

                tempobj.SoLuong = obj.SoLuong;
                tempobj.TienTheChan = obj.TienTheChan;
                tempobj.GhiChu = obj.GhiChu;
                tempobj.DieuKien = obj.DieuKien;
                _context.Update(tempobj);
                _context.SaveChanges();
                return true;
            }
        }
    }

