namespace InternetCafeClient
{
    partial class OrderUpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrderUpdateForm));
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.snackPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.drinkPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.mainFoodPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.tabPage3.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.AutoScroll = true;
            this.tabPage3.Controls.Add(this.snackPanel);
            this.tabPage3.Location = new System.Drawing.Point(4, 24);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(690, 386);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ăn nhẹ";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // snackPanel
            // 
            this.snackPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.snackPanel.Location = new System.Drawing.Point(3, 3);
            this.snackPanel.Name = "snackPanel";
            this.snackPanel.Size = new System.Drawing.Size(684, 380);
            this.snackPanel.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.drinkPanel);
            this.tabPage2.Location = new System.Drawing.Point(4, 24);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(690, 386);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Đồ uống";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // drinkPanel
            // 
            this.drinkPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.drinkPanel.Location = new System.Drawing.Point(3, 3);
            this.drinkPanel.Name = "drinkPanel";
            this.drinkPanel.Size = new System.Drawing.Size(684, 380);
            this.drinkPanel.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.BackColor = System.Drawing.Color.Transparent;
            this.tabPage1.Controls.Add(this.mainFoodPanel);
            this.tabPage1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 24);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(690, 386);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Món chính";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabControl1.Location = new System.Drawing.Point(-3, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(698, 414);
            this.tabControl1.TabIndex = 0;
            // 
            // mainFoodPanel
            // 
            this.mainFoodPanel.AutoScroll = true;
            this.mainFoodPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainFoodPanel.Location = new System.Drawing.Point(3, 3);
            this.mainFoodPanel.Name = "mainFoodPanel";
            this.mainFoodPanel.Size = new System.Drawing.Size(684, 380);
            this.mainFoodPanel.TabIndex = 2;
            this.mainFoodPanel.TabStop = true;
            // 
            // OrderUpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(692, 450);
            this.Controls.Add(this.tabControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "OrderUpdateForm";
            this.Text = "OrderUpdateForm";
            this.tabPage3.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabControl1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.FlowLayoutPanel snackPanel;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.FlowLayoutPanel drinkPanel;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.FlowLayoutPanel mainFoodPanel;
    }
}