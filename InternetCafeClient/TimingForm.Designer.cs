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
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.perHourTxtBox = new System.Windows.Forms.TextBox();
            this.lblRemainTime = new System.Windows.Forms.Label();
            this.lblUseTimeFee = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.logoutPicBox = new System.Windows.Forms.PictureBox();
            this.foodPicBox = new System.Windows.Forms.PictureBox();
            this.messPicBox = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.MoneyRemaining = new System.Windows.Forms.Label();
            this.GioConLai = new System.Windows.Forms.Label();
            this.PhutConLai = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.GiayConLai = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.label7 = new System.Windows.Forms.Label();
            this.GiayDaSuDung = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.PhutDaSuDung = new System.Windows.Forms.Label();
            this.GioDaSuDung = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.logoutPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.foodPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.messPicBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.groupBox3);
            this.groupBox1.Controls.Add(this.MoneyRemaining);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.perHourTxtBox);
            this.groupBox1.Controls.Add(this.lblRemainTime);
            this.groupBox1.Controls.Add(this.lblUseTimeFee);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.groupBox2);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.groupBox1.Location = new System.Drawing.Point(16, 15);
            this.groupBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.groupBox1.Size = new System.Drawing.Size(316, 218);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Username";
            this.groupBox1.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Location = new System.Drawing.Point(12, 105);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 19);
            this.label2.TabIndex = 11;
            this.label2.Text = "Thời gian sử dụng:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label1.Location = new System.Drawing.Point(8, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 19);
            this.label1.TabIndex = 9;
            this.label1.Text = "Tổng tiền còn lại (vnd):";
            // 
            // perHourTxtBox
            // 
            this.perHourTxtBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.perHourTxtBox.Font = new System.Drawing.Font("Times New Roman", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.perHourTxtBox.Location = new System.Drawing.Point(197, 64);
            this.perHourTxtBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.perHourTxtBox.Name = "perHourTxtBox";
            this.perHourTxtBox.ReadOnly = true;
            this.perHourTxtBox.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.perHourTxtBox.Size = new System.Drawing.Size(105, 27);
            this.perHourTxtBox.TabIndex = 7;
            this.perHourTxtBox.Text = "18000 VND";
            this.perHourTxtBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.perHourTxtBox.TextChanged += new System.EventHandler(this.PerHourTxtBox_TextChanged);
            // 
            // lblRemainTime
            // 
            this.lblRemainTime.AutoSize = true;
            this.lblRemainTime.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblRemainTime.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblRemainTime.Location = new System.Drawing.Point(12, 145);
            this.lblRemainTime.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblRemainTime.Name = "lblRemainTime";
            this.lblRemainTime.Size = new System.Drawing.Size(139, 19);
            this.lblRemainTime.TabIndex = 5;
            this.lblRemainTime.Text = "Thời gian còn lại:";
            // 
            // lblUseTimeFee
            // 
            this.lblUseTimeFee.AutoSize = true;
            this.lblUseTimeFee.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.lblUseTimeFee.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lblUseTimeFee.Location = new System.Drawing.Point(12, 65);
            this.lblUseTimeFee.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblUseTimeFee.Name = "lblUseTimeFee";
            this.lblUseTimeFee.Size = new System.Drawing.Size(169, 19);
            this.lblUseTimeFee.TabIndex = 4;
            this.lblUseTimeFee.Text = "Phí dịch vụ (vnd/giờ):";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(16, 176);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(287, 22);
            this.progressBar1.TabIndex = 0;
            this.progressBar1.Value = 50;
            // 
            // logoutPicBox
            // 
            this.logoutPicBox.BackColor = System.Drawing.SystemColors.ControlLight;
            this.logoutPicBox.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.logoutPicBox.Cursor = System.Windows.Forms.Cursors.Hand;
            this.logoutPicBox.Image = global::InternetCafeClient.Properties.Resources._out;
            this.logoutPicBox.Location = new System.Drawing.Point(247, 240);
            this.logoutPicBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.logoutPicBox.Name = "logoutPicBox";
            this.logoutPicBox.Size = new System.Drawing.Size(71, 61);
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
            this.foodPicBox.Image = global::InternetCafeClient.Properties.Resources.restaurant;
            this.foodPicBox.Location = new System.Drawing.Point(140, 240);
            this.foodPicBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.foodPicBox.Name = "foodPicBox";
            this.foodPicBox.Size = new System.Drawing.Size(71, 61);
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
            this.messPicBox.Image = global::InternetCafeClient.Properties.Resources.mess;
            this.messPicBox.Location = new System.Drawing.Point(28, 240);
            this.messPicBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.messPicBox.Name = "messPicBox";
            this.messPicBox.Size = new System.Drawing.Size(71, 61);
            this.messPicBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.messPicBox.TabIndex = 8;
            this.messPicBox.TabStop = false;
            this.messPicBox.Click += new System.EventHandler(this.pictureBox2_Click);
            this.messPicBox.MouseEnter += new System.EventHandler(this.messPicBox_MouseEnter);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::InternetCafeClient.Properties.Resources.unnamed;
            this.pictureBox1.Location = new System.Drawing.Point(16, 324);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(316, 226);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // MoneyRemaining
            // 
            this.MoneyRemaining.AutoSize = true;
            this.MoneyRemaining.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.MoneyRemaining.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.MoneyRemaining.Location = new System.Drawing.Point(197, 25);
            this.MoneyRemaining.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.MoneyRemaining.Name = "MoneyRemaining";
            this.MoneyRemaining.Size = new System.Drawing.Size(27, 19);
            this.MoneyRemaining.TabIndex = 15;
            this.MoneyRemaining.Text = "00";
            // 
            // GioConLai
            // 
            this.GioConLai.AutoSize = true;
            this.GioConLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioConLai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GioConLai.Location = new System.Drawing.Point(7, 15);
            this.GioConLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GioConLai.Name = "GioConLai";
            this.GioConLai.Size = new System.Drawing.Size(27, 19);
            this.GioConLai.TabIndex = 17;
            this.GioConLai.Text = "00";
            this.GioConLai.Click += new System.EventHandler(this.TimeRemaining_Click);
            // 
            // PhutConLai
            // 
            this.PhutConLai.AutoSize = true;
            this.PhutConLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PhutConLai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PhutConLai.Location = new System.Drawing.Point(58, 15);
            this.PhutConLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhutConLai.Name = "PhutConLai";
            this.PhutConLai.Size = new System.Drawing.Size(27, 19);
            this.PhutConLai.TabIndex = 18;
            this.PhutConLai.Text = "00";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label4.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label4.Location = new System.Drawing.Point(39, 15);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 19);
            this.label4.TabIndex = 19;
            this.label4.Text = ":";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.PhutConLai);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.GioConLai);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.GiayConLai);
            this.groupBox2.Location = new System.Drawing.Point(158, 130);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(151, 39);
            this.groupBox2.TabIndex = 20;
            this.groupBox2.TabStop = false;
            // 
            // GiayConLai
            // 
            this.GiayConLai.AutoSize = true;
            this.GiayConLai.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GiayConLai.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GiayConLai.Location = new System.Drawing.Point(110, 15);
            this.GiayConLai.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GiayConLai.Name = "GiayConLai";
            this.GiayConLai.Size = new System.Drawing.Size(27, 19);
            this.GiayConLai.TabIndex = 21;
            this.GiayConLai.Text = "00";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label6.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label6.Location = new System.Drawing.Point(93, 15);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(15, 19);
            this.label6.TabIndex = 21;
            this.label6.Text = ":";
            // 
            // timer2
            // 
            this.timer2.Interval = 5000;
            this.timer2.Tick += new System.EventHandler(this.Timer2_Tick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label7.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Location = new System.Drawing.Point(93, 12);
            this.label7.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(15, 19);
            this.label7.TabIndex = 21;
            this.label7.Text = ":";
            // 
            // GiayDaSuDung
            // 
            this.GiayDaSuDung.AutoSize = true;
            this.GiayDaSuDung.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GiayDaSuDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GiayDaSuDung.Location = new System.Drawing.Point(110, 12);
            this.GiayDaSuDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GiayDaSuDung.Name = "GiayDaSuDung";
            this.GiayDaSuDung.Size = new System.Drawing.Size(27, 19);
            this.GiayDaSuDung.TabIndex = 21;
            this.GiayDaSuDung.Text = "00";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label9.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Location = new System.Drawing.Point(35, 15);
            this.label9.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(15, 19);
            this.label9.TabIndex = 24;
            this.label9.Text = ":";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label10.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Location = new System.Drawing.Point(58, 15);
            this.label10.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(27, 19);
            this.label10.TabIndex = 23;
            this.label10.Text = "00";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label11.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label11.Location = new System.Drawing.Point(4, 15);
            this.label11.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(27, 19);
            this.label11.TabIndex = 22;
            this.label11.Text = "00";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.label14);
            this.groupBox3.Controls.Add(this.GioDaSuDung);
            this.groupBox3.Controls.Add(this.PhutDaSuDung);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.GiayDaSuDung);
            this.groupBox3.Location = new System.Drawing.Point(158, 93);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(151, 39);
            this.groupBox3.TabIndex = 25;
            this.groupBox3.TabStop = false;
            // 
            // PhutDaSuDung
            // 
            this.PhutDaSuDung.AutoSize = true;
            this.PhutDaSuDung.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.PhutDaSuDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.PhutDaSuDung.Location = new System.Drawing.Point(58, 12);
            this.PhutDaSuDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.PhutDaSuDung.Name = "PhutDaSuDung";
            this.PhutDaSuDung.Size = new System.Drawing.Size(27, 19);
            this.PhutDaSuDung.TabIndex = 22;
            this.PhutDaSuDung.Text = "00";
            // 
            // GioDaSuDung
            // 
            this.GioDaSuDung.AutoSize = true;
            this.GioDaSuDung.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.GioDaSuDung.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.GioDaSuDung.Location = new System.Drawing.Point(7, 12);
            this.GioDaSuDung.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.GioDaSuDung.Name = "GioDaSuDung";
            this.GioDaSuDung.Size = new System.Drawing.Size(27, 19);
            this.GioDaSuDung.TabIndex = 23;
            this.GioDaSuDung.Text = "00";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Times New Roman", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label14.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label14.Location = new System.Drawing.Point(39, 12);
            this.label14.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(15, 19);
            this.label14.TabIndex = 24;
            this.label14.Text = ":";
            // 
            // TimingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.Disable;
            this.ClientSize = new System.Drawing.Size(345, 565);
            this.Controls.Add(this.logoutPicBox);
            this.Controls.Add(this.foodPicBox);
            this.Controls.Add(this.messPicBox);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
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
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblRemainTime;
        private System.Windows.Forms.Label lblUseTimeFee;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox perHourTxtBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox messPicBox;
        private System.Windows.Forms.PictureBox foodPicBox;
        private System.Windows.Forms.PictureBox logoutPicBox;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label GioConLai;
        private System.Windows.Forms.Label MoneyRemaining;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label PhutConLai;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label GiayConLai;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label GioDaSuDung;
        private System.Windows.Forms.Label PhutDaSuDung;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label GiayDaSuDung;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
    }
}