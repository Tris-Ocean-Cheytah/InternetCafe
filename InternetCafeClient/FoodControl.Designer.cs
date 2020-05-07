namespace InternetCafeClient
{
    partial class FoodControl
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
            this.nameLbl = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.amoutUpDown = new System.Windows.Forms.NumericUpDown();
            this.PricetxtBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.amoutUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // nameLbl
            // 
            this.nameLbl.AutoSize = true;
            this.nameLbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 13F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLbl.Location = new System.Drawing.Point(132, 9);
            this.nameLbl.Margin = new System.Windows.Forms.Padding(0);
            this.nameLbl.Name = "nameLbl";
            this.nameLbl.Size = new System.Drawing.Size(70, 26);
            this.nameLbl.TabIndex = 0;
            this.nameLbl.Text = "label1";
            this.nameLbl.Click += new System.EventHandler(this.NameLbl_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 52);
            this.label2.Margin = new System.Windows.Forms.Padding(0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Giá";
            // 
            // amoutUpDown
            // 
            this.amoutUpDown.Location = new System.Drawing.Point(288, 52);
            this.amoutUpDown.Margin = new System.Windows.Forms.Padding(0);
            this.amoutUpDown.Name = "amoutUpDown";
            this.amoutUpDown.Size = new System.Drawing.Size(56, 22);
            this.amoutUpDown.TabIndex = 2;
            this.amoutUpDown.ValueChanged += new System.EventHandler(this.amoutUpDown_ValueChanged);
            // 
            // PricetxtBox
            // 
            this.PricetxtBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.PricetxtBox.Location = new System.Drawing.Point(59, 50);
            this.PricetxtBox.Margin = new System.Windows.Forms.Padding(0);
            this.PricetxtBox.Name = "PricetxtBox";
            this.PricetxtBox.ReadOnly = true;
            this.PricetxtBox.Size = new System.Drawing.Size(116, 22);
            this.PricetxtBox.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(203, 52);
            this.label3.Margin = new System.Windows.Forms.Padding(0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(74, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Số lượng";
            // 
            // FoodControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.label3);
            this.Controls.Add(this.PricetxtBox);
            this.Controls.Add(this.amoutUpDown);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.nameLbl);
            this.Location = new System.Drawing.Point(1, 1);
            this.Margin = new System.Windows.Forms.Padding(7, 6, 7, 6);
            this.Name = "FoodControl";
            this.Size = new System.Drawing.Size(356, 84);
            ((System.ComponentModel.ISupportInitialize)(this.amoutUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label nameLbl;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.NumericUpDown amoutUpDown;
        private System.Windows.Forms.TextBox PricetxtBox;
        private System.Windows.Forms.Label label3;
    }
}
