using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public  interface INhanVienServices
    {//Duc ngu
        List<NhanVien> GetNhanVien();
        string AddTN(NhanVien nv);
        string RemoveTN(NhanVien nv);
        string UpdateTN(NhanVien nv);
    }
}
