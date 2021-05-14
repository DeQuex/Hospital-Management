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
        }

        
        private void AdminInterface_Load(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (user_panel.Visible == true && confirmation_panel.Visible == false)
            {
                user_panel.Hide();
                confirmation_panel.Show();
            }
        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (user_panel.Visible == false && confirmation_panel.Visible == true)
            {
                user_panel.Show();
                confirmation_panel.Hide();
            }
        }
    }
}
