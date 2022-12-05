using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_DAL.IRespositories
{
    public interface ITheLoaiRep
    {
        bool AddTL(TheLoai obj);

        bool RemoveTL(Guid obj);

        bool UpdateTL(TheLoai obj);

        List<TheLoai> GetAllTL();
    }
}
