using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _1_DAL.IRespositories
{
    public interface ITheThanhVienRep
    {
        bool AddTTV(TheThanhVien x);

        bool RemoveTTV(TheThanhVien x);

        bool UpdateTTV(TheThanhVien x);

        List<TheThanhVien> GetAllTTVs();
    }
}
