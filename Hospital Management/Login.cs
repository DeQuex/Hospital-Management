using System;
using System.Data;
using System.Linq;
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
            Functions.OrderControl(this, Functions.Direction.Vertical, 0, Logo, LoginPanel);
        }

        private void tcbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
            if (tcbox.Text.Length != 11)
            {
                Functions.MessageBox.Warn("TC length must be 11 digits.");
                return;
            }
            var users = Functions.MySQL.GetUsers();
            var userpass = false;
            foreach (var x in users.GetList().Where(x =>
                x.GetPassword() == Functions.ComputeSha256Hash(passbox.Text) && x.GetStaffTc() == tcbox.Text))
            {
                userpass = true;
                if (x.GetApproveStatus() != "1") continue;
                var account_type = users.AccountType(tcbox.Text);
                Form1.loginName = $"{x.GetNameSurname()[0]} {x.GetNameSurname()[1]}";
                Form1.LoginedAccount = x;
                switch (account_type)
                {
                    case "nurse":
                        Form.ActiveForm?.Controls.Add(new NurseInterface());
                        break;
                    case "doctor":
                        Form.ActiveForm?.Controls.Add(new DoctorInterface());
                        break;
                    case "admin":
                        Form.ActiveForm?.Controls.Add(new AdminInterface());
                        break;
                    case "staff":
                        Form.ActiveForm?.Controls.Add(new StaffInterface());
                        break;
                }
                Form.ActiveForm?.Controls.Remove(this);
                return;
            }
            Functions.MessageBox.Error(!userpass ? "TC or Password is wrong." : "You are not approved.");
        }

        private void lbl_register_Click(object sender, EventArgs e)
        {
            Form.ActiveForm?.Controls.Add(new Register());
            Form.ActiveForm?.Controls.Remove(this);
        }

        private void lbl_forgot_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show("Can you access your e-mail address?", "SAS Project - Info");
        }
    }
}
