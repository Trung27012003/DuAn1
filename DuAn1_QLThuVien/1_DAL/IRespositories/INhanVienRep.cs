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
        bool AddNV(NhanVien nv);

        bool DeleteNV(NhanVien nv);

        bool UpdateNV(NhanVien nv);

        NhanVien GetNV(Guid id);

        List<NhanVien> GetAllNV();
    }
}
