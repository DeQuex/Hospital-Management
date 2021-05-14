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
    public partial class NurseInterface : UserControl
    {
        public NurseInterface()
        {
            InitializeComponent();
        }

        private void storage_label_Click(object sender, EventArgs e)
        {
            if(patient_panel.Visible == true && storage_panel.Visible == false)
            {
                patient_panel.Hide();
                storage_panel.Show();
            }
        }

        private void patientInfo_label_Click(object sender, EventArgs e)
        {
            if (patient_panel.Visible == false && storage_panel.Visible == true)
            {
                patient_panel.Show();
                storage_panel.Hide();
            }
        }
    }
}
