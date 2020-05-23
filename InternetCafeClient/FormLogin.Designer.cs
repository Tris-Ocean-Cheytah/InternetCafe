namespace InternetCafeClient
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormLogin));
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.loginButton = new System.Windows.Forms.Button();
            this.passTxtBx = new System.Windows.Forms.TextBox();
            this.userTxtBx = new System.Windows.Forms.TextBox();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.BackColor = System.Drawing.Color.Transparent;
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.loginButton);
            this.panel2.Controls.Add(this.passTxtBx);
            this.panel2.Controls.Add(this.userTxtBx);
            this.panel2.Location = new System.Drawing.Point(165, 96);
            this.panel2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(484, 287);
            this.panel2.TabIndex = 19;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Image = global::InternetCafeClient.Properties.Resources.pass;
            this.pictureBox2.Location = new System.Drawing.Point(371, 132);
            this.pictureBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 30);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 21;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Image = global::InternetCafeClient.Properties.Resources.user;
            this.pictureBox1.Location = new System.Drawing.Point(371, 64);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 20;
            this.pictureBox1.TabStop = false;
            // 
            // loginButton
            // 
            this.loginButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.loginButton.BackColor = System.Drawing.SystemColors.ControlLight;
            this.loginButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.loginButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginButton.Location = new System.Drawing.Point(192, 186);
            this.loginButton.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.loginButton.Name = "loginButton";
            this.loginButton.Size = new System.Drawing.Size(120, 38);
            this.loginButton.TabIndex = 19;
            this.loginButton.Text = "Login";
            this.loginButton.UseVisualStyleBackColor = false;
            this.loginButton.Click += new System.EventHandler(this.loginButton_Click);
            // 
            // passTxtBx
            // 
            this.passTxtBx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passTxtBx.CausesValidation = false;
            this.passTxtBx.Font = new System.Drawing.Font("Calibri Light", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passTxtBx.Location = new System.Drawing.Point(108, 129);
            this.passTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.passTxtBx.Name = "passTxtBx";
            this.passTxtBx.PasswordChar = '*';
            this.passTxtBx.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.passTxtBx.Size = new System.Drawing.Size(295, 33);
            this.passTxtBx.TabIndex = 18;
            this.passTxtBx.Text = "Password";
            this.passTxtBx.UseSystemPasswordChar = true;
            this.passTxtBx.TextChanged += new System.EventHandler(this.passTxtBx_TextChanged);
            // 
            // userTxtBx
            // 
            this.userTxtBx.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userTxtBx.Font = new System.Drawing.Font("Calibri Light", 12.5F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userTxtBx.Location = new System.Drawing.Point(108, 62);
            this.userTxtBx.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.userTxtBx.Name = "userTxtBx";
            this.userTxtBx.Size = new System.Drawing.Size(295, 33);
            this.userTxtBx.TabIndex = 17;
            this.userTxtBx.Text = "Username";
            this.userTxtBx.TextChanged += new System.EventHandler(this.userTxtBx_TextChanged);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::InternetCafeClient.Properties.Resources.loginPic;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(813, 479);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button loginButton;
        private System.Windows.Forms.TextBox passTxtBx;
        private System.Windows.Forms.TextBox userTxtBx;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

