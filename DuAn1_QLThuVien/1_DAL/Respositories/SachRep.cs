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
    public class SachRep : ISachRep
    {
        private List<Sach> _listnv;
        private QL_ThuVienDbContext _context;

        public SachRep()
        {
            _listnv = new List<Sach>();
            _context = new QL_ThuVienDbContext();
        }

        public bool AddSach(Sach x)
        {
            _context.Add(x);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveSach(Sach x)
        {
            _context.Remove(x);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateSach(Sach x)
        {
            _context.Update(x);
            _context.SaveChanges();
            return true;
        }
        public List<Sach> GetAllSach()
        {
            _listnv = _context.sachs.ToList();
            return _listnv;
        }
    }
}
