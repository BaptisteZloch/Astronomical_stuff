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
        private short current_filter;

        //forms
        Cooling_assistant_form form_cooling = new Cooling_assistant_form();

        public Global_handling()
        {
            InitializeComponent();
            focuser_choose.BackColor = Color.LightGray;
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
            focuser_temp_worker.RunWorkerAsync();
            Disconnect_focuser.Enabled = true;
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
            focuser_temp_worker.CancelAsync();
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

        private void focuser_temp_worker_DoWork(object sender, DoWorkEventArgs e)
        {
            /*
            if (myFocuser.Connected)
            {
                while (true)
                {
                    System.Threading.Thread.Sleep(500);
                    focuser_temp.Text = myFocuser.Temperature.ToString() + "°C";
                }
            }*/
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
                ccd_temp.Text = myCamera.CCDTemperature.ToString() + "°C";
                myCamera.BinX = _binx;
                myCamera.BinY = _biny;
                disconnect_camera.Enabled = true;
                Cooling_assistant.Enabled = true;
                capture.Enabled = true;
            }
            catch (ASCOM.Utilities.Exceptions.HelperException)
            {

            }
        }

        private void disconnect_camera_Click_1(object sender, EventArgs e)
        {
            ccd_temp.Text = "0°C";
            myCamera.Connected = false;
            myFilterWheel.Connected = false;
            camera_choose.BackColor = Color.LightGray;
            disconnect_camera.Enabled = false;
            Cooling_assistant.Enabled = false;
            capture.Enabled = false;
        }

        private void Cooling_assistant_Click(object sender, EventArgs e)
        {
            form_cooling.Show();
            form_cooling.setCCDtemp((int)myCamera.CCDTemperature);
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
            //myCamera.StartExposure(nb_exposure, true);
            //Console.WriteLine("Binning : " + myCamera.BinX + "x" + myCamera.BinY + ", Exposure : " + exposure + "s, Exposure count : " + nb_exposure); //DEBUG
        }

        private void filter_wheel_choose_Click(object sender, EventArgs e)
        {
            try
            {
                ASCOM.Utilities.Chooser chooser = new ASCOM.Utilities.Chooser();
                chooser.DeviceType = "Filterwheel";
                myFilterWheel = new FilterWheel(chooser.Choose());
                myFilterWheel.Connected = true;
                current_filter = myFilterWheel.Position;
                current_position.Text = current_filter.ToString();
                /*camera_choose.BackColor = Color.GreenYellow;
                ccd_temp.Text = myCamera.CCDTemperature.ToString() + "°C";
                myCamera.BinX = _binx;
                myCamera.BinY = _biny;
                disconnect_camera.Enabled = true;
                Cooling_assistant.Enabled = true;
                capture.Enabled = true;*/
            }
            catch (ASCOM.Utilities.Exceptions.HelperException)
            {

            }
        }
    }
}
