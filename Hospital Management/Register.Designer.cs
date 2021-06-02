
namespace Hospital_Management
{
    partial class Register
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
            this.RegisterPanel = new System.Windows.Forms.Panel();
            this.btn_register = new System.Windows.Forms.Button();
            this.btn_clear = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panel4 = new System.Windows.Forms.Panel();
            this.sectionbox = new System.Windows.Forms.ComboBox();
            this.panel3 = new System.Windows.Forms.Panel();
            this.tcbox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.mailbox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.surname = new System.Windows.Forms.TextBox();
            this.tcpanel = new System.Windows.Forms.Panel();
            this.name = new System.Windows.Forms.TextBox();
            this.RegisterPanel.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            this.tcpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // RegisterPanel
            // 
            this.RegisterPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.RegisterPanel.Controls.Add(this.btn_register);
            this.RegisterPanel.Controls.Add(this.btn_clear);
            this.RegisterPanel.Controls.Add(this.label5);
            this.RegisterPanel.Controls.Add(this.label4);
            this.RegisterPanel.Controls.Add(this.label3);
            this.RegisterPanel.Controls.Add(this.label2);
            this.RegisterPanel.Controls.Add(this.label1);
            this.RegisterPanel.Controls.Add(this.panel4);
            this.RegisterPanel.Controls.Add(this.panel3);
            this.RegisterPanel.Controls.Add(this.panel2);
            this.RegisterPanel.Controls.Add(this.panel1);
            this.RegisterPanel.Controls.Add(this.tcpanel);
            this.RegisterPanel.Location = new System.Drawing.Point(166, 73);
            this.RegisterPanel.Name = "RegisterPanel";
            this.RegisterPanel.Size = new System.Drawing.Size(337, 490);
            this.RegisterPanel.TabIndex = 5;
            // 
            // btn_register
            // 
            this.btn_register.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(54)))), ((int)(((byte)(165)))), ((int)(((byte)(87)))));
            this.btn_register.FlatAppearance.BorderSize = 0;
            this.btn_register.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_register.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_register.Location = new System.Drawing.Point(179, 429);
            this.btn_register.Name = "btn_register";
            this.btn_register.Size = new System.Drawing.Size(95, 36);
            this.btn_register.TabIndex = 14;
            this.btn_register.Text = "Register";
            this.btn_register.UseVisualStyleBackColor = false;
            this.btn_register.Click += new System.EventHandler(this.btn_register_Click);
            // 
            // btn_clear
            // 
            this.btn_clear.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(81)))), ((int)(((byte)(40)))), ((int)(((byte)(44)))));
            this.btn_clear.FlatAppearance.BorderSize = 0;
            this.btn_clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_clear.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_clear.Location = new System.Drawing.Point(62, 429);
            this.btn_clear.Name = "btn_clear";
            this.btn_clear.Size = new System.Drawing.Size(95, 36);
            this.btn_clear.TabIndex = 13;
            this.btn_clear.Text = "Clear";
            this.btn_clear.UseVisualStyleBackColor = false;
            this.btn_clear.Click += new System.EventHandler(this.btn_clear_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(62, 342);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(46, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Section:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(62, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(41, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "TC No:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(62, 182);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(39, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "E-Mail:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(62, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Surname:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(62, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Name:";
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel4.Controls.Add(this.sectionbox);
            this.panel4.Location = new System.Drawing.Point(62, 358);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(212, 51);
            this.panel4.TabIndex = 7;
            // 
            // sectionbox
            // 
            this.sectionbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.sectionbox.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sectionbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.sectionbox.ForeColor = System.Drawing.SystemColors.Window;
            this.sectionbox.FormattingEnabled = true;
            this.sectionbox.Items.AddRange(new object[] {
            "doctor",
            "nurse",
            "staff"});
            this.sectionbox.Location = new System.Drawing.Point(3, 16);
            this.sectionbox.Name = "sectionbox";
            this.sectionbox.Size = new System.Drawing.Size(206, 24);
            this.sectionbox.TabIndex = 0;
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel3.Controls.Add(this.tcbox);
            this.panel3.Location = new System.Drawing.Point(62, 278);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(212, 51);
            this.panel3.TabIndex = 6;
            // 
            // tcbox
            // 
            this.tcbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.tcbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tcbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.tcbox.ForeColor = System.Drawing.Color.White;
            this.tcbox.Location = new System.Drawing.Point(3, 12);
            this.tcbox.MaxLength = 11;
            this.tcbox.Multiline = true;
            this.tcbox.Name = "tcbox";
            this.tcbox.Size = new System.Drawing.Size(206, 26);
            this.tcbox.TabIndex = 1;
            this.tcbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel2.Controls.Add(this.mailbox);
            this.panel2.Location = new System.Drawing.Point(62, 198);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(212, 51);
            this.panel2.TabIndex = 5;
            // 
            // mailbox
            // 
            this.mailbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.mailbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.mailbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.mailbox.ForeColor = System.Drawing.Color.White;
            this.mailbox.Location = new System.Drawing.Point(3, 12);
            this.mailbox.MaxLength = 32000;
            this.mailbox.Multiline = true;
            this.mailbox.Name = "mailbox";
            this.mailbox.Size = new System.Drawing.Size(206, 26);
            this.mailbox.TabIndex = 1;
            this.mailbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.panel1.Controls.Add(this.surname);
            this.panel1.Location = new System.Drawing.Point(62, 118);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(212, 51);
            this.panel1.TabIndex = 4;
            // 
            // surname
            // 
            this.surname.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.surname.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.surname.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.surname.ForeColor = System.Drawing.Color.White;
            this.surname.Location = new System.Drawing.Point(3, 12);
            this.surname.MaxLength = 32000;
            this.surname.Multiline = true;
            this.surname.Name = "surname";
            this.surname.Size = new System.Drawing.Size(206, 26);
            this.surname.TabIndex = 1;
            this.surname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tcpanel
            // 
            this.tcpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.tcpanel.Controls.Add(this.name);
            this.tcpanel.Location = new System.Drawing.Point(62, 38);
            this.tcpanel.Name = "tcpanel";
            this.tcpanel.Size = new System.Drawing.Size(212, 51);
            this.tcpanel.TabIndex = 3;
            // 
            // name
            // 
            this.name.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.name.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.name.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.name.ForeColor = System.Drawing.Color.White;
            this.name.Location = new System.Drawing.Point(3, 12);
            this.name.MaxLength = 32000;
            this.name.Multiline = true;
            this.name.Name = "name";
            this.name.Size = new System.Drawing.Size(206, 26);
            this.name.TabIndex = 1;
            this.name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.Controls.Add(this.RegisterPanel);
            this.Name = "Register";
            this.Size = new System.Drawing.Size(666, 650);
            this.RegisterPanel.ResumeLayout(false);
            this.RegisterPanel.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.tcpanel.ResumeLayout(false);
            this.tcpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel RegisterPanel;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.ComboBox sectionbox;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.TextBox tcbox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox mailbox;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox surname;
        private System.Windows.Forms.Panel tcpanel;
        private System.Windows.Forms.TextBox name;
        private System.Windows.Forms.Button btn_register;
        private System.Windows.Forms.Button btn_clear;
    }
}
