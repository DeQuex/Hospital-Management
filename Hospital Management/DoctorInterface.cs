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
    public partial class DoctorInterface : UserControl
    {
        public DoctorInterface()
        {
            InitializeComponent();
        }

        private void DoctorInterface_Load(object sender, EventArgs e)
        {
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, information);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, operation);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, panel24);

            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Surname";

            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].Name = "Name";
            dataGridView2.Columns[1].Name = "Surname";

            dataGridView4.ColumnCount = 2;
            dataGridView4.Columns[0].Name = "Name";
            dataGridView4.Columns[1].Name = "Surname";

            GetPatients();
        }


        private void DoctorInterface_SizeChanged(object sender, EventArgs e)
        {
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, information);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, operation);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, panel24);
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            information.Visible = true;
            operation.Visible = false;
            panel24.Visible = false;
        }


        private void linkLabel2_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            information.Visible = false;
            operation.Visible = true;
            panel24.Visible = false;
        }

        private void linkLabel3_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            information.Visible = false;
            operation.Visible = false;
            panel24.Visible = true;
        }

        private void linkLabel4_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            information.Visible = false;
            operation.Visible = false;
            panel24.Visible = false;
        }
        private void GetPatients()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView4.Rows.Clear();
            var doctor = Functions.MySQL.GetPatients().GetList().Select(x => x.GetNameSurname());
            foreach (var x in doctor)
            {
                dataGridView1.Rows.Add(x[0], x[1]);
            }
            foreach (var x in doctor)
            {
                dataGridView2.Rows.Add(x[0], x[1]);
            }
            foreach (var x in doctor)
            {
                dataGridView4.Rows.Add(x[0], x[1]);
            }
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;

            if (dataGridView1.SelectedRows[0].Cells["Name"].Value == null) return;
            var patient = Functions.MySQL.GetPatients().GetList().Where(x =>
                x.GetNameSurname()[0] == dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString() &&
                x.GetNameSurname()[1] == dataGridView1.SelectedRows[0].Cells["Surname"].Value.ToString());

            foreach (var x in patient)
            {
                label7.Text = x.GetPatientId();
                label8.Text = x.GetMail();
                label9.Text = x.GetTc();
                label5.Text = x.GetNameSurname()[0] + " " + x.GetNameSurname()[1];
                label24.Text = x.GetPatientId();
                label25.Text = x.GetPatientId();
                break;
            }
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label24.Visible = true;
            label17.Visible = true;

            if (dataGridView4.SelectedRows[0].Cells["Name"].Value == null) return;
            var patient = Functions.MySQL.GetPatients().GetList().Where(x =>
                x.GetNameSurname()[0] == dataGridView4.SelectedRows[0].Cells["Name"].Value.ToString() &&
                x.GetNameSurname()[1] == dataGridView4.SelectedRows[0].Cells["Surname"].Value.ToString());

            foreach (var x in patient)
            {
                label7.Text = x.GetPatientId();
                label8.Text = x.GetMail();
                label9.Text = x.GetTc();
                label5.Text = x.GetNameSurname()[0] + " " + x.GetNameSurname()[1];
                label17.Text = x.GetNameSurname()[0] + " " + x.GetNameSurname()[1];
                label24.Text = x.GetPatientId();
                label25.Text = x.GetPatientId();
                break;
            }
        }
    }
}
