
namespace Hospital_Management
{
    partial class NurseInterface
    {
        /// <summary> 
        ///Gerekli tasarımcı değişkeni.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        ///Kullanılan tüm kaynakları temizleyin.
        /// </summary>
        ///<param name="disposing">yönetilen kaynaklar dispose edilmeliyse doğru; aksi halde yanlış.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Bileşen Tasarımcısı üretimi kod

        /// <summary> 
        /// Tasarımcı desteği için gerekli metot - bu metodun 
        ///içeriğini kod düzenleyici ile değiştirmeyin.
        /// </summary>
        private void InitializeComponent()
        {
            this.sidePanel = new System.Windows.Forms.Panel();
            this.selection2_panel = new System.Windows.Forms.Panel();
            this.storage_label = new System.Windows.Forms.Label();
            this.selection1_panel = new System.Windows.Forms.Panel();
            this.patientInfo_label = new System.Windows.Forms.Label();
            this.btn_signout = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.patient_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.btn_search_patient = new System.Windows.Forms.Button();
            this.patient_id_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patient_tc_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.storage_panel = new System.Windows.Forms.Panel();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.btn_use = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.panel23 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.panel27 = new System.Windows.Forms.Panel();
            this.panel28 = new System.Windows.Forms.Panel();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label33 = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.selection2_panel.SuspendLayout();
            this.selection1_panel.SuspendLayout();
            this.patient_panel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            this.storage_panel.SuspendLayout();
            this.panel23.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel27.SuspendLayout();
            this.panel28.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // sidePanel
            // 
            this.sidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.sidePanel.Controls.Add(this.selection2_panel);
            this.sidePanel.Controls.Add(this.selection1_panel);
            this.sidePanel.Controls.Add(this.btn_signout);
            this.sidePanel.Controls.Add(this.panel1);
            this.sidePanel.Controls.Add(this.label1);
            this.sidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.sidePanel.Location = new System.Drawing.Point(0, 0);
            this.sidePanel.Name = "sidePanel";
            this.sidePanel.Size = new System.Drawing.Size(286, 765);
            this.sidePanel.TabIndex = 4;
            // 
            // selection2_panel
            // 
            this.selection2_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selection2_panel.Controls.Add(this.storage_label);
            this.selection2_panel.Location = new System.Drawing.Point(0, 211);
            this.selection2_panel.Name = "selection2_panel";
            this.selection2_panel.Size = new System.Drawing.Size(286, 37);
            this.selection2_panel.TabIndex = 5;
            // 
            // storage_label
            // 
            this.storage_label.AutoSize = true;
            this.storage_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.storage_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.storage_label.Location = new System.Drawing.Point(98, 5);
            this.storage_label.Name = "storage_label";
            this.storage_label.Size = new System.Drawing.Size(90, 25);
            this.storage_label.TabIndex = 1;
            this.storage_label.Text = "Envanter";
            this.storage_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.storage_label.Click += new System.EventHandler(this.storage_label_Click);
            // 
            // selection1_panel
            // 
            this.selection1_panel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.selection1_panel.Controls.Add(this.patientInfo_label);
            this.selection1_panel.Location = new System.Drawing.Point(0, 177);
            this.selection1_panel.Name = "selection1_panel";
            this.selection1_panel.Size = new System.Drawing.Size(286, 37);
            this.selection1_panel.TabIndex = 4;
            // 
            // patientInfo_label
            // 
            this.patientInfo_label.AutoSize = true;
            this.patientInfo_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patientInfo_label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.patientInfo_label.Location = new System.Drawing.Point(81, 5);
            this.patientInfo_label.Name = "patientInfo_label";
            this.patientInfo_label.Size = new System.Drawing.Size(129, 25);
            this.patientInfo_label.TabIndex = 0;
            this.patientInfo_label.Text = "Hasta Bilgileri";
            this.patientInfo_label.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.patientInfo_label.Click += new System.EventHandler(this.patientInfo_label_Click);
            // 
            // btn_signout
            // 
            this.btn_signout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(143)))), ((int)(((byte)(49)))), ((int)(((byte)(49)))));
            this.btn_signout.FlatAppearance.BorderSize = 0;
            this.btn_signout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_signout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_signout.Location = new System.Drawing.Point(14, 716);
            this.btn_signout.Name = "btn_signout";
            this.btn_signout.Size = new System.Drawing.Size(75, 36);
            this.btn_signout.TabIndex = 5;
            this.btn_signout.Text = "Oturumu Kapat";
            this.btn_signout.UseVisualStyleBackColor = false;
            this.btn_signout.Click += new System.EventHandler(this.btn_signout_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.panel1.Location = new System.Drawing.Point(0, 116);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(286, 45);
            this.panel1.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label1.Location = new System.Drawing.Point(82, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Deneme İsim";
            // 
            // patient_panel
            // 
            this.patient_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.patient_panel.Controls.Add(this.panel2);
            this.patient_panel.Controls.Add(this.btn_search_patient);
            this.patient_panel.Controls.Add(this.patient_id_input);
            this.patient_panel.Controls.Add(this.label3);
            this.patient_panel.Controls.Add(this.patient_tc_input);
            this.patient_panel.Controls.Add(this.label2);
            this.patient_panel.Location = new System.Drawing.Point(319, 24);
            this.patient_panel.Name = "patient_panel";
            this.patient_panel.Size = new System.Drawing.Size(1018, 693);
            this.patient_panel.TabIndex = 5;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.dataGridView3);
            this.panel2.Location = new System.Drawing.Point(327, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 500);
            this.panel2.TabIndex = 7;
            // 
            // dataGridView3
            // 
            this.dataGridView3.AllowUserToAddRows = false;
            this.dataGridView3.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.dataGridView3.Location = new System.Drawing.Point(22, 19);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.ReadOnly = true;
            this.dataGridView3.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView3.Size = new System.Drawing.Size(646, 464);
            this.dataGridView3.TabIndex = 0;
            // 
            // btn_search_patient
            // 
            this.btn_search_patient.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(165)))), ((int)(((byte)(87)))));
            this.btn_search_patient.FlatAppearance.BorderSize = 0;
            this.btn_search_patient.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_search_patient.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_search_patient.Location = new System.Drawing.Point(141, 156);
            this.btn_search_patient.Name = "btn_search_patient";
            this.btn_search_patient.Size = new System.Drawing.Size(95, 36);
            this.btn_search_patient.TabIndex = 6;
            this.btn_search_patient.Text = "Bul";
            this.btn_search_patient.UseVisualStyleBackColor = false;
            this.btn_search_patient.Click += new System.EventHandler(this.btn_search_patient_Click);
            // 
            // patient_id_input
            // 
            this.patient_id_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.patient_id_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patient_id_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_id_input.Location = new System.Drawing.Point(83, 114);
            this.patient_id_input.Name = "patient_id_input";
            this.patient_id_input.Size = new System.Drawing.Size(209, 23);
            this.patient_id_input.TabIndex = 3;
            this.patient_id_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patient_id_input_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label3.Location = new System.Drawing.Point(78, 86);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 25);
            this.label3.TabIndex = 2;
            this.label3.Text = "Hasta İd";
            // 
            // patient_tc_input
            // 
            this.patient_tc_input.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.patient_tc_input.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.patient_tc_input.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.patient_tc_input.Location = new System.Drawing.Point(83, 55);
            this.patient_tc_input.Name = "patient_tc_input";
            this.patient_tc_input.Size = new System.Drawing.Size(209, 23);
            this.patient_tc_input.TabIndex = 1;
            this.patient_tc_input.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.patient_tc_input_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label2.Location = new System.Drawing.Point(78, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "TC No";
            // 
            // storage_panel
            // 
            this.storage_panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.storage_panel.Controls.Add(this.textBox1);
            this.storage_panel.Controls.Add(this.label4);
            this.storage_panel.Controls.Add(this.btn_use);
            this.storage_panel.Controls.Add(this.comboBox1);
            this.storage_panel.Controls.Add(this.label6);
            this.storage_panel.Controls.Add(this.panel23);
            this.storage_panel.Controls.Add(this.panel27);
            this.storage_panel.Location = new System.Drawing.Point(319, 24);
            this.storage_panel.Name = "storage_panel";
            this.storage_panel.Size = new System.Drawing.Size(1018, 693);
            this.storage_panel.TabIndex = 6;
            this.storage_panel.Visible = false;
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.textBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.textBox1.Location = new System.Drawing.Point(634, 151);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(38, 20);
            this.textBox1.TabIndex = 30;
            this.textBox1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.Window;
            this.label4.Location = new System.Drawing.Point(504, 154);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(80, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Kullanım Miktarı";
            // 
            // btn_use
            // 
            this.btn_use.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.btn_use.FlatAppearance.BorderSize = 0;
            this.btn_use.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_use.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_use.Location = new System.Drawing.Point(595, 199);
            this.btn_use.Name = "btn_use";
            this.btn_use.Size = new System.Drawing.Size(95, 36);
            this.btn_use.TabIndex = 28;
            this.btn_use.Text = "Kullan";
            this.btn_use.UseVisualStyleBackColor = false;
            this.btn_use.Click += new System.EventHandler(this.btn_use_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.comboBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.comboBox1.ForeColor = System.Drawing.SystemColors.Window;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(634, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(121, 21);
            this.comboBox1.TabIndex = 27;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.Window;
            this.label6.Location = new System.Drawing.Point(495, 87);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 13);
            this.label6.TabIndex = 26;
            this.label6.Text = "Kullanılarn Malzeme";
            // 
            // panel23
            // 
            this.panel23.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel23.Controls.Add(this.dataGridView1);
            this.panel23.Location = new System.Drawing.Point(485, 374);
            this.panel23.Name = "panel23";
            this.panel23.Size = new System.Drawing.Size(349, 219);
            this.panel23.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(3, 3);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(343, 213);
            this.dataGridView1.TabIndex = 0;
            // 
            // panel27
            // 
            this.panel27.Controls.Add(this.panel28);
            this.panel27.Controls.Add(this.label33);
            this.panel27.Location = new System.Drawing.Point(50, 87);
            this.panel27.Name = "panel27";
            this.panel27.Size = new System.Drawing.Size(257, 521);
            this.panel27.TabIndex = 24;
            // 
            // panel28
            // 
            this.panel28.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel28.Controls.Add(this.dataGridView2);
            this.panel28.Location = new System.Drawing.Point(22, 31);
            this.panel28.Name = "panel28";
            this.panel28.Size = new System.Drawing.Size(220, 475);
            this.panel28.TabIndex = 1;
            // 
            // dataGridView2
            // 
            this.dataGridView2.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(3, 3);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(214, 469);
            this.dataGridView2.TabIndex = 24;
            // 
            // label33
            // 
            this.label33.AutoSize = true;
            this.label33.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.label33.Location = new System.Drawing.Point(80, 15);
            this.label33.Name = "label33";
            this.label33.Size = new System.Drawing.Size(106, 13);
            this.label33.TabIndex = 0;
            this.label33.Text = "Sağlık Görevli Isimleri";
            // 
            // NurseInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.patient_panel);
            this.Controls.Add(this.storage_panel);
            this.Name = "NurseInterface";
            this.Size = new System.Drawing.Size(1360, 765);
            this.Load += new System.EventHandler(this.NurseInterface_Load);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.selection2_panel.ResumeLayout(false);
            this.selection2_panel.PerformLayout();
            this.selection1_panel.ResumeLayout(false);
            this.selection1_panel.PerformLayout();
            this.patient_panel.ResumeLayout(false);
            this.patient_panel.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            this.storage_panel.ResumeLayout(false);
            this.storage_panel.PerformLayout();
            this.panel23.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel27.ResumeLayout(false);
            this.panel27.PerformLayout();
            this.panel28.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel sidePanel;
        private System.Windows.Forms.Panel selection2_panel;
        private System.Windows.Forms.Label storage_label;
        private System.Windows.Forms.Panel selection1_panel;
        private System.Windows.Forms.Label patientInfo_label;
        private System.Windows.Forms.Button btn_signout;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel patient_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search_patient;
        private System.Windows.Forms.TextBox patient_id_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patient_tc_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel storage_panel;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button btn_use;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Panel panel23;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Panel panel27;
        private System.Windows.Forms.Panel panel28;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label33;
        private System.Windows.Forms.DataGridView dataGridView3;
    }
}
