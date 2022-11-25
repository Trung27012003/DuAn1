using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _1_DAL.IRespositories
{
    public interface ISachRep
    {
        bool AddSach(Sach x);

        bool RemoveSach(Guid x);

        bool UpdateSach(Sach x);

        List<Sach> GetAllSach();
    }
}
