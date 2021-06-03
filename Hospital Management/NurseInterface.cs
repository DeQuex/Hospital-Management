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
        private void UseMaterial(string name, int amount)
        {
            var materials = Functions.MySQL.GetInventory().GetByType("medical");
            foreach (var x in materials)
            {
                if (x.getName() != name) continue;
                if (x.getAmount() >= amount && amount > 0)
                {
                    var newvalue = x.getAmount() - amount;
                    Functions.MySQL.Edit("inventory", "amount", newvalue.ToString(), "name", name);
                }
                else
                {
                    MessageBox.Show("Yeteri kadar materyal yok");
                }
                break;
            }
        }

        private void GetMaterials()
        {
            dataGridView1.Rows.Clear();
            var inventory = Functions.MySQL.GetInventory();
            foreach (var x in inventory.GetByType("medical"))
            {
                dataGridView1.Rows.Add(x.getName(), x.getAmount());
            }
        }
        private void GetStaff()
        {
            dataGridView2.Rows.Clear();
            var staff = Functions.MySQL.GetUsers().GetList().Where(x => x.GetDepartment() == "nurse").Select(x => x.GetNameSurname());
            foreach (var x in staff)
            {
                dataGridView2.Rows.Add(x[0], x[1]);
            }
        }

        private void NurseInterface_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Amount";

            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].Name = "Name";
            dataGridView2.Columns[1].Name = "Surname";

            dataGridView3.ColumnCount = 4;
            dataGridView3.Columns[0].Name = "Name";
            dataGridView3.Columns[1].Name = "Surname";
            dataGridView3.Columns[2].Name = "Ill Definition";
            dataGridView3.Columns[3].Name = "Treatment";

            GetMaterials();

            label1.Text = Form1.loginName;

            comboBox1.DataSource = Functions.MySQL.GetInventory().GetByType("medical").Select(x => x.getName()).ToList();
            GetStaff();
        }

        private void btn_use_Click(object sender, EventArgs e)
        {
            UseMaterial(comboBox1.SelectedItem.ToString(), Convert.ToInt32(textBox1.Text));
            GetMaterials();
        }

        private void btn_search_patient_Click(object sender, EventArgs e)
        {
            if (patient_tc_input.Text == null || patient_id_input.Text == null) return;
            try
            {
                var examinatons = Functions.MySQL.GetExaminations().GetList()
                    .Where(x => x.GetPatient().GetPatientId() == patient_id_input.Text && x.GetPatient().GetTc() == patient_tc_input.Text);
                foreach (var x in examinatons)
                {
                    dataGridView3.Rows.Add(x.GetPatient().GetNameSurname()[0], x.GetPatient().GetNameSurname()[1],
                        x.GetIllDefinition(), x.GetTreatment());
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show("Kullanici bulunamadi.", "Error!", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Console.WriteLine("Kullanici bulunamadi.");
            }
            
        }
    }
}
