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
    public partial class StaffInterface : UserControl
    {
        public StaffInterface()
        {
            InitializeComponent();
        }

        private void StaffInterface_SizeChanged(object sender, EventArgs e)
        {
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, rightPanel);
        }
    }
}
