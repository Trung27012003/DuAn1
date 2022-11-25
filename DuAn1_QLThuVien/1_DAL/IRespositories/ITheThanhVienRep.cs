using System;
using System.Collections.Generic;
using System.Linq;

using System.Threading.Tasks;
using _1_DAL.Models;
namespace _1_DAL.IRespositories
{
    public interface ITheThanhVienRep
    {
        bool AddTTV(TheThanhVien obj);

        bool RemoveTTV(Guid obj);

        bool UpdateTTV(TheThanhVien obj);

        List<TheThanhVien> GetAllTTVs();
    }
}
