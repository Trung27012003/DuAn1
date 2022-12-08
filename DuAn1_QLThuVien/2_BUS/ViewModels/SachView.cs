using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class SachView
    {
        public Guid Id { get; set; }
        public Guid? IdTL { get; set; }
        public string? TG { get; set; }
        public string? Ma { get; set; }
        public string? BarCode { get; set; }
        public string? NXB { get; set; }
        public string? Name { get; set; }
        public int? SoLuong { get; set; }
        public int? GiaTien { get; set; }
        public string? GhiChu { get; set; }
}
}
