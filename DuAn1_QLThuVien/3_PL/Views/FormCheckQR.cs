using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;
using System.IO;
using ZXing.Aztec;
using AForge;
using ZXing.QrCode;
namespace _3_PL.Views
{
    public partial class FormCheckQR : Form
    {
        public FormCheckQR()
        {
            InitializeComponent();
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice CaptureDevice;
        private void btn_batcam_Click(object sender, EventArgs e)
        {
            if (btn_batcam.Text == "Start")
            {
                CaptureDevice = new VideoCaptureDevice(filterInfoCollection[cbb_chon.SelectedIndex].MonikerString);
                CaptureDevice.NewFrame += CaptureDevice_NewFrame;
                CaptureDevice.Start();
                timer1.Start();
                btn_batcam.Text = "Stop";
            }

            else
            {
                CaptureDevice.SignalToStop();
                timer1.Stop();
                ptb_camera.Image = null;
                btn_batcam.Text = "Start";


            }
        }
        private void CaptureDevice_NewFrame(object sender, AForge.Video.NewFrameEventArgs eventArgs)
        {
            ptb_camera.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (ptb_camera.Image != null)
            {
                BarcodeReader reader = new BarcodeReader();
                Result resul = reader.Decode((Bitmap)ptb_camera.Image);
                if (resul != null)
                {

                    if (CaptureDevice.IsRunning == true)
                    {
                        rtb_showtt.Text = resul.ToString();
                        timer1.Stop();

                    }
                }
            }
        }

        private void FormCheckQR_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            CaptureDevice = new VideoCaptureDevice();
            foreach (FilterInfo device in filterInfoCollection)
                cbb_chon.Items.Add(device.Name);
            cbb_chon.SelectedIndex = 0;
        }
    }
}
