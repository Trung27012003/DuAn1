using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IChucVuServices
    {//Duc ngu
        List<ChucVu> GetTheNgay();
        string AddTN(ChucVu cv);
        string RemoveTN(ChucVu cv);
        string UpdateTN(ChucVu cv);
    }
}
