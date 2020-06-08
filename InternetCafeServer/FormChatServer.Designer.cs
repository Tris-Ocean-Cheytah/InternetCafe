namespace InternetCafeServer
{
    partial class FormChatServer
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
            this.sendMessBtn = new System.Windows.Forms.Button();
            this.txtChat = new System.Windows.Forms.TextBox();
            this.listBox = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // sendMessBtn
            // 
            this.sendMessBtn.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.sendMessBtn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.sendMessBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.sendMessBtn.Font = new System.Drawing.Font("Arial", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.sendMessBtn.Location = new System.Drawing.Point(287, 234);
            this.sendMessBtn.Name = "sendMessBtn";
            this.sendMessBtn.Size = new System.Drawing.Size(69, 24);
            this.sendMessBtn.TabIndex = 0;
            this.sendMessBtn.Text = "Gửi";
            this.sendMessBtn.UseVisualStyleBackColor = false;
            this.sendMessBtn.Click += new System.EventHandler(this.sendMessBtn_Click);
            // 
            // txtChat
            // 
            this.txtChat.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtChat.Location = new System.Drawing.Point(12, 234);
            this.txtChat.Name = "txtChat";
            this.txtChat.Size = new System.Drawing.Size(269, 24);
            this.txtChat.TabIndex = 1;
            // 
            // listBox
            // 
            this.listBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listBox.FormattingEnabled = true;
            this.listBox.ItemHeight = 20;
            this.listBox.Location = new System.Drawing.Point(12, 12);
            this.listBox.Name = "listBox";
            this.listBox.Size = new System.Drawing.Size(344, 204);
            this.listBox.TabIndex = 2;
            // 
            // FormChatServer
            // 
            this.AcceptButton = this.sendMessBtn;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(368, 270);
            this.Controls.Add(this.listBox);
            this.Controls.Add(this.txtChat);
            this.Controls.Add(this.sendMessBtn);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormChatServer";
            this.Text = "Giao tiếp";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormChat_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button sendMessBtn;
        private System.Windows.Forms.TextBox txtChat;
        private System.Windows.Forms.ListBox listBox;
    }
}