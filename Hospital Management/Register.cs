using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Account_Management;
using MySql.Data.MySqlClient;

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
                    MessageBox.Show("Kayit basarili sifreniz mail adresinize gonderildi.", "SAS Project",
                        MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Form.ActiveForm?.Controls.Add(new Login());
                    Form.ActiveForm?.Controls.Remove(this);
                }
                catch (MySqlException exception)
                {
                    MessageBox.Show(exception.Number == 1062 ? "boyle bir uye zaten var" : exception.Message);
                }
                catch (SmtpException exception)
                {
                    MessageBox.Show(exception.Message);
                }
            }
            else
            {
                MessageBox.Show("Bir hata olustu.", "Hata", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            name.Text = String.Empty;
            surname.Text = String.Empty;
            mailbox.Text = String.Empty;
            tcbox.Text = String.Empty;
        }

        private void tcbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
                e.Handled = true;
        }
    }
}
