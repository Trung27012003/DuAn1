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
    public class TheNgayRep : ITheNgayRep
    {
        private List<TheNgay> _listnv;
        private QL_ThuVienDbContext _context;

        public TheNgayRep()
        {
            _listnv = new List<TheNgay>();
            _context = new QL_ThuVienDbContext();
        }

        public bool AddTN(TheNgay x)
        {
            _context.Add(x);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveTN(TheNgay x)
        {
            _context.Remove(x);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateTN(TheNgay x)
        {
            _context.Update(x);
            _context.SaveChanges();
            return true;
        }
        public List<TheNgay> GetAllTNs()
        {
            _listnv = _context.theNgays.ToList();
            return _listnv;
        }
    }
}
