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

        private void CenterUserControl(Form fName, Control name)
        {
            name.Location = new Point(fName.Size.Width / 2 - (name.Size.Width / 2), fName.Size.Height / 2 - (name.Size.Height / 2));
        }
        private void ResizeForm(Form fName, Control name)
        {
            fName.Size = new Size(name.Size.Width, name.Size.Height);
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            
            Controls.Add(loginUserControl);
            CenterUserControl(this, loginUserControl);
            //Controls.Add(AdminUControl);

            ResizeForm(this, loginUserControl);

            
        }

            
            

        private void Form1_SizeChanged(object sender, EventArgs e)
        {
            CenterUserControl(this, loginUserControl);
        }
    }
}
