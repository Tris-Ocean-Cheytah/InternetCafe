namespace InternetCafeClient
{
    partial class TimingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TimingForm));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.perHourTxtBox = new System.Windows.Forms.TextBox();
            this.lblRemainTime = new System.Windows.Forms.Label();
            this.lblUseTimeFee = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.logoutPicBox = new System.Windows.Forms.PictureBox();
            this.foodPicBox = new System.Windows.Forms.PictureBox();
            this.messPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.textBox3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.textBox2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Controls.Add(this.perHourTxtBox);
            this.groupBox1.Controls.Add(this.lblRemainTime);
            this.groupBox1.Controls.Add(this.lblUseTimeFee);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(237, 177);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Username";
            // 
            // textBox3
            // 
            this.textBox3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox3.Location = new System.Drawing.Point(148, 84);
            this.textBox3.Name = "textBox3";
            this.textBox3.ReadOnly = true;
            this.textBox3.Size = new System.Drawing.Size(79, 20);
            this.textBox3.TabIndex = 12;
            this.textBox3.Text = "??? time";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(9, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 15);
            this.label2.TabIndex = 11;
            this.label2.Text = "Thời gian sử dụng:";
            // 
            // textBox2
            // 
            this.textBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox2.Location = new System.Drawing.Point(148, 19);
            this.textBox2.Name = "textBox2";
            this.textBox2.ReadOnly = true;
            this.textBox2.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.textBox2.Size = new System.Drawing.Size(79, 20);
            this.textBox2.TabIndex = 10;
            this.textBox2.Text = "??? vnd";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(6, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng tiền còn lại (vnd):";
            // 
            // textBox1
            // 
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox1.Location = new System.Drawing.Point(148, 117);
            this.textBox1.Name = "textBox1";
            this.textBox1.ReadOnly = true;
            this.textBox1.Size = new System.Drawing.Size(79, 20);
            this.textBox1.TabIndex = 8;
            this.textBox1.Text = "??? time";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // perHourTxtBox
            // 
            this.perHourTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perHourTxtBox.Location = new System.Drawing.Point(148, 52);
            this.perHourTxtBox.Name = "perHourTxtBox";
            this.perHourTxtBox.ReadOnly = true;
            this.perHourTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.perHourTxtBox.Size = new System.Drawing.Size(79, 20);
            this.perHourTxtBox.TabIndex = 7;
            this.perHourTxtBox.Text = "??? vnd";
            this.perHourTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // lblRemainTime
            // 
            this.lblRemainTime.AutoSize = true;
            this.lblRemainTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRemainTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemainTime.Location = new System.Drawing.Point(9, 118);
            this.lblRemainTime.Name = "lblRemainTime";
            this.lblRemainTime.Size = new System.Drawing.Size(103, 15);
            this.lblRemainTime.TabIndex = 5;
            this.lblRemainTime.Text = "Thời gian còn lại:";
            // 
            // lblUseTimeFee
            // 
            this.lblUseTimeFee.AutoSize = true;
            this.lblUseTimeFee.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUseTimeFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUseTimeFee.Location = new System.Drawing.Point(9, 53);
            this.lblUseTimeFee.Name = "lblUseTimeFee";
            this.lblUseTimeFee.Size = new System.Drawing.Size(122, 15);
            this.lblUseTimeFee.TabIndex = 4;
            this.lblUseTimeFee.Text = "Phí dịch vụ (vnd/giờ):";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(12, 143);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(215, 18);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // logoutPicBox
            // 
            this.logoutPicBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logoutPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoutPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutPicBox.Location = new System.Drawing.Point(185, 195);
            this.logoutPicBox.Name = "logoutPicBox";
            this.logoutPicBox.Size = new System.Drawing.Size(54, 50);
            this.logoutPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.logoutPicBox.TabIndex = 10;
            this.logoutPicBox.TabStop = false;
            this.logoutPicBox.Click += new System.EventHandler(this.logoutPicBox_Click);
            this.logoutPicBox.MouseEnter += new System.EventHandler(this.logoutPicBox_MouseEnter);
            // 
            // foodPicBox
            // 
            this.foodPicBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.foodPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.foodPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.foodPicBox.Location = new System.Drawing.Point(105, 195);
            this.foodPicBox.Name = "foodPicBox";
            this.foodPicBox.Size = new System.Drawing.Size(54, 50);
            this.foodPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.foodPicBox.TabIndex = 9;
            this.foodPicBox.TabStop = false;
            this.foodPicBox.Click += new System.EventHandler(this.foodPicBox_Click);
            this.foodPicBox.MouseEnter += new System.EventHandler(this.foodPicBox_MouseEnter);
            // 
            // messPicBox
            // 
            this.messPicBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.messPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.messPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.messPicBox.Location = new System.Drawing.Point(21, 195);
            this.messPicBox.Name = "messPicBox";
            this.messPicBox.Size = new System.Drawing.Size(54, 50);
            this.messPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.messPicBox.TabIndex = 8;
            this.messPicBox.TabStop = false;
            this.messPicBox.Click += new System.EventHandler(this.pictureBox2_Click);
            this.messPicBox.MouseEnter += new System.EventHandler(this.messPicBox_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 263);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(237, 184);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // TimingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(259, 459);
            this.Controls.Add(this.logoutPicBox);
            this.Controls.Add(this.foodPicBox);
            this.Controls.Add(this.messPicBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TimingForm";
            this.RightToLeftLayout = true;
            this.Text = "Timing";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TimingForm_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.messPicBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRemainTime;
        private System.Windows.Forms.Label lblUseTimeFee;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox perHourTxtBox;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox messPicBox;
        private System.Windows.Forms.PictureBox foodPicBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.PictureBox logoutPicBox;
    }
}