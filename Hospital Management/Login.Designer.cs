﻿
namespace Hospital_Management
{
    partial class Login
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
            this.tcbox = new System.Windows.Forms.TextBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.lbl_register = new System.Windows.Forms.Label();
            this.lbl_forgot = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btn_login = new System.Windows.Forms.Button();
            this.passwordpanel = new System.Windows.Forms.Panel();
            this.passbox = new System.Windows.Forms.TextBox();
            this.tcpanel = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.LoginPanel.SuspendLayout();
            this.passwordpanel.SuspendLayout();
            this.tcpanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
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
            this.tcbox.Size = new System.Drawing.Size(169, 26);
            this.tcbox.TabIndex = 1;
            this.tcbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.tcbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tcbox_KeyPress);
            // 
            // LoginPanel
            // 
            this.LoginPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.LoginPanel.Controls.Add(this.lbl_register);
            this.LoginPanel.Controls.Add(this.lbl_forgot);
            this.LoginPanel.Controls.Add(this.label2);
            this.LoginPanel.Controls.Add(this.label1);
            this.LoginPanel.Controls.Add(this.btn_login);
            this.LoginPanel.Controls.Add(this.passwordpanel);
            this.LoginPanel.Controls.Add(this.tcpanel);
            this.LoginPanel.Location = new System.Drawing.Point(288, 155);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(256, 262);
            this.LoginPanel.TabIndex = 4;
            // 
            // lbl_register
            // 
            this.lbl_register.AutoSize = true;
            this.lbl_register.ForeColor = System.Drawing.Color.White;
            this.lbl_register.Location = new System.Drawing.Point(172, 236);
            this.lbl_register.Name = "lbl_register";
            this.lbl_register.Size = new System.Drawing.Size(46, 13);
            this.lbl_register.TabIndex = 11;
            this.lbl_register.Text = "Register";
            this.lbl_register.Click += new System.EventHandler(this.lbl_register_Click);
            // 
            // lbl_forgot
            // 
            this.lbl_forgot.AutoSize = true;
            this.lbl_forgot.ForeColor = System.Drawing.Color.White;
            this.lbl_forgot.Location = new System.Drawing.Point(40, 236);
            this.lbl_forgot.Name = "lbl_forgot";
            this.lbl_forgot.Size = new System.Drawing.Size(91, 13);
            this.lbl_forgot.TabIndex = 10;
            this.lbl_forgot.Text = "Forgot password?";
            this.lbl_forgot.Click += new System.EventHandler(this.lbl_forgot_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(40, 103);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Password:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(40, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(24, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "TC:";
            // 
            // btn_login
            // 
            this.btn_login.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.btn_login.FlatAppearance.BorderSize = 0;
            this.btn_login.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_login.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(243)))), ((int)(((byte)(243)))), ((int)(((byte)(243)))));
            this.btn_login.Location = new System.Drawing.Point(84, 185);
            this.btn_login.Name = "btn_login";
            this.btn_login.Size = new System.Drawing.Size(95, 36);
            this.btn_login.TabIndex = 7;
            this.btn_login.Text = "Login";
            this.btn_login.UseVisualStyleBackColor = false;
            this.btn_login.Click += new System.EventHandler(this.btn_login_Click);
            // 
            // passwordpanel
            // 
            this.passwordpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.passwordpanel.Controls.Add(this.passbox);
            this.passwordpanel.Location = new System.Drawing.Point(43, 119);
            this.passwordpanel.Name = "passwordpanel";
            this.passwordpanel.Size = new System.Drawing.Size(175, 51);
            this.passwordpanel.TabIndex = 3;
            // 
            // passbox
            // 
            this.passbox.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.passbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.passbox.ForeColor = System.Drawing.Color.White;
            this.passbox.Location = new System.Drawing.Point(3, 12);
            this.passbox.MaxLength = 255;
            this.passbox.Multiline = true;
            this.passbox.Name = "passbox";
            this.passbox.PasswordChar = '*';
            this.passbox.Size = new System.Drawing.Size(169, 26);
            this.passbox.TabIndex = 1;
            this.passbox.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tcpanel
            // 
            this.tcpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(54)))), ((int)(((byte)(81)))));
            this.tcpanel.Controls.Add(this.tcbox);
            this.tcpanel.Location = new System.Drawing.Point(43, 36);
            this.tcpanel.Name = "tcpanel";
            this.tcpanel.Size = new System.Drawing.Size(175, 51);
            this.tcpanel.TabIndex = 2;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Hospital_Management.Properties.Resources.saslogo;
            this.pictureBox1.Location = new System.Drawing.Point(288, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(256, 156);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(47)))), ((int)(((byte)(90)))), ((int)(((byte)(101)))));
            this.Controls.Add(this.LoginPanel);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(817, 556);
            this.Load += new System.EventHandler(this.Login_Load);
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            this.LoginPanel.ResumeLayout(false);
            this.LoginPanel.PerformLayout();
            this.passwordpanel.ResumeLayout(false);
            this.passwordpanel.PerformLayout();
            this.tcpanel.ResumeLayout(false);
            this.tcpanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.TextBox tcbox;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel passwordpanel;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Panel tcpanel;
        private System.Windows.Forms.Button btn_login;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_register;
        private System.Windows.Forms.Label lbl_forgot;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}
