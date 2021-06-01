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

            if (users.GetList().Any(x => x.GetPassword() == Functions.ComputeSha256Hash(passbox.Text) && x.GetStaffTc() == tcbox.Text && x.GetApproveStatus() == "1"))
            {
                var account_type = users.AccountType(tcbox.Text);
                switch (account_type)
                {
                    case "hemsire":
                        Form.ActiveForm?.Controls.Add(new NurseInterface());
                        break;
                    case "doktor":
                        Form.ActiveForm?.Controls.Add(new DoctorInterface());
                        break;
                    case "admin":
                        Form.ActiveForm?.Controls.Add(new AdminInterface());
                        break;
                    case "hizmetli":
                        Form.ActiveForm?.Controls.Add(new StaffInterface());
                        break;
                }
                Form.ActiveForm?.Controls.Remove(this);
            }
            else
            {
                MessageBox.Show("tc or password is wrong.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
           
        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            Form.ActiveForm?.Controls.Add(new Register());
            Form.ActiveForm?.Controls.Remove(this);
        }
    }
}
