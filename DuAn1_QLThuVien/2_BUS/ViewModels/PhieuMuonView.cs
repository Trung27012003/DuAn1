using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class PhieuMuonView
    {
        public Guid Id { get; set; }
        public Guid? IdTheTV { get; set; }
        public Guid? IdNV { get; set; }
        public string? MaPm { get; set; }
        public DateTime? NgayMuon { get; set; }
        public DateTime? NgayTra { get; set; }
        public string? GhiChu { get; set; }
    }
}
