using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface IPhieuMuonServices
    {//Duc ngu
        List<PhieuMuonView> GetPhieuMuon();
        string AddTN(PhieuMuonView obj);
        string RemoveTN(Guid obj);
        string UpdateTN(PhieuMuonView obj);
    }
}
