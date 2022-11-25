using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IChucVuServices
    {
        List<ChucVu> GetTheNgay();
        bool AddTN(ChucVu cv);
        bool RemoveTN(ChucVu cv);
        bool UpdateTN(ChucVu cv);
    }
}
