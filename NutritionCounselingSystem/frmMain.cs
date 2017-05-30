using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NutritionCounselingSystem
{
    public partial class frmMain : Form
    {
        private List<Rule> rules = Solver.GetRulesFrom(Directory.GetCurrentDirectory() + "\\data\\"+ Constants.RulesFileName);
        public frmMain()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnNutrientSearch_Click(object sender, EventArgs e)
        {
            var frmKnow = new frmKnowledge();
            Hide();
            frmKnow.ShowDialog();
            Show();
        }

        private void btnFoodSearch_Click(object sender, EventArgs e)
        {
            var frmNutri = new frmNutrient();
            Hide();
            frmNutri.ShowDialog();
            Show();
        }

        private void btnCounsel_Click(object sender, EventArgs e)
        {
            var frmHeath = new frmHeathy();
            Hide();
            frmHeath.ShowDialog();
            Show();
        }
    }
}
