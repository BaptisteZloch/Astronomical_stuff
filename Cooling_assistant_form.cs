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
    public partial class Cooling_assistant_form : Form
    {
        private int ccd_temp;
        private int cooling_step;
        private int timeout;

        private Global_handling form_global;
        public Cooling_assistant_form(Global_handling global_form)
        {
            InitializeComponent();
            form_global = global_form;
        }
        public void display_CCDtemp(double tempCCD)
        {
            ccd_temp_cooling.Text = ((int)tempCCD).ToString() + "°C";
        }

        private void Go_cooling_warming_Click(object sender, EventArgs e)
        {
            if (Regex.IsMatch(target_temp.Text, "[a-zA-Zçàè_,:.;*!? ()&é#{}%$£¤µù^¨°=+]"))
            {
                label2.Visible = true;
                label2.BackColor = Color.Red;
            }
            else if (Regex.IsMatch(cooling_step_box.Text, "[a-zA-Zçàè_,:.;*!? ()&é#{}%$£¤µù^¨°=+]"))
            {
                label7.Visible = true;
                label7.BackColor = Color.Red;
            }
            else if (Regex.IsMatch(timeout_box.Text, "[a-zA-Zçàè_,:.;*!? ()&é#{}%$£¤µù^¨°=+]"))
            {
                label8.Visible = true;
                label8.BackColor = Color.Red;
            }
            else
            {
                ccd_temp = int.Parse(target_temp.Text, NumberStyles.Integer);
                cooling_step = int.Parse(cooling_step_box.Text, NumberStyles.Integer); 
                timeout = int.Parse(timeout_box.Text, NumberStyles.Integer);
                form_global.setCCDtemp((double)ccd_temp);
            }
        }
    }
}
