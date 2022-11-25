using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ISachServices
    {
        List<Sach> GetSach();
        bool AddTN(Sach obj);
        bool RemoveTN(Sach obj);
        bool UpdateTN(Sach obj);
    }
}
