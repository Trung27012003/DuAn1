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
        bool AddTTV(TheThanhVien ttv);

        bool DeleteTTV(TheThanhVien ttv);

        bool UpdateTTV(TheThanhVien ttv);

        TheThanhVien GetTTV(Guid id);

        List<TheThanhVien> GetAllTTV();
    }
}
