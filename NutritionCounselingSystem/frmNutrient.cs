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
    public partial class frmNutrient : Form
    {
        public frmNutrient()
        {
            InitializeComponent();
            btnEgg.Click += ActiveButton;
            btnPig.Click += ActiveButton;
            btnShirmp.Click += ActiveButton;
            btnWhiteRice.Click += ActiveButton;
            btnBanana.Click += ActiveButton;
        }
        Color ActiveColor = Color.Gainsboro, NormalColor = Color.White;
        private void ResetButtonsForeColor()
        {
            btnEgg.BackColor = NormalColor;
            btnPig.BackColor = NormalColor;
            btnShirmp.BackColor = NormalColor;
            btnWhiteRice.BackColor = NormalColor;
            btnBanana.BackColor = NormalColor;
        }
        private void ActiveButton(object sender, EventArgs e)
        {
            ResetButtonsForeColor();
            (sender as Button).BackColor = ActiveColor;
        }

        private void frmNutrient_Load(object sender, EventArgs e)
        {
            btnEgg.BackColor = ActiveColor;
            pbxContent.Size = Properties.Resources.EggNutrient.Size;
            pbxContent.Image = Properties.Resources.EggNutrient;
        }

        int SmallWidth = 50;
        int FullWidth = 185;
        int SmallHeight = 50;
        int FullHeight = 67;
        
        private void btnEgg_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.EggNutrient.Size;
            pbxContent.Image = Properties.Resources.EggNutrient;
            lblTitle.Text = @"Trứng gà";
        }

        private void btnPig_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.PigNutrient.Size;
            pbxContent.Image = Properties.Resources.PigNutrient;
            lblTitle.Text = @"Thịt heo nạt";
        }

        private void btnShirmp_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.ShrimpNutrient.Size;
            pbxContent.Image = Properties.Resources.ShrimpNutrient;
            lblTitle.Text = @"Tôm tép";
        }

        private void btnWhiteRice_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.WhiteRiceNutrient.Size;
            pbxContent.Image = Properties.Resources.WhiteRiceNutrient;
            lblTitle.Text = @"Cơm trắng";
        }

        private void btnBanana_Click(object sender, EventArgs e)
        {
            pbxContent.Size = Properties.Resources.BananaNutrient.Size;
            pbxContent.Image = Properties.Resources.BananaNutrient;
            lblTitle.Text = @"Chuối";
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
