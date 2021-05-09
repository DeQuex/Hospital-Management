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
            BackColor = Functions.HexToRGB(0x2F5A65); // turquoise
            LoginPanel.BackColor = Functions.HexToRGB(0x222831); //dark blue
            tcbox.BackColor = Functions.HexToRGB(0x283651); // blue
            tcpanel.BackColor = Functions.HexToRGB(0x283651); // blue
            passbox.BackColor = Functions.HexToRGB(0x283651); // blue
            passwordpanel.BackColor = Functions.HexToRGB(0x283651); // blue
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

        private void tcpanel_Paint(object sender, PaintEventArgs e)
        {
            var v = e.Graphics;
            Functions.DrawRoundRect(v, Pens.Blue, e.ClipRectangle.Left, e.ClipRectangle.Top, e.ClipRectangle.Width - 1, e.ClipRectangle.Height - 1, 10);

            base.OnPaint(e);
        }
    }
}
