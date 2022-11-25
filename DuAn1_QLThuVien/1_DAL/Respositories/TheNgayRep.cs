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
    public class TheNgayRep : ITheNgayRep
    {
        QL_ThuVienDbContext _context;
        public TheNgayRep()
        {
            _context = new QL_ThuVienDbContext();
        }
        public bool AddTN(TheNgay obj)
        {
            if (obj == null) return false;
            _context.theNgays.Add(obj);
            _context.SaveChanges();
            return true;
        }

        public List<TheNgay> GetAllTNs()
        {
            return _context.theNgays.ToList();
        }

        public bool RemoveTN(TheNgay x)
        {
            throw new NotImplementedException();
        }

        public bool UpdateTN(TheNgay x)
        {
            throw new NotImplementedException();
        }
    }
}
