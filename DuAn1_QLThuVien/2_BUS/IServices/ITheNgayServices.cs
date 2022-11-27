using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _2_BUS.IServices
{
    public interface ITheNgayServices
    {//Duc ngu
        List<TheNgay> GetTheNgay();
        string AddTN(TheNgay obj);
        string RemoveTN(Guid obj);
        string UpdateTN(TheNgay obj);
    }
}
