using MySql.Data.MySqlClient;
using System;
using System.Net.Mail;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class Register : UserControl
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            if (name.Text.Length < 3)
            {
                Functions.MessageBox.Warn("Name length must be higher than 2.");
                return;
            }
            if (surname.Text.Length < 3)
            {
                Functions.MessageBox.Warn("Surname length must be higher than 2.");
                return;
            }

            try
            {
                var eMailValidator = new System.Net.Mail.MailAddress(mailbox.Text);
            }
            catch (FormatException)
            {
                Functions.MessageBox.Error("Wrong e-mail.");
                return;
            }
            catch (ArgumentException)
            {
                Functions.MessageBox.Error("Email can't be empty.");
                return;
            }

            if (tcbox.Text.Length != 11)
            {
                Functions.MessageBox.Warn("TC length must be 11 digits.");
                return;
            }
            if (sectionbox.SelectedItem == null)
            {
                Functions.MessageBox.Error("You have to select section.");
                return;
            }
            if (Functions.sendMailCheck() && Functions.MySQL.check_connection())
            {
                var new_password = Functions.GeneratePassword();
                try
                {
                    Functions.MySQL.Add("users", new[] { "name", name.Text }, new[] { "surname", surname.Text },
                        new[] { "staff_tc", tcbox.Text }, new[] { "password", Functions.ComputeSha256Hash(new_password) },
                        new[] { "mail", mailbox.Text }, new[] { "department", sectionbox.SelectedItem.ToString() },
                        new[] { "approve_status", "0" }, new[] { "staff_id", Functions.CreateId(11) });
                    Functions.sendMail(new_password, mailbox.Text, name.Text);
                    Functions.MessageBox.Info("Register successfully, your password sent to your mail.");
                    Form.ActiveForm?.Controls.Add(new Login());
                    Form.ActiveForm?.Controls.Remove(this);
                }
                catch (MySqlException exception)
                {
                    Functions.MessageBox.Error(exception.Number == 1062 ? "Already registered with this information!" : exception.Message);
                }
                catch (SmtpException exception)
                {
                    Functions.MessageBox.Error(exception.Message);
                }
            }
            else
            {
                Functions.MessageBox.Error("An error occurred.");
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            name.Text = string.Empty;
            surname.Text = string.Empty;
            mailbox.Text = string.Empty;
            tcbox.Text = string.Empty;
        }

        private void tcbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
