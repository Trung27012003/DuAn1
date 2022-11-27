using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IPhieuTraChiTietServices
    {//Duc ngu si dan
        List<PhieuTraChiTiet> GetPhieuTraChiTiet();
        string AddTN(PhieuTraChiTiet obj);
        string RemoveTN(PhieuTraChiTiet obj);
        string UpdateTN(PhieuTraChiTiet obj);
    }
}
