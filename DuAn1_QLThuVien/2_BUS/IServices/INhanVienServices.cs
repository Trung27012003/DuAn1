using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public  interface INhanVienServices
    {//Duc ngu
        List<NhanVienView> GetNhanVien();
        string AddTN(NhanVienView nv);
        string RemoveTN(Guid nv);
        string UpdateTN(NhanVienView nv);
    }
}
