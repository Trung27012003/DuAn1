using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRespositories
{
    public interface IChucVuRep
    {
        bool AddNV(ChucVu x);

        bool RemoveNV(ChucVu x);

        bool UpdateNV(ChucVu x);

        List<ChucVu> GetAllNV();
    }
}
