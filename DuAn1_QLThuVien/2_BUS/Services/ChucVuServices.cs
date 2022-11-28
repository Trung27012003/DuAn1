using _1_DAL.IRespositories;
using _1_DAL.Models;
using _1_DAL.Respositories;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.Services
{
    public class ChucVuServices : IChucVuServices
    {
        private IChucVuRep _IChucVuRep;
        //private ChucVuView _view;
        public ChucVuServices()
        {
            _IChucVuRep = new ChucVuRep();
            //_view = new ChucVuView();
        }
        public string AddTN(ChucVuView obj)
        {
            if (obj == null) return "Thêm không thành công!";
            var ChucVu = new ChucVu()
            {
               Name= obj.Name,

            };
            if (_IChucVuRep.AddNV(ChucVu)) return "Thêm  thành công!";
            return "Thêm không thành công!";
        }

        public List<ChucVuView> GetTheNgay()
        {
            List<ChucVuView> lst = new List<ChucVuView>();
            lst =
                (
                from a in _IChucVuRep.GetAllNV()
                select new ChucVuView()
                {
                    Id = a.Id,
                    Name= a.Name,
                }
                ).ToList();
            return lst;
        }

        public string RemoveTN(Guid obj)
        {
            if (obj == null) return "Xóa không thành công!";
            if (_IChucVuRep.RemoveNV(obj)) return "Xóa  thành công!";
            return "Xóa không thành công!";
        }

        public string UpdateTN(ChucVuView obj)
        {
            if (obj == null) return "Sửa không thành công!";
            var ChucVu = new ChucVu()
            {
                Id = obj.Id,
                Name = obj.Name,

            };
            if (_IChucVuRep.UpdateNV(ChucVu)) return "Sửa  thành công!";
            return "Sửa không thành công!";
        }
    }
}
