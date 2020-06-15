namespace InternetCafeServer
{
    partial class FormLogin
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.TxtUsername = new System.Windows.Forms.TextBox();
            this.Txtpassword = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // TxtUsername
            // 
            this.TxtUsername.Location = new System.Drawing.Point(259, 126);
            this.TxtUsername.Name = "TxtUsername";
            this.TxtUsername.Size = new System.Drawing.Size(219, 22);
            this.TxtUsername.TabIndex = 0;
            // 
            // Txtpassword
            // 
            this.Txtpassword.Location = new System.Drawing.Point(259, 195);
            this.Txtpassword.Name = "Txtpassword";
            this.Txtpassword.Size = new System.Drawing.Size(219, 22);
            this.Txtpassword.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(144, 126);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 17);
            this.label1.TabIndex = 2;
            this.label1.Text = "Username";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(144, 195);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 17);
            this.label2.TabIndex = 3;
            this.label2.Text = "Password";
            // 
            // ButLogin
            // 
            this.ButLogin.Location = new System.Drawing.Point(289, 258);
            this.ButLogin.Name = "ButLogin";
            this.ButLogin.Size = new System.Drawing.Size(147, 23);
            this.ButLogin.TabIndex = 4;
            this.ButLogin.Text = "Dang nhap";
            this.ButLogin.UseVisualStyleBackColor = true;
            this.ButLogin.Click += new System.EventHandler(this.ButLogin_Click);
            // 
            // FormLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ButLogin);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.Txtpassword);
            this.Controls.Add(this.TxtUsername);
            this.Name = "FormLogin";
            this.Text = "Dang nhap";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox TxtUsername;
        private System.Windows.Forms.TextBox Txtpassword;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButLogin;
    }
}