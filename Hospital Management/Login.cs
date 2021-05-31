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
        public Login()
        {
            InitializeComponent();
        }

        private void Login_Load(object sender, EventArgs e)
        {
        }
        private void Login_SizeChanged(object sender, EventArgs e)
        {
            Functions.OrderControl(this, Functions.Direction.Vertical,0, Logo, LoginPanel);
        }

        private void tcbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            var users = Functions.MySQL.GetUsers();
            var account_type = users.AccountType(tcbox.Text);

            switch (account_type)
            {
                case "hemsire":
                    Form1.ActiveForm.Controls.Add(new NurseInterface());
                    break;
                case "doktor":
                    Form1.ActiveForm.Controls.Add(new DoctorInterface());
                    break;
                case "admin":
                    Form1.ActiveForm.Controls.Add(new AdminInterface());
                    break;
                case "hizmetli":
                    Form1.ActiveForm.Controls.Add(new StaffInterface());
                    break;
            }
            Hide();
        }
    }
}
