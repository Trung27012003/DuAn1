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
        bool AddTN(TheNgay HangSX);
        bool RemoveTN(TheNgay HangSX);
        bool UpdateTN(TheNgay HangSX);
    }
}
