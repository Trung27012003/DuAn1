using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Context;
using _1_DAL.Models;
using _1_DAL.IRespositories;
namespace _1_DAL.Respositories
{
    public class NhanVienRep : INhanVienRep
    {
        private List<NhanVien> _listnv;
        private QL_ThuVienDbContext _context;

        public NhanVienRep()
        {
            _listnv = new List<NhanVien>();
            _context = new QL_ThuVienDbContext();
        }

        public bool AddNV(NhanVien x)
        {
            _context.Add(x);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveNV(NhanVien x)
        {
            _context.Remove(x);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateNV(NhanVien x)
        {
            _context.Update(x);
            _context.SaveChanges();
            return true;
        }
        public List<NhanVien> GetAllNV()
        {
            _listnv = _context.nhanViens.ToList();
            return _listnv;
        }
    }
}
