using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class PhieuMuonChiTietView
    {
        public Guid Id { get; set; }
        public Guid? IdPM { get; set; }
        public Guid? IdSach { get; set; }
        public int? SoLuong { get; set; }
        public string? DieuKien { get; set; }
        public string? GhiChu { get; set; }
        public int? TienTheChan { get; set; }
     
    }
}
