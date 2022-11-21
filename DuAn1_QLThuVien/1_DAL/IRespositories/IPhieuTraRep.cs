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
        bool AddPT(PhieuTra pt);

        bool DeletePT(PhieuTra pt);

        bool UpdatePT(PhieuTra pt);

        PhieuTra GetPT(Guid id);

        List<PhieuTra> GetAllPT();
    }
}
