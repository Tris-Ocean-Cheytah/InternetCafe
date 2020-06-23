namespace InternetCafeClient
{
    partial class FormCart
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormCart));
            flowPnlCart = new System.Windows.Forms.FlowLayoutPanel();
            this.cancelPicBx = new System.Windows.Forms.PictureBox();
            this.acceptPicBx = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.cancelPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptPicBx)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            this.SuspendLayout();
            // 
            // flowPnlCart
            // 
            flowPnlCart.AutoScroll = true;
            flowPnlCart.BackColor = System.Drawing.SystemColors.AppWorkspace;
            flowPnlCart.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            flowPnlCart.Dock = System.Windows.Forms.DockStyle.Top;
            flowPnlCart.Location = new System.Drawing.Point(0, 0);
            flowPnlCart.Name = "flowPnlCart";
            flowPnlCart.Padding = new System.Windows.Forms.Padding(5);
            flowPnlCart.Size = new System.Drawing.Size(279, 334);
            flowPnlCart.TabIndex = 0;
            // 
            // cancelPicBx
            // 
            this.cancelPicBx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.cancelPicBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.cancelPicBx.Image = global::InternetCafeClient.Properties.Resources.cancel;
            this.cancelPicBx.Location = new System.Drawing.Point(174, 343);
            this.cancelPicBx.Name = "cancelPicBx";
            this.cancelPicBx.Size = new System.Drawing.Size(43, 40);
            this.cancelPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.cancelPicBx.TabIndex = 7;
            this.cancelPicBx.TabStop = false;
            this.cancelPicBx.Click += new System.EventHandler(this.cancelPicBx_Click);
            this.cancelPicBx.MouseEnter += new System.EventHandler(this.cancelPicBx_MouseEnter);
            // 
            // acceptPicBx
            // 
            this.acceptPicBx.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.acceptPicBx.Cursor = System.Windows.Forms.Cursors.Hand;
            this.acceptPicBx.Image = global::InternetCafeClient.Properties.Resources.accept;
            this.acceptPicBx.Location = new System.Drawing.Point(230, 343);
            this.acceptPicBx.Name = "acceptPicBx";
            this.acceptPicBx.Size = new System.Drawing.Size(43, 40);
            this.acceptPicBx.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.acceptPicBx.TabIndex = 6;
            this.acceptPicBx.TabStop = false;
            this.acceptPicBx.Click += new System.EventHandler(this.acceptPicBx_Click);
            this.acceptPicBx.MouseEnter += new System.EventHandler(this.acceptPicBx_MouseEnter);
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = global::InternetCafeClient.Properties.Resources.coke;
            this.pictureBox7.Location = new System.Drawing.Point(86, 350);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(42, 39);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox7.TabIndex = 16;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = global::InternetCafeClient.Properties.Resources.noodle;
            this.pictureBox5.Location = new System.Drawing.Point(16, 340);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(42, 39);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox5.TabIndex = 15;
            this.pictureBox5.TabStop = false;
            // 
            // FormCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(279, 401);
            this.Controls.Add(this.pictureBox7);
            this.Controls.Add(this.pictureBox5);
            this.Controls.Add(this.cancelPicBx);
            this.Controls.Add(this.acceptPicBx);
            this.Controls.Add(flowPnlCart);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormCart";
            this.Text = "Giỏ hàng";
            ((System.ComponentModel.ISupportInitialize)(this.cancelPicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acceptPicBx)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        public static System.Windows.Forms.FlowLayoutPanel flowPnlCart;
        private System.Windows.Forms.PictureBox cancelPicBx;
        private System.Windows.Forms.PictureBox acceptPicBx;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.ToolTip toolTip1;
    }
}