using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.ViewModels
{
    public class PhieuTraView
    {
        public Guid Id { get; set; }
        public Guid? IdPM { get; set; }
        public DateTime? NgayTra { get; set; }
        public string? GhiChu { get; set; }
       
    }
}
