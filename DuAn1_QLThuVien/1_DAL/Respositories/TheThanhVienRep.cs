﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Context;
using _1_DAL.Models;
using _1_DAL.IRespositories;

namespace _1_DAL.Respositories
{
    public class TheThanhVienRep : ITheThanhVienRep
    {
        private List<TheThanhVien> _listttv;
        private QL_ThuVienDbContext _context;

        public TheThanhVienRep()
        {
            _listttv = new List<TheThanhVien>();
            _context = new QL_ThuVienDbContext();
        }

        public bool AddTTV(TheThanhVien x)
        {
            _context.Add(x);
            _context.SaveChanges();
            return true;
        }

        public bool RemoveTTV(TheThanhVien x)
        {
            _context.Remove(x);
            _context.SaveChanges();
            return true;
        }

        public bool UpdateTTV(TheThanhVien x)
        {
            _context.Update(x);
            _context.SaveChanges();
            return true;
        }
        public List<TheThanhVien> GetAllTTVs()
        {
           _listttv = _context.theThanhViens.ToList();
            return _listttv;
        }
    }
}
