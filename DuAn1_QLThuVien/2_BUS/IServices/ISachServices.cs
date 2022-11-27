using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ISachServices
    {//Duc ngu
        List<Sach> GetSach();
        string AddTN(Sach obj);
        string RemoveTN(Guid obj);
        string UpdateTN(Sach obj);
    }
}
