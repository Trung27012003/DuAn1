using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class PhieuTraChiTietView
    {
        public Guid Id { get; set; }
        public Guid? IdPT { get; set; }
        public Guid? IdSach { get; set; }
        public int? SoLuong { get; set; }
        public int? TinhTrang { get; set; }
        public string? GhiChu { get; set; }
        
    }
}
