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

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            Controls.Add(AdminUControl);
            Functions.CenterUserControl(this, AdminUControl);
            //Controls.Add(AdminUControl);

            //Functions.ResizeForm(this, AdminUControl);

        }


        private void Form1_SizeChanged(object sender, EventArgs e)
        {
          // Functions.CenterUserControl(this, AdminUControl);
        }
    }
}
