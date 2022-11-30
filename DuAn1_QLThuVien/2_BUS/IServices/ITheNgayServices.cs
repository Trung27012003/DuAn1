using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;
using _2_BUS.ViewModels;

namespace _2_BUS.IServices
{
    public interface ITheNgayServices
    {//Duc ngu
        List<TheNgayView> GetTheNgay();
        string AddTN(TheNgayView obj);
        string RemoveTN(Guid obj);
        string UpdateTN(TheNgayView obj);
    }
}
