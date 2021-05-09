
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
            this.button1 = new System.Windows.Forms.Button();
            this.tcbox = new System.Windows.Forms.TextBox();
            this.LoginPanel = new System.Windows.Forms.Panel();
            this.tcpanel = new System.Windows.Forms.Panel();
            this.passwordpanel = new System.Windows.Forms.Panel();
            this.passbox = new System.Windows.Forms.TextBox();
            this.LoginPanel.SuspendLayout();
            this.tcpanel.SuspendLayout();
            this.passwordpanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(89, 173);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // tcbox
            // 
            this.tcbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.tcbox.Location = new System.Drawing.Point(15, 12);
            this.tcbox.Multiline = true;
            this.tcbox.Name = "tcbox";
            this.tcbox.Size = new System.Drawing.Size(143, 26);
            this.tcbox.TabIndex = 1;
            // 
            // LoginPanel
            // 
            this.LoginPanel.Controls.Add(this.passwordpanel);
            this.LoginPanel.Controls.Add(this.tcpanel);
            this.LoginPanel.Controls.Add(this.button1);
            this.LoginPanel.Location = new System.Drawing.Point(288, 155);
            this.LoginPanel.Name = "LoginPanel";
            this.LoginPanel.Size = new System.Drawing.Size(256, 251);
            this.LoginPanel.TabIndex = 4;
            // 
            // tcpanel
            // 
            this.tcpanel.Controls.Add(this.tcbox);
            this.tcpanel.Location = new System.Drawing.Point(43, 36);
            this.tcpanel.Name = "tcpanel";
            this.tcpanel.Size = new System.Drawing.Size(175, 51);
            this.tcpanel.TabIndex = 2;
            this.tcpanel.Paint += new System.Windows.Forms.PaintEventHandler(this.tcpanel_Paint);
            // 
            // passwordpanel
            // 
            this.passwordpanel.Controls.Add(this.passbox);
            this.passwordpanel.Location = new System.Drawing.Point(43, 93);
            this.passwordpanel.Name = "passwordpanel";
            this.passwordpanel.Size = new System.Drawing.Size(175, 51);
            this.passwordpanel.TabIndex = 3;
            // 
            // passbox
            // 
            this.passbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.passbox.Location = new System.Drawing.Point(15, 12);
            this.passbox.Multiline = true;
            this.passbox.Name = "passbox";
            this.passbox.Size = new System.Drawing.Size(143, 26);
            this.passbox.TabIndex = 1;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.Controls.Add(this.LoginPanel);
            this.Name = "Login";
            this.Size = new System.Drawing.Size(817, 556);
            this.Load += new System.EventHandler(this.Login_Load);
            this.SizeChanged += new System.EventHandler(this.Login_SizeChanged);
            this.LoginPanel.ResumeLayout(false);
            this.tcpanel.ResumeLayout(false);
            this.tcpanel.PerformLayout();
            this.passwordpanel.ResumeLayout(false);
            this.passwordpanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox tcbox;
        private System.Windows.Forms.Panel LoginPanel;
        private System.Windows.Forms.Panel passwordpanel;
        private System.Windows.Forms.TextBox passbox;
        private System.Windows.Forms.Panel tcpanel;
    }
}
