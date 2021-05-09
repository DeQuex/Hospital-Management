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
            this.BackColor = Functions.changeColor(0x2F5A65);
            this.sidePanel.BackColor = Functions.changeColor(0x222831);
            this.label1.ForeColor = Functions.changeColor(0xF3F3F3);
        }

        
        private void AdminInterface_Load(object sender, EventArgs e)
        {

        }
    }
}
