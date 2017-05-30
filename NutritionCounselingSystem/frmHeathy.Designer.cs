namespace NutritionCounselingSystem
{
    partial class frmHeathy
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmHeathy));
            this.titleBar1 = new CustomControls.TitleBar();
            this.btnDone = new System.Windows.Forms.Button();
            this.tbxHeight = new CustomControls.HintTextbox();
            this.tbxWeight = new CustomControls.HintTextbox();
            this.tbxAge = new CustomControls.HintTextbox();
            this.tbxWaist = new CustomControls.HintTextbox();
            this.tbxNeck = new CustomControls.HintTextbox();
            this.tbxHip = new CustomControls.HintTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnHighActive = new System.Windows.Forms.Button();
            this.btnNormalActive = new System.Windows.Forms.Button();
            this.btnLowActive = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnFemale = new System.Windows.Forms.Button();
            this.btnMale = new System.Windows.Forms.Button();
            this.lblForgot = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.pnlIn = new System.Windows.Forms.Panel();
            this.pnlOut = new System.Windows.Forms.Panel();
            this.lblWater = new System.Windows.Forms.Label();
            this.tbxTotalEnergy = new System.Windows.Forms.TextBox();
            this.tbxCaloNeed = new System.Windows.Forms.TextBox();
            this.tbxBodyFat = new System.Windows.Forms.TextBox();
            this.tbxBMI = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.panel7 = new System.Windows.Forms.Panel();
            this.panel6 = new System.Windows.Forms.Panel();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.label22 = new System.Windows.Forms.Label();
            this.panel5 = new System.Windows.Forms.Panel();
            this.lblFat = new System.Windows.Forms.Label();
            this.lblGramFat = new System.Windows.Forms.Label();
            this.lblProtein = new System.Windows.Forms.Label();
            this.lblGramProtein = new System.Windows.Forms.Label();
            this.lblCarb = new System.Windows.Forms.Label();
            this.lblGramCarb = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.label14 = new System.Windows.Forms.Label();
            this.lblAdvice = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.pnlIn.SuspendLayout();
            this.pnlOut.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // titleBar1
            // 
            this.titleBar1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.titleBar1.Dock = System.Windows.Forms.DockStyle.Top;
            this.titleBar1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleBar1.Icon = null;
            this.titleBar1.Location = new System.Drawing.Point(0, 0);
            this.titleBar1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.titleBar1.Name = "titleBar1";
            this.titleBar1.Size = new System.Drawing.Size(801, 32);
            this.titleBar1.TabIndex = 15;
            this.titleBar1.UseButtonBack = true;
            this.titleBar1.WindowName = "Tư vấn sức khỏe";
            // 
            // btnDone
            // 
            this.btnDone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(169)))));
            this.btnDone.FlatAppearance.BorderSize = 0;
            this.btnDone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnDone.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDone.ForeColor = System.Drawing.Color.White;
            this.btnDone.Location = new System.Drawing.Point(19, 506);
            this.btnDone.Name = "btnDone";
            this.btnDone.Size = new System.Drawing.Size(362, 40);
            this.btnDone.TabIndex = 17;
            this.btnDone.Text = "Xong";
            this.btnDone.UseVisualStyleBackColor = false;
            this.btnDone.Click += new System.EventHandler(this.btnDone_Click);
            // 
            // tbxHeight
            // 
            this.tbxHeight.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxHeight.Hint = "Chiều cao (cm). Ví dụ: 165";
            this.tbxHeight.Location = new System.Drawing.Point(106, 17);
            this.tbxHeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxHeight.Name = "tbxHeight";
            this.tbxHeight.Size = new System.Drawing.Size(275, 40);
            this.tbxHeight.TabIndex = 18;
            // 
            // tbxWeight
            // 
            this.tbxWeight.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxWeight.Hint = "Cân nặng (kg). Ví dụ: 62";
            this.tbxWeight.Location = new System.Drawing.Point(106, 65);
            this.tbxWeight.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxWeight.Name = "tbxWeight";
            this.tbxWeight.Size = new System.Drawing.Size(275, 40);
            this.tbxWeight.TabIndex = 19;
            // 
            // tbxAge
            // 
            this.tbxAge.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxAge.Hint = "Tuổi. Ví dụ: 25";
            this.tbxAge.Location = new System.Drawing.Point(106, 113);
            this.tbxAge.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxAge.Name = "tbxAge";
            this.tbxAge.Size = new System.Drawing.Size(275, 40);
            this.tbxAge.TabIndex = 20;
            // 
            // tbxWaist
            // 
            this.tbxWaist.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxWaist.Hint = "Số đo vòng eo (cm). Ví dụ: 75";
            this.tbxWaist.Location = new System.Drawing.Point(106, 161);
            this.tbxWaist.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxWaist.Name = "tbxWaist";
            this.tbxWaist.Size = new System.Drawing.Size(275, 40);
            this.tbxWaist.TabIndex = 21;
            // 
            // tbxNeck
            // 
            this.tbxNeck.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxNeck.Hint = "Số đo vòng cổ (cm). Ví dụ 23";
            this.tbxNeck.Location = new System.Drawing.Point(106, 209);
            this.tbxNeck.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxNeck.Name = "tbxNeck";
            this.tbxNeck.Size = new System.Drawing.Size(275, 40);
            this.tbxNeck.TabIndex = 22;
            // 
            // tbxHip
            // 
            this.tbxHip.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.tbxHip.Hint = "(*) Số đo hông (cm). Ví dụ 85";
            this.tbxHip.Location = new System.Drawing.Point(106, 257);
            this.tbxHip.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.tbxHip.Name = "tbxHip";
            this.tbxHip.Size = new System.Drawing.Size(275, 40);
            this.tbxHip.TabIndex = 23;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(16, 331);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 24;
            this.label1.Text = "Bạn là người:";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnHighActive);
            this.panel1.Controls.Add(this.btnNormalActive);
            this.panel1.Controls.Add(this.btnLowActive);
            this.panel1.Location = new System.Drawing.Point(19, 353);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(362, 52);
            this.panel1.TabIndex = 25;
            // 
            // btnHighActive
            // 
            this.btnHighActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(169)))));
            this.btnHighActive.FlatAppearance.BorderSize = 0;
            this.btnHighActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHighActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnHighActive.ForeColor = System.Drawing.Color.White;
            this.btnHighActive.Location = new System.Drawing.Point(252, 3);
            this.btnHighActive.Name = "btnHighActive";
            this.btnHighActive.Size = new System.Drawing.Size(107, 46);
            this.btnHighActive.TabIndex = 2;
            this.btnHighActive.Text = "rất năng động";
            this.btnHighActive.UseVisualStyleBackColor = false;
            this.btnHighActive.Click += new System.EventHandler(this.btnHighActive_Click);
            // 
            // btnNormalActive
            // 
            this.btnNormalActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(169)))));
            this.btnNormalActive.FlatAppearance.BorderSize = 0;
            this.btnNormalActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNormalActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnNormalActive.ForeColor = System.Drawing.Color.White;
            this.btnNormalActive.Location = new System.Drawing.Point(102, 3);
            this.btnNormalActive.Name = "btnNormalActive";
            this.btnNormalActive.Size = new System.Drawing.Size(144, 46);
            this.btnNormalActive.TabIndex = 1;
            this.btnNormalActive.Text = "hoạt động vừa phải";
            this.btnNormalActive.UseVisualStyleBackColor = false;
            this.btnNormalActive.Click += new System.EventHandler(this.btnNormalActive_Click);
            // 
            // btnLowActive
            // 
            this.btnLowActive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(169)))));
            this.btnLowActive.FlatAppearance.BorderSize = 0;
            this.btnLowActive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLowActive.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLowActive.ForeColor = System.Drawing.Color.White;
            this.btnLowActive.Location = new System.Drawing.Point(3, 3);
            this.btnLowActive.Name = "btnLowActive";
            this.btnLowActive.Size = new System.Drawing.Size(93, 46);
            this.btnLowActive.TabIndex = 0;
            this.btnLowActive.Text = "ít hoạt động";
            this.btnLowActive.UseVisualStyleBackColor = false;
            this.btnLowActive.Click += new System.EventHandler(this.btnLowActive_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(18, 416);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(123, 17);
            this.label2.TabIndex = 26;
            this.label2.Text = "Giới tính của bạn là:";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnFemale);
            this.panel2.Controls.Add(this.btnMale);
            this.panel2.Location = new System.Drawing.Point(22, 439);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(356, 54);
            this.panel2.TabIndex = 29;
            // 
            // btnFemale
            // 
            this.btnFemale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(169)))));
            this.btnFemale.FlatAppearance.BorderSize = 0;
            this.btnFemale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFemale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFemale.ForeColor = System.Drawing.Color.White;
            this.btnFemale.Location = new System.Drawing.Point(99, 3);
            this.btnFemale.Name = "btnFemale";
            this.btnFemale.Size = new System.Drawing.Size(90, 46);
            this.btnFemale.TabIndex = 30;
            this.btnFemale.Text = "Nữ";
            this.btnFemale.UseVisualStyleBackColor = false;
            this.btnFemale.Click += new System.EventHandler(this.btnFemale_Click);
            // 
            // btnMale
            // 
            this.btnMale.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(78)))), ((int)(((byte)(114)))), ((int)(((byte)(169)))));
            this.btnMale.FlatAppearance.BorderSize = 0;
            this.btnMale.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMale.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMale.ForeColor = System.Drawing.Color.White;
            this.btnMale.Location = new System.Drawing.Point(3, 3);
            this.btnMale.Name = "btnMale";
            this.btnMale.Size = new System.Drawing.Size(90, 46);
            this.btnMale.TabIndex = 29;
            this.btnMale.Text = "Nam";
            this.btnMale.UseVisualStyleBackColor = false;
            this.btnMale.Click += new System.EventHandler(this.btnMale_Click);
            // 
            // lblForgot
            // 
            this.lblForgot.AutoSize = true;
            this.lblForgot.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lblForgot.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblForgot.ForeColor = System.Drawing.Color.White;
            this.lblForgot.Location = new System.Drawing.Point(220, 303);
            this.lblForgot.Name = "lblForgot";
            this.lblForgot.Size = new System.Drawing.Size(158, 15);
            this.lblForgot.TabIndex = 30;
            this.lblForgot.Text = "(*) Thông tin chỉ cần cho Nữ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(16, 30);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 17);
            this.label3.TabIndex = 31;
            this.label3.Text = "Chiều cao:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(16, 78);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(66, 17);
            this.label4.TabIndex = 32;
            this.label4.Text = "Cân nặng:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(16, 175);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 34;
            this.label5.Text = "Vòng eo:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(16, 127);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 17);
            this.label6.TabIndex = 33;
            this.label6.Text = "Tuổi:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(16, 268);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 17);
            this.label7.TabIndex = 36;
            this.label7.Text = "Vòng hông:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(16, 220);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(59, 17);
            this.label8.TabIndex = 35;
            this.label8.Text = "Vòng cổ:";
            // 
            // pnlIn
            // 
            this.pnlIn.Controls.Add(this.tbxHeight);
            this.pnlIn.Controls.Add(this.label7);
            this.pnlIn.Controls.Add(this.btnDone);
            this.pnlIn.Controls.Add(this.label8);
            this.pnlIn.Controls.Add(this.tbxWeight);
            this.pnlIn.Controls.Add(this.label5);
            this.pnlIn.Controls.Add(this.tbxAge);
            this.pnlIn.Controls.Add(this.label6);
            this.pnlIn.Controls.Add(this.tbxWaist);
            this.pnlIn.Controls.Add(this.label4);
            this.pnlIn.Controls.Add(this.tbxNeck);
            this.pnlIn.Controls.Add(this.label3);
            this.pnlIn.Controls.Add(this.tbxHip);
            this.pnlIn.Controls.Add(this.lblForgot);
            this.pnlIn.Controls.Add(this.label1);
            this.pnlIn.Controls.Add(this.panel2);
            this.pnlIn.Controls.Add(this.panel1);
            this.pnlIn.Controls.Add(this.label2);
            this.pnlIn.Location = new System.Drawing.Point(0, 32);
            this.pnlIn.Name = "pnlIn";
            this.pnlIn.Size = new System.Drawing.Size(395, 550);
            this.pnlIn.TabIndex = 37;
            // 
            // pnlOut
            // 
            this.pnlOut.Controls.Add(this.lblWater);
            this.pnlOut.Controls.Add(this.tbxTotalEnergy);
            this.pnlOut.Controls.Add(this.tbxCaloNeed);
            this.pnlOut.Controls.Add(this.tbxBodyFat);
            this.pnlOut.Controls.Add(this.tbxBMI);
            this.pnlOut.Controls.Add(this.label10);
            this.pnlOut.Controls.Add(this.panel7);
            this.pnlOut.Controls.Add(this.panel6);
            this.pnlOut.Controls.Add(this.linkLabel2);
            this.pnlOut.Controls.Add(this.label22);
            this.pnlOut.Controls.Add(this.panel5);
            this.pnlOut.Controls.Add(this.label15);
            this.pnlOut.Controls.Add(this.linkLabel1);
            this.pnlOut.Controls.Add(this.label14);
            this.pnlOut.Controls.Add(this.lblAdvice);
            this.pnlOut.Controls.Add(this.label12);
            this.pnlOut.Controls.Add(this.label11);
            this.pnlOut.Controls.Add(this.label9);
            this.pnlOut.Location = new System.Drawing.Point(401, 32);
            this.pnlOut.Name = "pnlOut";
            this.pnlOut.Size = new System.Drawing.Size(395, 550);
            this.pnlOut.TabIndex = 38;
            // 
            // lblWater
            // 
            this.lblWater.AutoSize = true;
            this.lblWater.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblWater.ForeColor = System.Drawing.Color.White;
            this.lblWater.Location = new System.Drawing.Point(15, 474);
            this.lblWater.Name = "lblWater";
            this.lblWater.Size = new System.Drawing.Size(153, 20);
            this.lblWater.TabIndex = 53;
            this.lblWater.Text = "Đừng quên uống đủ ";
            // 
            // tbxTotalEnergy
            // 
            this.tbxTotalEnergy.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxTotalEnergy.Location = new System.Drawing.Point(235, 445);
            this.tbxTotalEnergy.Name = "tbxTotalEnergy";
            this.tbxTotalEnergy.Size = new System.Drawing.Size(139, 25);
            this.tbxTotalEnergy.TabIndex = 52;
            this.tbxTotalEnergy.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxCaloNeed
            // 
            this.tbxCaloNeed.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxCaloNeed.Location = new System.Drawing.Point(306, 226);
            this.tbxCaloNeed.Name = "tbxCaloNeed";
            this.tbxCaloNeed.Size = new System.Drawing.Size(76, 25);
            this.tbxCaloNeed.TabIndex = 51;
            this.tbxCaloNeed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxBodyFat
            // 
            this.tbxBodyFat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBodyFat.Location = new System.Drawing.Point(234, 99);
            this.tbxBodyFat.Name = "tbxBodyFat";
            this.tbxBodyFat.Size = new System.Drawing.Size(76, 25);
            this.tbxBodyFat.TabIndex = 50;
            this.tbxBodyFat.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // tbxBMI
            // 
            this.tbxBMI.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tbxBMI.Location = new System.Drawing.Point(180, 60);
            this.tbxBMI.Name = "tbxBMI";
            this.tbxBMI.Size = new System.Drawing.Size(76, 25);
            this.tbxBMI.TabIndex = 49;
            this.tbxBMI.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(158, 450);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 17);
            this.label10.TabIndex = 47;
            this.label10.Text = "Tổng cộng";
            // 
            // panel7
            // 
            this.panel7.BackColor = System.Drawing.Color.White;
            this.panel7.Location = new System.Drawing.Point(0, 46);
            this.panel7.Name = "panel7";
            this.panel7.Size = new System.Drawing.Size(395, 1);
            this.panel7.TabIndex = 46;
            // 
            // panel6
            // 
            this.panel6.BackColor = System.Drawing.Color.White;
            this.panel6.Location = new System.Drawing.Point(0, 215);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(395, 1);
            this.panel6.TabIndex = 45;
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.linkLabel2.ForeColor = System.Drawing.Color.Gainsboro;
            this.linkLabel2.LinkArea = new System.Windows.Forms.LinkArea(62, 7);
            this.linkLabel2.LinkColor = System.Drawing.Color.GhostWhite;
            this.linkLabel2.Location = new System.Drawing.Point(16, 501);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(366, 40);
            this.linkLabel2.TabIndex = 44;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Tìm hiểu thêm về thành phần dinh dưỡng các món ăn hằng \r\nngày tại đây nè bạn\r\n";
            this.linkLabel2.UseCompatibleTextRendering = true;
            this.linkLabel2.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel2_LinkClicked);
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(15, 249);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(77, 20);
            this.label22.TabIndex = 43;
            this.label22.Text = "mỗi ngày.";
            // 
            // panel5
            // 
            this.panel5.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("panel5.BackgroundImage")));
            this.panel5.Controls.Add(this.lblFat);
            this.panel5.Controls.Add(this.lblGramFat);
            this.panel5.Controls.Add(this.lblProtein);
            this.panel5.Controls.Add(this.lblGramProtein);
            this.panel5.Controls.Add(this.lblCarb);
            this.panel5.Controls.Add(this.lblGramCarb);
            this.panel5.Location = new System.Drawing.Point(19, 303);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(355, 137);
            this.panel5.TabIndex = 41;
            // 
            // lblFat
            // 
            this.lblFat.AutoSize = true;
            this.lblFat.BackColor = System.Drawing.Color.Transparent;
            this.lblFat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFat.ForeColor = System.Drawing.Color.Black;
            this.lblFat.Location = new System.Drawing.Point(257, 94);
            this.lblFat.Name = "lblFat";
            this.lblFat.Size = new System.Drawing.Size(36, 17);
            this.lblFat.TabIndex = 35;
            this.lblFat.Text = "1000";
            // 
            // lblGramFat
            // 
            this.lblGramFat.AutoSize = true;
            this.lblGramFat.BackColor = System.Drawing.Color.Transparent;
            this.lblGramFat.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGramFat.ForeColor = System.Drawing.Color.Black;
            this.lblGramFat.Location = new System.Drawing.Point(137, 94);
            this.lblGramFat.Name = "lblGramFat";
            this.lblGramFat.Size = new System.Drawing.Size(36, 17);
            this.lblGramFat.TabIndex = 35;
            this.lblGramFat.Text = "1000";
            // 
            // lblProtein
            // 
            this.lblProtein.AutoSize = true;
            this.lblProtein.BackColor = System.Drawing.Color.Transparent;
            this.lblProtein.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProtein.ForeColor = System.Drawing.Color.Black;
            this.lblProtein.Location = new System.Drawing.Point(257, 60);
            this.lblProtein.Name = "lblProtein";
            this.lblProtein.Size = new System.Drawing.Size(36, 17);
            this.lblProtein.TabIndex = 34;
            this.lblProtein.Text = "1000";
            // 
            // lblGramProtein
            // 
            this.lblGramProtein.AutoSize = true;
            this.lblGramProtein.BackColor = System.Drawing.Color.Transparent;
            this.lblGramProtein.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGramProtein.ForeColor = System.Drawing.Color.Black;
            this.lblGramProtein.Location = new System.Drawing.Point(137, 60);
            this.lblGramProtein.Name = "lblGramProtein";
            this.lblGramProtein.Size = new System.Drawing.Size(36, 17);
            this.lblGramProtein.TabIndex = 34;
            this.lblGramProtein.Text = "1000";
            // 
            // lblCarb
            // 
            this.lblCarb.AutoSize = true;
            this.lblCarb.BackColor = System.Drawing.Color.Transparent;
            this.lblCarb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCarb.ForeColor = System.Drawing.Color.Black;
            this.lblCarb.Location = new System.Drawing.Point(257, 25);
            this.lblCarb.Name = "lblCarb";
            this.lblCarb.Size = new System.Drawing.Size(36, 17);
            this.lblCarb.TabIndex = 33;
            this.lblCarb.Text = "1000";
            // 
            // lblGramCarb
            // 
            this.lblGramCarb.AutoSize = true;
            this.lblGramCarb.BackColor = System.Drawing.Color.Transparent;
            this.lblGramCarb.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGramCarb.ForeColor = System.Drawing.Color.Black;
            this.lblGramCarb.Location = new System.Drawing.Point(137, 25);
            this.lblGramCarb.Name = "lblGramCarb";
            this.lblGramCarb.Size = new System.Drawing.Size(36, 17);
            this.lblGramCarb.TabIndex = 33;
            this.lblGramCarb.Text = "1000";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(15, 275);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(283, 17);
            this.label15.TabIndex = 38;
            this.label15.Text = "Tham khảo gợi ý sau để cải thiện vóc dáng nhé";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Font = new System.Drawing.Font("Segoe UI", 9.75F);
            this.linkLabel1.ForeColor = System.Drawing.Color.Gainsboro;
            this.linkLabel1.LinkArea = new System.Windows.Forms.LinkArea(39, 5);
            this.linkLabel1.LinkColor = System.Drawing.Color.White;
            this.linkLabel1.Location = new System.Drawing.Point(15, 187);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(315, 22);
            this.linkLabel1.TabIndex = 37;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Bạn tham khảo thêm về BMI và mỡ cơ thể ở đây nhé";
            this.linkLabel1.UseCompatibleTextRendering = true;
            this.linkLabel1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel1_LinkClicked);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(15, 229);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(293, 20);
            this.label14.TabIndex = 36;
            this.label14.Text = "Để duy trì cân nặng hiện tại bạn cần nạp ";
            // 
            // lblAdvice
            // 
            this.lblAdvice.AutoSize = true;
            this.lblAdvice.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAdvice.ForeColor = System.Drawing.Color.White;
            this.lblAdvice.Location = new System.Drawing.Point(15, 134);
            this.lblAdvice.Name = "lblAdvice";
            this.lblAdvice.Size = new System.Drawing.Size(359, 34);
            this.lblAdvice.TabIndex = 35;
            this.lblAdvice.Text = "Bạn có vẻ hơi gầy một tí, cố gắng ăn uống  và tập luyện \r\nthể thao nhiều hơn nhé!" +
    "";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(15, 101);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(214, 20);
            this.label12.TabIndex = 34;
            this.label12.Text = "Phần trăm mỡ cơ thể của bạn";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(15, 62);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(158, 20);
            this.label11.TabIndex = 33;
            this.label11.Text = "Chỉ số BMI của bạn là";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(13, 17);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(107, 30);
            this.label9.TabIndex = 0;
            this.label9.Text = "Chào bạn,";
            // 
            // timer1
            // 
            this.timer1.Interval = 1;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // frmHeathy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(59)))), ((int)(((byte)(89)))), ((int)(((byte)(152)))));
            this.ClientSize = new System.Drawing.Size(801, 594);
            this.Controls.Add(this.pnlOut);
            this.Controls.Add(this.pnlIn);
            this.Controls.Add(this.titleBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmHeathy";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmHeathy";
            this.Load += new System.EventHandler(this.frmHeathy_Load);
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.pnlIn.ResumeLayout(false);
            this.pnlIn.PerformLayout();
            this.pnlOut.ResumeLayout(false);
            this.pnlOut.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.panel5.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private CustomControls.TitleBar titleBar1;
        private System.Windows.Forms.Button btnDone;
        private CustomControls.HintTextbox tbxHeight;
        private CustomControls.HintTextbox tbxWeight;
        private CustomControls.HintTextbox tbxAge;
        private CustomControls.HintTextbox tbxWaist;
        private CustomControls.HintTextbox tbxNeck;
        private CustomControls.HintTextbox tbxHip;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnHighActive;
        private System.Windows.Forms.Button btnNormalActive;
        private System.Windows.Forms.Button btnLowActive;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnFemale;
        private System.Windows.Forms.Button btnMale;
        private System.Windows.Forms.Label lblForgot;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Panel pnlIn;
        private System.Windows.Forms.Panel pnlOut;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label lblAdvice;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label lblFat;
        private System.Windows.Forms.Label lblGramFat;
        private System.Windows.Forms.Label lblProtein;
        private System.Windows.Forms.Label lblGramProtein;
        private System.Windows.Forms.Label lblCarb;
        private System.Windows.Forms.Label lblGramCarb;
        private System.Windows.Forms.Panel panel7;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.TextBox tbxTotalEnergy;
        private System.Windows.Forms.TextBox tbxCaloNeed;
        private System.Windows.Forms.TextBox tbxBodyFat;
        private System.Windows.Forms.TextBox tbxBMI;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblWater;
    }
}