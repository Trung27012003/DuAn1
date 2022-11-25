using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public  interface INhanVienServices
    {
        List<NhanVien> GetNhanVien();
        bool AddTN(NhanVien nv);
        bool RemoveTN(NhanVien nv);
        bool UpdateTN(NhanVien nv);
    }
}
