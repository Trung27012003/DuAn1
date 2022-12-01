using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using _2_BUS.IServices;
using _2_BUS.Services;
using _2_BUS.ViewModels;
namespace _3_PL.Views
{
    public partial class MuonTraForm : Form
    {
        private ITheThanhVienServices _ttvservices;
        private INhanVienServices _nhanvienservices;

        public MuonTraForm()
        {
            InitializeComponent();
            _ttvservices  = new TheThanhVienServices();
            _nhanvienservices = new NhanVienServices();
        }
      private void LoadToDS()
        {
            dtg_ds.Rows.Clear();
            int stt;
            
        }
    }
}
