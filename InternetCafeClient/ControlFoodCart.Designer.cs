namespace InternetCafeClient
{
    partial class ControlFoodCart
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblName = new System.Windows.Forms.Label();
            this.numAmount = new System.Windows.Forms.NumericUpDown();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnMinus = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).BeginInit();
            this.SuspendLayout();
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(92, 8);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(51, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "label1";
            // 
            // numAmount
            // 
            this.numAmount.Location = new System.Drawing.Point(143, 40);
            this.numAmount.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numAmount.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numAmount.Name = "numAmount";
            this.numAmount.Size = new System.Drawing.Size(43, 20);
            this.numAmount.TabIndex = 1;
            this.numAmount.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // txtPrice
            // 
            this.txtPrice.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtPrice.Location = new System.Drawing.Point(38, 40);
            this.txtPrice.Margin = new System.Windows.Forms.Padding(0);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.ReadOnly = true;
            this.txtPrice.Size = new System.Drawing.Size(88, 20);
            this.txtPrice.TabIndex = 5;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 41);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Giá";
            // 
            // btnMinus
            // 
            this.btnMinus.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(240)))), ((int)(((byte)(240)))), ((int)(((byte)(240)))));
            this.btnMinus.BackgroundImage = global::InternetCafeClient.Properties.Resources.minus;
            this.btnMinus.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnMinus.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMinus.Location = new System.Drawing.Point(201, 32);
            this.btnMinus.Name = "btnMinus";
            this.btnMinus.Size = new System.Drawing.Size(30, 30);
            this.btnMinus.TabIndex = 8;
            this.btnMinus.UseVisualStyleBackColor = false;
            this.btnMinus.Click += new System.EventHandler(this.btnMinus_Click);
            // 
            // ControlFoodCart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.btnMinus);
            this.Controls.Add(this.txtPrice);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.numAmount);
            this.Controls.Add(this.lblName);
            this.Margin = new System.Windows.Forms.Padding(5);
            this.Name = "ControlFoodCart";
            this.Size = new System.Drawing.Size(242, 68);
            ((System.ComponentModel.ISupportInitialize)(this.numAmount)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label lblName;
        public System.Windows.Forms.NumericUpDown numAmount;
        public System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnMinus;
    }
}
