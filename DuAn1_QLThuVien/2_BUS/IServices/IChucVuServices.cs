using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IChucVuServices
    {//Duc ngu
        List<ChucVuView> GetTheNgay();
        string AddTN(ChucVuView cv);
        string RemoveTN(Guid cv);
        string UpdateTN(ChucVuView cv);
    }
}
