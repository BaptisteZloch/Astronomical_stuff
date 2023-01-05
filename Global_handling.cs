using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ASCOM.Utilities;
using ASCOM.DriverAccess;
using ASCOM.Controls;
using ASCOM.DeviceInterface;
using System.Globalization;
using System.Text.RegularExpressions;
using nom.tam.util;
using System.Runtime.Serialization.Formatters.Binary;
using System.IO;

namespace Test_ASCOM_form
{
    public partial class Global_handling : Form
    {
        //devices
        private ASCOM.DriverAccess.Focuser myFocuser;
        private ASCOM.DriverAccess.Camera myCamera;
        private ASCOM.DriverAccess.FilterWheel myFilterWheel;


        //values
        private int focuser_step_value;
        private int exposure;
        private int nb_exposure;
        private short _binx = 1;
        private short _biny = 1;
        private int[,] myImage_array;

        //forms
        private Cooling_assistant_form form_cooling;

        public Global_handling()
        {
            InitializeComponent();
            form_cooling = new Cooling_assistant_form(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ASCOM.Utilities.Chooser chooser = new ASCOM.Utilities.Chooser();
            chooser.DeviceType = "Focuser";
            myFocuser = new Focuser(chooser.Choose());
            myFocuser.Connected = true;
            focuser_choose.BackColor = Color.GreenYellow;
            focuser_step_value = myFocuser.Position;
            current_focuser_value.Text = focuser_step_value.ToString();
            Disconnect_focuser.Enabled = true;
            this.focuser_temp_timer.Enabled = true;
        }

        private void InIn_Click(object sender, EventArgs e)
        {
            if (myFocuser.Connected)
            {
                focuser_step_value = focuser_step_value - 100;
                myFocuser.Move(focuser_step_value);
                current_focuser_value.Text = focuser_step_value.ToString();
            }
        }

        private void Disconnect_focuser_Click(object sender, EventArgs e)
        {
            this.focuser_temp_timer.Enabled = true;
            focuser_temp.Text = "0°C";
            myFocuser.Connected = false;
            focuser_choose.BackColor = Color.LightGray;
            current_focuser_value.Text = "0";
            Disconnect_focuser.Enabled = false;
        }

        private void Out_Click(object sender, EventArgs e)
        {
            if (myFocuser.Connected)
            {
                focuser_step_value = focuser_step_value + 10;
                myFocuser.Move(focuser_step_value);
                current_focuser_value.Text = focuser_step_value.ToString();
            }
        }

        private void OutOut_Click(object sender, EventArgs e)
        {
            if (myFocuser.Connected)
            {
                focuser_step_value = focuser_step_value + 100;
                myFocuser.Move(focuser_step_value);
                current_focuser_value.Text = focuser_step_value.ToString();
            }
        }

        private void In_Click(object sender, EventArgs e)
        {
            if (myFocuser.Connected)
            {
                focuser_step_value = focuser_step_value - 10;
                myFocuser.Move(focuser_step_value);
                current_focuser_value.Text = focuser_step_value.ToString();
            }
        }

        private void Go_position_Click(object sender, EventArgs e)
        {
            if (myFocuser.Connected)
            {
                if (Regex.IsMatch(Focuser_value.Text, "[a-zA-Zçàè_,:.;*!? ()&é#{}%$£¤µù^¨°=+]"))
                {
                    error_char.Visible = true;
                    error_char.BackColor = Color.Red;
                }
                else
                {
                    error_char.Visible = false;
                    focuser_step_value = int.Parse(Focuser_value.Text, NumberStyles.AllowLeadingSign);
                    myFocuser.Move(focuser_step_value);
                    current_focuser_value.Text = focuser_step_value.ToString();
                }
            }
        }

        private void camera_choose_Click(object sender, EventArgs e)
        {
            try
            {
                ASCOM.Utilities.Chooser chooser = new ASCOM.Utilities.Chooser();
                chooser.DeviceType = "Camera";
                myCamera = new Camera(chooser.Choose());
                myCamera.Connected = true;
                camera_choose.BackColor = Color.GreenYellow;
                if (myCamera.CanSetCCDTemperature)
                {
                    ccd_temp.Text = ((int)myCamera.CCDTemperature).ToString() + "°C";
                    Cooling_assistant.Enabled = true;
                    ccd_temp_timer.Enabled = true;
                }
                myCamera.BinX = _binx;
                myCamera.BinY = _biny;
                disconnect_camera.Enabled = true;
                capture.Enabled = true;
            }
            catch (ASCOM.Utilities.Exceptions.HelperException)
            {

            }
        }

        private void disconnect_camera_Click_1(object sender, EventArgs e)
        {
            myCamera.Connected = false;
            if (myFilterWheel != null)
            {
                filter_select.Text = "";
                myFilterWheel.Connected = false;
                FW_position_timer.Enabled = false;
                filter_select.Enabled = false;
            }
            camera_choose.BackColor = Color.LightGray;
            filter_wheel_choose.BackColor = Color.LightGray;
            disconnect_camera.Enabled = false;
            Cooling_assistant.Enabled = false;
            form_cooling.Hide();
            capture.Enabled = false;
            ccd_temp_timer.Enabled = false;
            current_position.Text = "0";
            ccd_temp.Text = "0°C";
        }

        private void Cooling_assistant_Click(object sender, EventArgs e)
        {
            form_cooling.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            char[] split_char = new char[1] { 'x' };
            String[] bin_array = Binning.Text.Split(split_char);
            _binx = short.Parse(bin_array[0], NumberStyles.Integer);
            _biny = short.Parse(bin_array[1], NumberStyles.Integer);
            myCamera.BinX = _binx;
            myCamera.BinY = _biny;
            exposure = (int)exposure_time.Value;
            nb_exposure = (int)count_exposure.Value;
           // myCamera.StartExposure(nb_exposure, true);
            Console.WriteLine("Binning : " + myCamera.BinX + "x" + myCamera.BinY + ", Exposure : " + exposure + "s, Exposure count : " + nb_exposure); //DEBUG
           if (exposure_backworker.IsBusy)
            {
                exposure_backworker.CancelAsync();
                capture.Text = "Capture";
            }
            else
            {
                capture.Text = "Stop";
                exposure_backworker.RunWorkerAsync();
            }
        }

        private void filter_wheel_choose_Click(object sender, EventArgs e)
        {
            try
            {
                ASCOM.Utilities.Chooser chooser = new ASCOM.Utilities.Chooser();
                chooser.DeviceType = "Filterwheel";
                myFilterWheel = new FilterWheel(chooser.Choose());
                myFilterWheel.Connected = true;
                current_position.Text = myFilterWheel.Names[myFilterWheel.Position];
                FW_position_timer.Enabled = true;
                filter_select.Enabled = true;
                filter_wheel_choose.BackColor = Color.GreenYellow;
                filter_select.DataSource = myFilterWheel.Names;
            }
            catch (ASCOM.Utilities.Exceptions.HelperException)
            {

            }
        }
        private void focuser_temp_timer_Tick(object Sender, EventArgs e)
        {
            if (myFocuser.Connected)
            {
                focuser_temp.Text = myFocuser.Temperature.ToString() + "°C";
            }

        }
        private void CCD_temp_timer_Tick(object Sender, EventArgs e)
        {
            if (myCamera.Connected)
            {
                ccd_temp.Text = ((int)myCamera.CCDTemperature).ToString() + "°C";
                form_cooling.display_CCDtemp(myCamera.CCDTemperature);
            }
        }
        private void FW_temp_timer_Tick(object Sender, EventArgs e)
        {
            if (myFilterWheel.Connected)
            {
                current_position.Text = myFilterWheel.Names[filter_select.SelectedIndex];
            }
        }
        public void setCCDtemp(double temp)
        {
            myCamera.SetCCDTemperature = temp;
            Console.WriteLine("cooling started");
        }

        private void filter_select_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                myFilterWheel.Position = (short)filter_select.SelectedIndex;
            }
            catch (ASCOM.DriverAccessCOMException)
            {
                Console.WriteLine("Filter wheel is busy, please wait.");
            }

        }

        private void exposure_backworker_DoWork(object sender, DoWorkEventArgs e)
        {
            int i = 0;
            myCamera.StartExposure((double)exposure, true);
            while (i<exposure && !exposure_backworker.CancellationPending)
            {
                Console.WriteLine("Exposure in progress...");
                System.Threading.Thread.Sleep(1000);
                i++;
            }
        }

        private void exposure_backworker_ProgressChanged(object sender, ProgressChangedEventArgs e)
        {
            Console.WriteLine("Dans le process change");
        }

        private void exposure_backworker_RunWorkerCompleted(object sender, RunWorkerCompletedEventArgs e)
        {
            myCamera.StopExposure();
            MessageBox.Show("Capture completed !");
            capture.Text = "Capture";
            if (myCamera.ImageReady)
            {
                BinaryFormatter bf = new BinaryFormatter();
                using (MemoryStream ms = new System.IO.MemoryStream())
                {
                    bf.Serialize(ms, myCamera.ImageArray);
                    display_image.Image = Image.FromStream(new System.IO.MemoryStream(ms.ToArray()));
                }
            }
            /* if(myCamera.ImageReady)
             {
                 //display_image.Image
                 myImage_array = (int[,])myCamera.ImageArray;
                 int[][] squar_im_array = new int[20][10];
                 for(int i = 0; i < myCamera.NumX; i++)
                 {
                     for(int j = 0; j < myCamera.NumY; j++)
                     {
                         squar_im_array[i][j] = myImage_array[i, j];
                     }
                 }
                 //myImage_array.
                 Console.WriteLine(myImage_array[1,2]);
                 nom.tam.fits.Fits fits = new nom.tam.fits.Fits();
                 nom.tam.fits.BasicHDU hdu = nom.tam.fits.Fits.MakeHDU(myImage_array);
                 hdu.AddValue("BITPIX", 16, null);  // set bit depth of 16 bit
                 hdu.AddValue("NAXIS", 2, null);    // 2D-image
                 fits.AddHDU(hdu);                  // Debugging here shows correct HDU-data, i.e. gradient from top left to bottom right
                 nom.tam.util.BufferedFile file = new nom.tam.util.BufferedFile(@"C:\Users\admin\Documents\Mes documents\C#\test.fits", System.IO.FileAccess.ReadWrite, System.IO.FileShare.ReadWrite);
                 fits.Write(file);
                 file.Flush();
                 file.Close();
                 //     display_image.Image = (Bitmap)((new ImageConverter()).ConvertFrom(myImage_array));

             }*/
        }
    }
}
