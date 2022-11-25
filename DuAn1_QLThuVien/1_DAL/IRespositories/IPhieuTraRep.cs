using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _1_DAL.IRespositories
{
    public interface IPhieuTraRep
    {
        bool AddPT(PhieuTra x);

        bool RemovePT(Guid x);

        bool UpdatePT(PhieuTra x);

        List<PhieuTra> GetAllPT();
    }
}
