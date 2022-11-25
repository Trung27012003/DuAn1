using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _1_DAL.Models;

namespace _2_BUS.IServices
{
    public interface ITheNgayServices
    {
        List<TheNgay> GetTheNgay();
        bool AddTN(TheNgay obj);
        bool RemoveTN(TheNgay obj);
        bool UpdateTN(TheNgay obj);
    }
}
