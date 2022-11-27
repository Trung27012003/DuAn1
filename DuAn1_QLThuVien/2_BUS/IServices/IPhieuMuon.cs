using _1_DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IPhieuMuon
    {//Duc ngu
        List<PhieuMuon> GetPhieuMuon();
        string AddTN(PhieuMuon obj);
        string RemoveTN(Guid obj);
        string UpdateTN(PhieuMuon obj);
    }
}
