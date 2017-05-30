namespace NutritionCounselingSystem
{
    partial class frmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel8 = new System.Windows.Forms.Panel();
            this.panel7 = new System.Windows.Forms.Panel();
            this.lblAppName = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnNutrientSearch = new CustomControls.WindowSettingButton();
            this.btnFoodSearch = new CustomControls.WindowSettingButton();
            this.btnCounsel = new CustomControls.WindowSettingButton();
            this.pbxLogo = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).BeginInit();
            this.SuspendLayout();
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel6.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel6.Location = new System.Drawing.Point(0, 32);
            this.panel6.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(1, 295);
            this.panel6.TabIndex = 10;
            // 
            // panel8
            // 
            this.panel8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel8.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel8.Location = new System.Drawing.Point(642, 32);
            this.panel8.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel8.Name = "panel8";
            this.panel8.Size = new System.Drawing.Size(1, 295);
            this.panel8.TabIndex = 12;
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel7.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel7.Location = new System.Drawing.Point(0, 327);
            this.panel7.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(643, 1);
            this.panel7.TabIndex = 11;
            // 
            // lblAppName
            // 
            this.lblAppName.AutoSize = true;
            this.lblAppName.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.lblAppName.ForeColor = System.Drawing.Color.White;
            this.lblAppName.Location = new System.Drawing.Point(41, 7);
            this.lblAppName.Name = "lblAppName";
            this.lblAppName.Size = new System.Drawing.Size(40, 19);
            this.lblAppName.TabIndex = 4;
            this.lblAppName.Text = "iCare";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.panel1.Controls.Add(this.lblAppName);
            this.panel1.Controls.Add(this.pbxLogo);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(643, 32);
            this.panel1.TabIndex = 7;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(122)))), ((int)(((byte)(204)))));
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(1, 32);
            this.panel5.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(641, 1);
            this.panel5.TabIndex = 9;
            // 
            // btnNutrientSearch
            // 
            this.btnNutrientSearch.BackColor = System.Drawing.Color.White;
            this.btnNutrientSearch.Content = "Kiến thức cơ bản";
            this.btnNutrientSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnNutrientSearch.Description = "Các chất dinh dưỡng cơ bản";
            this.btnNutrientSearch.Image = global::NutritionCounselingSystem.Properties.Resources.Open_Book_64px;
            this.btnNutrientSearch.Location = new System.Drawing.Point(430, 77);
            this.btnNutrientSearch.Name = "btnNutrientSearch";
            this.btnNutrientSearch.Size = new System.Drawing.Size(200, 200);
            this.btnNutrientSearch.TabIndex = 15;
            this.btnNutrientSearch.Click += new System.EventHandler(this.btnNutrientSearch_Click);
            // 
            // btnFoodSearch
            // 
            this.btnFoodSearch.BackColor = System.Drawing.Color.White;
            this.btnFoodSearch.Content = "Dinh dưỡng thực phẩm";
            this.btnFoodSearch.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnFoodSearch.Description = "Thực phẩm thường ngày";
            this.btnFoodSearch.Image = global::NutritionCounselingSystem.Properties.Resources.Watermelon_64px;
            this.btnFoodSearch.Location = new System.Drawing.Point(221, 77);
            this.btnFoodSearch.Name = "btnFoodSearch";
            this.btnFoodSearch.Size = new System.Drawing.Size(200, 200);
            this.btnFoodSearch.TabIndex = 14;
            this.btnFoodSearch.Click += new System.EventHandler(this.btnFoodSearch_Click);
            // 
            // btnCounsel
            // 
            this.btnCounsel.BackColor = System.Drawing.Color.White;
            this.btnCounsel.Content = "Tư vấn sức khỏe";
            this.btnCounsel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCounsel.Description = "Tình trạng cơ thể, thực đơn";
            this.btnCounsel.Image = global::NutritionCounselingSystem.Properties.Resources.Heart_with_Pulse_64px;
            this.btnCounsel.Location = new System.Drawing.Point(12, 77);
            this.btnCounsel.Name = "btnCounsel";
            this.btnCounsel.Size = new System.Drawing.Size(200, 200);
            this.btnCounsel.TabIndex = 13;
            this.btnCounsel.Click += new System.EventHandler(this.btnCounsel_Click);
            // 
            // pbxLogo
            // 
            this.pbxLogo.Image = global::NutritionCounselingSystem.Properties.Resources.Heart_Health_64px;
            this.pbxLogo.Location = new System.Drawing.Point(10, 3);
            this.pbxLogo.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pbxLogo.Name = "pbxLogo";
            this.pbxLogo.Size = new System.Drawing.Size(25, 25);
            this.pbxLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pbxLogo.TabIndex = 3;
            this.pbxLogo.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnClose.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnClose.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(87)))), ((int)(((byte)(127)))), ((int)(((byte)(188)))));
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(603, 0);
            this.btnClose.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(40, 32);
            this.btnClose.TabIndex = 2;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(643, 328);
            this.Controls.Add(this.btnNutrientSearch);
            this.Controls.Add(this.btnFoodSearch);
            this.Controls.Add(this.btnCounsel);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.panel8);
            this.Controls.Add(this.panel7);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbxLogo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel8;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.PictureBox pbxLogo;
        private System.Windows.Forms.Label lblAppName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel5;
        private CustomControls.WindowSettingButton btnCounsel;
        private CustomControls.WindowSettingButton btnFoodSearch;
        private CustomControls.WindowSettingButton btnNutrientSearch;
    }
}

