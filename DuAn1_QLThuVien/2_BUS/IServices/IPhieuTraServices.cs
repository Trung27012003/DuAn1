using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IPhieuTraServices
    {//Duc ngu
        List<PhieuTra> GetPhieuTra();
        string AddTN(PhieuTra obj);
        string RemoveTN(PhieuTra obj);
        string UpdateTN(PhieuTra obj);
    }
}
