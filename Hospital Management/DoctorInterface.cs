﻿using Account_Management;
using System;
using System.Linq;
using System.Windows.Forms;

namespace Hospital_Management
{
    public partial class DoctorInterface : UserControl
    {
        private Patient selectedPatient;
        private Appointment selectedAppointment;
        public DoctorInterface()
        {
            InitializeComponent();
        }

        private void DoctorInterface_Load(object sender, EventArgs e)
        {
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, information);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, operation);
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, panel24);

            dataGridView1.ColumnCount = 3;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Surname";
            dataGridView1.Columns[2].Name = "Id";

            dataGridView2.ColumnCount = 3;
            dataGridView2.Columns[0].Name = "Name";
            dataGridView2.Columns[1].Name = "Surname";
            dataGridView2.Columns[2].Name = "Id";

            dataGridView3.ColumnCount = 5;
            dataGridView3.Columns[0].Name = "ID";
            dataGridView3.Columns[1].Name = "TC";
            dataGridView3.Columns[2].Name = "Ill Definition";
            dataGridView3.Columns[3].Name = "Treatment";
            dataGridView3.Columns[4].Name = "Result";

            dataGridView4.ColumnCount = 3;
            dataGridView4.Columns[0].Name = "Name";
            dataGridView4.Columns[1].Name = "Surname";
            dataGridView4.Columns[2].Name = "Id";


            GetPatientsByAppointment();

            label3.Text = Form1.loginName;
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

        private void GetPatientsByAppointment()
        {
            dataGridView1.Rows.Clear();
            dataGridView2.Rows.Clear();
            dataGridView4.Rows.Clear();
            var appointments = Functions.MySQL.GetAppointments().GetList().Where(x => x.GetAccount().GetStaffId() == Form1.LoginedAccount.GetStaffId());
            foreach (var x in appointments)
            {
                dataGridView1.Rows.Add(x.GetPatient().GetNameSurname()[0], x.GetPatient().GetNameSurname()[1], x.GetAppointmentId());
                dataGridView2.Rows.Add(x.GetPatient().GetNameSurname()[0], x.GetPatient().GetNameSurname()[1], x.GetAppointmentId());
                dataGridView4.Rows.Add(x.GetPatient().GetNameSurname()[0], x.GetPatient().GetNameSurname()[1], x.GetAppointmentId());
            }
        }

        private void EditInspection(Appointment appointment, string text)
        {
            try
            {
                Functions.MySQL.Edit("appointments", "inspection", text, "id", appointment.GetAppointmentId());
            }
            catch (Exception e)
            {
                Functions.MessageBox.Error("An error occurred.");
                Console.WriteLine(e);
            }
        }

        private void GetInfo()
        {
            label7.Text = selectedPatient.GetPatientId();
            label8.Text = selectedPatient.GetMail();
            label9.Text = selectedPatient.GetTc();
            label5.Text = selectedPatient.GetNameSurname()[0] + " " + selectedPatient.GetNameSurname()[1];
            label17.Text = selectedPatient.GetNameSurname()[0] + " " + selectedPatient.GetNameSurname()[1];
            label24.Text = selectedPatient.GetPatientId();
            label25.Text = selectedPatient.GetPatientId();
            label29.Text = selectedPatient.GetNameSurname()[0] + " " + selectedPatient.GetNameSurname()[1];
            richTextBox2.Text = selectedAppointment.GetInspection();

            var examination = Functions.MySQL.GetExaminations().GetList().Where(x =>
                x.GetPatient().GetPatientId() == selectedPatient.GetPatientId() &&
                x.GetPatient().GetTc() == selectedPatient.GetTc());
            

            dataGridView3.Rows.Clear();
            foreach (var x in examination)
            {
                dataGridView3.Rows.Add(selectedPatient.GetPatientId(), selectedPatient.GetTc(), x.GetIllDefinition(), x.GetTreatment(), x.GetResult());
            }

        }
        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label24.Visible = true;
            label17.Visible = true;
            label25.Visible = true;
            label29.Visible = true;

            if (dataGridView1.SelectedRows[0].Cells["Name"].Value == null) return;
            var patient = Functions.MySQL.GetPatients().GetList().Where(x =>
                x.GetNameSurname()[0] == dataGridView1.SelectedRows[0].Cells["Name"].Value.ToString() &&
                x.GetNameSurname()[1] == dataGridView1.SelectedRows[0].Cells["Surname"].Value.ToString());
            foreach (var x in patient)
            {
                selectedPatient = x;
                break;
            }

            var appointments = Functions.MySQL.GetAppointments().GetList().Where(x => x.GetAccount().GetStaffId() == Form1.LoginedAccount.GetStaffId());
            foreach (var x in appointments)
            {
                if (x.GetAppointmentId() == dataGridView1.SelectedRows[0].Cells["Id"].Value.ToString())
                {
                    selectedAppointment = x;
                    break;
                }
            }

            GetInfo();
        }

        private void dataGridView4_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label24.Visible = true;
            label17.Visible = true;
            label25.Visible = true;
            label29.Visible = true;

            if (dataGridView4.SelectedRows[0].Cells["Name"].Value == null) return;
            var patient = Functions.MySQL.GetPatients().GetList().Where(x =>
                x.GetNameSurname()[0] == dataGridView4.SelectedRows[0].Cells["Name"].Value.ToString() &&
                x.GetNameSurname()[1] == dataGridView4.SelectedRows[0].Cells["Surname"].Value.ToString());

            foreach (var x in patient)
            {
                selectedPatient = x;
                break;
            }

            var appointments = Functions.MySQL.GetAppointments().GetList().Where(x => x.GetAccount().GetStaffId() == Form1.LoginedAccount.GetStaffId());
            foreach (var x in appointments)
            {
                if (x.GetAppointmentId() == dataGridView4.SelectedRows[0].Cells["Id"].Value.ToString())
                {
                    selectedAppointment = x;
                    break;
                }
            }

            GetInfo();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            var str = $"{comboBox1.SelectedItem},{comboBox2.SelectedItem},{comboBox3.SelectedItem}";
            try
            {
                Functions.MySQL.Add("examination", new[] { "patient_id", selectedPatient.GetPatientId() },
                    new[] { "patient_tc", selectedPatient.GetTc() }, new[] { "ill_definition", richTextBox1.Text },
                    new[] { "treatment", str }, new[] { "result", textBox1.Text });

            }
            catch (Exception exception)
            {
                Functions.MessageBox.Error("Bir hata olustu. Detay icin konsol komutlarina bak");
                Console.WriteLine(exception);
            }

        }

        private void dataGridView2_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            label5.Visible = true;
            label7.Visible = true;
            label8.Visible = true;
            label9.Visible = true;
            label24.Visible = true;
            label17.Visible = true;
            label25.Visible = true;
            label29.Visible = true;

            if (dataGridView2.SelectedRows[0].Cells["Name"].Value == null) return;
            var patient = Functions.MySQL.GetPatients().GetList().Where(x =>
                x.GetNameSurname()[0] == dataGridView2.SelectedRows[0].Cells["Name"].Value.ToString() &&
                x.GetNameSurname()[1] == dataGridView2.SelectedRows[0].Cells["Surname"].Value.ToString());

            foreach (var x in patient)
            {
                selectedPatient = x;
                break;
            }

            var appointments = Functions.MySQL.GetAppointments().GetList().Where(x => x.GetAccount().GetStaffId() == Form1.LoginedAccount.GetStaffId());
            foreach (var x in appointments)
            {
                if (x.GetAppointmentId() == dataGridView2.SelectedRows[0].Cells["Id"].Value.ToString())
                {
                    selectedAppointment = x;
                    break;
                }
            }

            GetInfo();
        }

        private void btn_signout_Click(object sender, EventArgs e)
        {
            Functions.LogOut(this);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (selectedAppointment != null)
                EditInspection(selectedAppointment, richTextBox2.Text);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            string recipe;
            if (selectedPatient != null)
            {
                recipe =
                    $"receteniz:\n {Form1.loginName} tarafindan yollanmistir.\n Recete bilgileri:\n{comboBox1.SelectedItem} {comboBox2.SelectedItem} {comboBox3.SelectedItem} {textBox1.Text} Not: {richTextBox1.Text}";
                if (Functions.sendMailCheck())
                {
                    Functions.sendMail(recipe, "Receteniz hazir", selectedPatient.GetMail(), selectedPatient.GetNameSurname()[0]);
                }
                else
                {
                    Functions.MessageBox.Error("An error occurred.");
                }
            }
        }
    }
}
