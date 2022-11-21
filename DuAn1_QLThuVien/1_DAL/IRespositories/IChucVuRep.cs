using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _1_DAL.IRespositories
{
    public interface IChucVuRep
    {
        bool AddCV(ChucVu cv);

        bool DeleteCV(ChucVu cv);

        bool UpdateCV(ChucVu cv);

        TheThanhVien GetCV(Guid id);

        List<ChucVu> GetAllCV();
    }
}
