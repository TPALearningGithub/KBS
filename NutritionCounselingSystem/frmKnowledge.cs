using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionCounselingSystem
{
    public partial class frmKnowledge : Form
    {
        public frmKnowledge(string tab)
        {
            InitializeComponent();
            btnATP.Click += ActiveButton;
            btnEFAs.Click += ActiveButton;
            btnInsulin.Click += ActiveButton;
            btnProtein.Click += ActiveButton;
            btnWater.Click += ActiveButton;
            btnCarb.Click += ActiveButton;
            btnBMI.Click += ActiveButton;

            if (tab == "BMI")
            {
                lblTitle.Text = @"BMI và mỡ cơ thể";
                btnBMI.BackColor = ActiveColor;
                pbxContent.Size = Properties.Resources.BMIBlog.Size;
                pbxContent.Image = Properties.Resources.BMIBlog;
            }

        }

        public frmKnowledge()
        {
            InitializeComponent();
            btnATP.Click += ActiveButton;
            btnEFAs.Click += ActiveButton;
            btnInsulin.Click += ActiveButton;
            btnProtein.Click += ActiveButton;
            btnWater.Click += ActiveButton;
            btnCarb.Click += ActiveButton;
            btnBMI.Click += ActiveButton;

            btnATP.BackColor = ActiveColor;
            pbxContent.Size = Properties.Resources.ATPBlog.Size;
            pbxContent.Image = Properties.Resources.ATPBlog;
        }

        Color ActiveColor = Color.Gainsboro, NormalColor = Color.White;
        private void ResetButtonsForeColor()
        {
            btnATP.BackColor = NormalColor;
            btnEFAs.BackColor = NormalColor;
            btnInsulin.BackColor = NormalColor;
            btnProtein.BackColor = NormalColor;
            btnWater.BackColor = NormalColor;
            btnCarb.BackColor = NormalColor;
            btnBMI.BackColor = NormalColor;
        }
        private void ActiveButton(object sender, EventArgs e)
        {
            ResetButtonsForeColor();
            (sender as Button).BackColor = ActiveColor;
        }

        private void frmKnowledge_Load(object sender, EventArgs e)
        {
            
        }

        int SmallWidth = 50;
        int FullWidth = 204;
        int SmallHeight = 50;
        int FullHeight = 67;

        private void btnATP_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.ATPBlog.Size;
            pbxContent.Image = Properties.Resources.ATPBlog;
            lblTitle.Text = @"ATP - Đồng tiền năng lượng cơ thể";
        }

        private void btnEFAs_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.EFAsBlog.Size;
            pbxContent.Image = Properties.Resources.EFAsBlog;
            lblTitle.Text = @"Tầm quan trọng của chất béo";
        }

        private void btnInsulin_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.InsulinBlog.Size;
            pbxContent.Image = Properties.Resources.InsulinBlog;
            lblTitle.Text = @"Insulin là gì? Vai trò trong phát triển cơ bắp";
        }

        private void btnProtein_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.ProteinBlog.Size;
            pbxContent.Image = Properties.Resources.ProteinBlog;
            lblTitle.Text = @"Vai trò của protein";
        }

        private void btnWater_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.WaterBlog.Size;
            pbxContent.Image = Properties.Resources.WaterBlog;
            lblTitle.Text = @"Nước cần uống bao nhiêu?";
        }

        private void btnCarb_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.Carbonhydrate.Size;
            pbxContent.Image = Properties.Resources.Carbonhydrate;
            lblTitle.Text = @"Tinh bột và những điều cần biết";
        }


        private void btnBMI_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.BMIBlog.Size;
            pbxContent.Image = Properties.Resources.BMIBlog;
            lblTitle.Text = @"BMI và mỡ cơ thể";
        }

        private void btnMenu_Click(object sender, EventArgs e)
        {
            if (pnlMenu.Width == SmallWidth)
            {
                pnlMenu.Width = FullWidth;
                LogoImage.Visible = true;
                pnlTop.Height = FullHeight;
                pnlTitle.Height = FullHeight;
                return;
            }
            pnlMenu.Width = SmallWidth;
            LogoImage.Visible = false;
            pnlTop.Height = SmallHeight;
            pnlTitle.Height = SmallHeight;
        }
    }
}
