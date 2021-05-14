﻿
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.patient_panel = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btn_search_patient = new System.Windows.Forms.Button();
            this.patient_id_input = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.patient_tc_input = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.storage_panel = new System.Windows.Forms.Panel();
            this.label5 = new System.Windows.Forms.Label();
            this.sidePanel.SuspendLayout();
            this.selection2_panel.SuspendLayout();
            this.selection1_panel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.patient_panel.SuspendLayout();
            this.storage_panel.SuspendLayout();
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
            this.sidePanel.Controls.Add(this.pictureBox1);
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
            this.label1.Location = new System.Drawing.Point(139, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 28);
            this.label1.TabIndex = 4;
            this.label1.Text = "Deneme İsim";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.pictureBox1.Location = new System.Drawing.Point(14, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(100, 83);
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
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
            this.panel2.Location = new System.Drawing.Point(327, 193);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(691, 500);
            this.panel2.TabIndex = 7;
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
            this.storage_panel.Controls.Add(this.label5);
            this.storage_panel.Location = new System.Drawing.Point(319, 24);
            this.storage_panel.Name = "storage_panel";
            this.storage_panel.Size = new System.Drawing.Size(1018, 693);
            this.storage_panel.TabIndex = 6;
            this.storage_panel.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.SystemColors.AppWorkspace;
            this.label5.Location = new System.Drawing.Point(327, 123);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(130, 39);
            this.label5.TabIndex = 0;
            this.label5.Text = "storage";
            // 
            // NurseInterface
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.Controls.Add(this.patient_panel);
            this.Controls.Add(this.sidePanel);
            this.Controls.Add(this.storage_panel);
            this.Name = "NurseInterface";
            this.Size = new System.Drawing.Size(1360, 765);
            this.sidePanel.ResumeLayout(false);
            this.sidePanel.PerformLayout();
            this.selection2_panel.ResumeLayout(false);
            this.selection2_panel.PerformLayout();
            this.selection1_panel.ResumeLayout(false);
            this.selection1_panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.patient_panel.ResumeLayout(false);
            this.patient_panel.PerformLayout();
            this.storage_panel.ResumeLayout(false);
            this.storage_panel.PerformLayout();
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Panel patient_panel;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btn_search_patient;
        private System.Windows.Forms.TextBox patient_id_input;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox patient_tc_input;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel storage_panel;
        private System.Windows.Forms.Label label5;
    }
}
