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
    public partial class StaffInterface : UserControl
    {
        public StaffInterface()
        {
            InitializeComponent();
        }

        private void StaffInterface_SizeChanged(object sender, EventArgs e)
        {
            Functions.OrderControl(this, Functions.Direction.Horizontal, 20, sidePanel, rightPanel);
        }

        private void UseMaterial(string name, int amount)
        {
            var materials = Functions.MySQL.GetInventory().GetByType("material");
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
            foreach (var x in inventory.GetByType("material"))
            {
                dataGridView1.Rows.Add(x.getName(), x.getAmount());
            }
        }

        private void GetStaff()
        {
            dataGridView2.Rows.Clear();
            var staff = Functions.MySQL.GetUsers().GetList().Where(x => x.GetDepartment() == "staff").Select(x => x.GetNameSurname());
            foreach (var x in staff)
            {
                dataGridView2.Rows.Add(x[0], x[1]);
            }
        }

        private void StaffInterface_Load(object sender, EventArgs e)
        {
            dataGridView1.ColumnCount = 2;
            dataGridView1.Columns[0].Name = "Name";
            dataGridView1.Columns[1].Name = "Amount";

            dataGridView2.ColumnCount = 2;
            dataGridView2.Columns[0].Name = "Name";
            dataGridView2.Columns[1].Name = "Surname";

            GetMaterials();

            label1.Text = Form1.loginName;

            comboBox1.DataSource = Functions.MySQL.GetInventory().GetByType("material").Select(x => x.getName()).ToList();
            GetStaff();
        }

        private void btn_use_Click(object sender, EventArgs e)
        {
            UseMaterial(comboBox1.SelectedItem.ToString(), Convert.ToInt32(textBox1.Text));
            GetMaterials();
        }
    }
}
