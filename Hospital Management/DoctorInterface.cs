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
    public partial class DoctorInterface : UserControl
    {
        public DoctorInterface()
        {
            InitializeComponent();
        }

        private void DoctorInterface_Load(object sender, EventArgs e)
        {
            Functions.OrderControl(this, Functions.Direction.Horizontal, 10, sidePanel, information);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 10, sidePanel, operation);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 10, sidePanel, panel22);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            information.Visible = true;
            operation.Visible = false;
            panel22.Visible = false;
        }


        private void button2_Click(object sender, EventArgs e)
        {
            information.Visible = false;
            operation.Visible = true;
            panel22.Visible = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            information.Visible = false;
            operation.Visible = false;
            panel22.Visible = true;
        }

        private void DoctorInterface_SizeChanged(object sender, EventArgs e)
        {
            Functions.OrderControl(this, Functions.Direction.Horizontal, 10, sidePanel, information);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 10, sidePanel, operation);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 10, sidePanel, panel22);
        }
    }
}
