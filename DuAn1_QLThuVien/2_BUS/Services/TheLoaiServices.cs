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
    public class TheLoaiServices:ITheLoaiServices
    {
        private ITheLoaiRep _ITheLoaiRep;
        public TheLoaiServices()
        {
            _ITheLoaiRep = new TheLoaiRep();
        }
        public string AddTL(TheLoaiView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var TheLoai = new TheLoai()
            {
                Name = obj.Name,

            };
            if (_ITheLoaiRep.AddTL(TheLoai)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<TheLoaiView> GetAllTL()
        {
            List<TheLoaiView> lst = new List<TheLoaiView>();
            lst =
                (
                from a in _ITheLoaiRep.GetAllTL()
                select new TheLoaiView()
                {
                    Id = a.Id,
                    Name = a.Name,
                }
                ).ToList();
            return lst;
        }

        public string RemoveTL(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (_ITheLoaiRep.RemoveTL(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string UpdateTL(TheLoaiView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var TheLoai = new TheLoai()
            {
                Id = obj.Id,
                Name = obj.Name,

            };
            if (_ITheLoaiRep.UpdateTL(TheLoai)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
