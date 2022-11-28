using _1_DAL.IRespositories;
using _1_DAL.Models;
using _1_DAL.Respositories;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class SachServices : ISachServices
    {
        public ISachRep _IsachRep;
        public SachServices()
        {
            _IsachRep = new SachRep();
        }
        public string AddTN(SachView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var sach = new SachView()
            {
                Name = obj.Name,
                TL = obj.TL,
                TG = obj.TG,
                NXB = obj.NXB,
                SoLuong =  obj.SoLuong,
                GhiChu = obj.GhiChu,
                GiaTien = obj.GiaTien,

            };
            //if (_IsachRep.AddSach(sach)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<SachView> GetSach()
        {
            List<SachView> lst = new List<SachView>();
            lst =
                (
                from a in _IsachRep.GetAllSach()
                select new SachView()
                {
                    Id = a.Id,
                    Name = a.Name,
                }
                ).ToList();
            return lst;
        }

        public string RemoveTN(Guid obj)
        {
            throw new NotImplementedException();
        }

        public string UpdateTN(SachView obj)
        {
            throw new NotImplementedException();
        }
    }
}
