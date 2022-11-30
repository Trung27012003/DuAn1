using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _2_BUS.ViewModels
{
    public class NhanVienView
    {
        public Guid Id { get; set; }
        public Guid? IdCV { get; set; }
        public string? Name { get; set; }
        public string? DiaChi { get; set; }
        public DateTime? NgaySinh { get; set; }
        public string? SDT { get; set; }
      
    }
}
