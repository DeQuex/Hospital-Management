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
    public partial class AdminInterface : UserControl
    {
        public AdminInterface()
        {
            InitializeComponent();
            BackColor = Functions.HexToRGB(0x2F5A65);
            sidePanel.BackColor = Functions.HexToRGB(0x222831);
            label1.ForeColor = Functions.HexToRGB(0xF3F3F3);
        }

        
        private void AdminInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
