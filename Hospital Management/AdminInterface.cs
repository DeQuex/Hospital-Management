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
            dataGridView1.DataSource = Functions.MySQL.ReadAllDataSource("users");
            dataGridView1.DataMember = Functions.MySQL.ReadAllDataSource("users").TableName;

        }

        private void label5_Click(object sender, EventArgs e)
        {
            if (user_panel.Visible == true && confirmation_panel.Visible == false)
            {
                user_panel.Hide();
                confirmation_panel.Show();
            }
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
            var patient_name = patient_name_input.Text;
            var depart = department.Text;
            if (patient_name == "" && depart == "")
            {
                MessageBox.Show("Değer girmediniz");
            }
            else
            {
                var result = Functions.findUser(patient_name, depart);
                Console.WriteLine(result);
                var addQuery = result.Split(' ');
                dataGridView1.Rows.Add(addQuery);
            }
            
        }
    }
}
