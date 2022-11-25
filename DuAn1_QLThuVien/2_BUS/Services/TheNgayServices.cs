using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using _2_BUS.IServices;
using _2_BUS.ViewModels;
using _1_DAL.Models;
using _1_DAL.IRespositories;
using _1_DAL.Respositories;
namespace _2_BUS.Services
{
    public class TheNgayServices : ITheNgayServices
    {
        private ITheNgayRep _thengay;
        private List<TheNgay> _listtn;

        public TheNgayServices()
        {
            _listtn = new List<TheNgay>();
            _thengay = new TheNgayRep();
        }

        public bool AddTN(TheNgay x)
        {
            _thengay.AddTN(x);
            return true;
        }

        public bool RemoveTN(TheNgay x)
        {
            _thengay.RemoveTN(x);
            return true;
        }

        public List<TheNgay> GetTheNgay()
        {
            _listtn = _thengay.GetAllTNs();
            return _listtn;
        }

        public bool UpdateTN(TheNgay x)
        {
            _thengay.UpdateTN(x);
            return true;
        }
    }
}
