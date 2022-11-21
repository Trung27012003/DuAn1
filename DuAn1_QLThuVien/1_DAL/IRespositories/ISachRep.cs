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
        bool AddS(Sach s);

        bool DeleteS(Sach s);

        bool UpdateS(Sach s);

        Sach GetS(Guid id);

        List<Sach> GetAllS();
    }
}
