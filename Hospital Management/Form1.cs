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
    public partial class Form1 : Form
    {
        UserControl loginUserControl = new Login();
        UserControl AdminUControl = new AdminInterface();
        private Control lastControl;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            //Controls.Add(loginUserControl);
            Controls.Add(AdminUControl);

        }


        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            if (lastControl == null) return;
            Functions.ResizeUserControl(this, lastControl);
            Functions.CenterUserControl(this, lastControl);

        }

        private void Form1_ControlAdded(object sender, ControlEventArgs e)
        {
            lastControl = e.Control;
            Functions.ResizeForm(this, lastControl);
            Functions.CenterUserControl(this, lastControl);
        }
    }
}
