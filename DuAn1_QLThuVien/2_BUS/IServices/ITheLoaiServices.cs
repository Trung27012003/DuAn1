using _1_DAL.Models;
using _2_BUS.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2_BUS.IServices
{
    public interface ITheLoaiServices
    {
        string AddTL(TheLoaiView obj);

        string RemoveTL(Guid obj);

        string UpdateTL(TheLoaiView obj);

        List<TheLoaiView> GetAllTL();
    }
}
