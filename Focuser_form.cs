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

namespace Test_ASCOM_form
{
    public partial class Focuser_form : Form
    {

        private ASCOM.DriverAccess.Focuser focuser;

        public Focuser_form()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            ASCOM.Utilities.Chooser chooser = new ASCOM.Utilities.Chooser();
            chooser.DeviceType = "Focuser";
            focuser = new Focuser(chooser.Choose());
            focuser.Connected = true;
        }
    }
}
