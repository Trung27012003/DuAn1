using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.Models
{
    public class PhieuTraChiTiet
    {
        public Guid Id { get; set; }
        public Guid? IdPT { get; set; }
        public Guid? IdSach { get; set; }
        public int? SoLuong { get; set; }
        public string? TinhTrang { get; set; }
        public string? GhiChu { get; set; }
        public virtual Sach Sach { get; set; }
        public virtual PhieuTra PhieuTra { get; set; }

    }
}
