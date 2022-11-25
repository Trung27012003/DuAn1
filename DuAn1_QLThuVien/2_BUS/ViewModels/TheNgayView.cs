using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _2_BUS.ViewModels
{
    public class TheNgayView
    {
        public Guid Id { get; set; }
        public Guid? IdNV { get; set; }
        public DateTime? StartTime { get; set; }
        public DateTime? EndTime { get; set; }
        public string? GhiChu { get; set; }
        
    }
}
