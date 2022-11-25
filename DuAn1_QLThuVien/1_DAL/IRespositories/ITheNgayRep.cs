using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
namespace _1_DAL.IRespositories
{
    public interface ITheNgayRep
    {
        bool AddTN(TheNgay x);

        bool RemoveTN(TheNgay x);

        bool UpdateTN(TheNgay x);

        List<TheNgay> GetAllTNs();
    }
}
