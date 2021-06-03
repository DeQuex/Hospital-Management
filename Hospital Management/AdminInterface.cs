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

            //dataGridView1.DataSource = Functions.MySQL.ReadAllDataSource("users");
            //dataGridView1.DataMember = Functions.MySQL.ReadAllDataSource("users").TableName;
            dataGridView1.ColumnCount = 8;
            dataGridView1.Columns[0].Name = "Id";
            dataGridView1.Columns[1].Name = "Name";
            dataGridView1.Columns[2].Name = "Surname";
            dataGridView1.Columns[3].Name = "Staff TC";
            dataGridView1.Columns[4].Name = "Mail";
            dataGridView1.Columns[5].Name = "Department";
            dataGridView1.Columns[6].Name = "Approve Status";
            dataGridView1.Columns[7].Name = "Staff ID";

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (user_panel.Visible == true && confirmation_panel.Visible == false)
            {
                user_panel.Hide();
                confirmation_panel.Show();
            }

            //var result = Functions.unapprovedUsers();
            //Console.WriteLine(result);
            //var addQuery = result.Split(' ');
            //dataGridView2.Rows.Add(addQuery);

            dataGridView2.DataSource = Functions.MySQL.ReadUApproved("users");
            dataGridView2.DataMember = Functions.MySQL.ReadUApproved("users").TableName;


        }

        private void label4_Click(object sender, EventArgs e)
        {
            if (user_panel.Visible == false && confirmation_panel.Visible == true)
            {
                user_panel.Show();
                confirmation_panel.Hide();
            }
        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btn_search_patient_Click(object sender, EventArgs e)
        {
            dataGridView1.Rows.Clear();
            var users = Functions.MySQL.GetUsers();
            foreach (var account in users.FindStaff(patient_name_input.Text, department.SelectedItem.ToString()))
            {
                dataGridView1.Rows.Add(account.GetId(), account.GetNameSurname()[0], account.GetNameSurname()[1],
                    account.GetStaffTc(), account.GetMail(), account.GetDepartment(), account.GetApproveStatus(),
                    account.GetStaffId());
            }
            
        }

        private void dataGridView2_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            MessageBox.Show("Tıkladığın hücre " + dataGridView2.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString());
            var name = dataGridView2.Rows[e.RowIndex].Cells[1].Value.ToString();
            var surname = dataGridView2.Rows[e.RowIndex].Cells[2].Value.ToString();
            var tc = dataGridView2.Rows[e.RowIndex].Cells[3].Value.ToString();

            if (e.ColumnIndex == 6 && dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString() == "0")
            {
                DialogResult dialogResult = MessageBox.Show(name +" Adlı kullanıcıyı onaylamak istediğinize emin minisiniz?", "Kullanıcı Onayla", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Functions.MySQL.Edit("users", "approve_status", "1", "staff_tc", tc);
                    dataGridView2.Rows[e.RowIndex].Cells[6].Value = "1";
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }else if (e.ColumnIndex == 6 && dataGridView2.Rows[e.RowIndex].Cells[6].Value.ToString() == "1")
            {
                DialogResult dialogResult = MessageBox.Show(name + " Adlı kullanıcının onayını kaldırmak istediğinize emin minisiniz?", "Onay Kaldır?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Functions.MySQL.Edit("users", "approve_status", "0", "staff_tc", tc);
                    dataGridView2.Rows[e.RowIndex].Cells[6].Value = "0";
                }
                else if (dialogResult == DialogResult.No)
                {
                    //do something else
                }
            }
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            Functions.LogOut(this);
        }
    }
}
