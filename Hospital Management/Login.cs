using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Login : UserControl
    {
        private void colorSettings()
        {
            BackColor = Functions.HexToRGB(0x2F5A65);
            LoginPanel.BackColor = Functions.HexToRGB(0x222831);
        }
        public Login()
        {
            InitializeComponent();
            colorSettings();
        }

        private void Login_Load(object sender, EventArgs e)
        {
            Functions.CenterControl(this, LoginPanel);
        }

        private void Login_SizeChanged(object sender, EventArgs e)
        {
            Functions.CenterControl(this, LoginPanel);
        }
    }
}
