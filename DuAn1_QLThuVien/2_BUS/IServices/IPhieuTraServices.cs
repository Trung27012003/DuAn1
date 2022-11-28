using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IPhieuTraServices
    {//Duc ngu
        List<PhieuTraView> GetPhieuTra();
        string AddTN(PhieuTraView obj);
        string RemoveTN(Guid obj);
        string UpdateTN(PhieuTraView obj);
    }
}
