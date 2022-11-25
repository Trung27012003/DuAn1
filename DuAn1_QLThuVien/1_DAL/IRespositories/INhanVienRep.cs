using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _1_DAL.IRespositories
{
    public interface INhanVienRep
    {
        bool AddNV(NhanVien x);

        bool RemoveNV(Guid x);

        bool UpdateNV(NhanVien x);

        List<NhanVien> GetAllNV();
    }
}
