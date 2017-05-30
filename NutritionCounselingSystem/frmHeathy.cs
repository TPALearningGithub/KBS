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
    public partial class frmHeathy : Form
    {
        List<Rule> Rules = Solver.GetRulesFrom(Properties.Resources.rules);
        Dictionary<string, string> Known = new Dictionary<string, string>();
        string Gender = string.Empty;
        string Habit = string.Empty;
        string BMI = string.Empty;
        string BodyFat = string.Empty;
        string CaloNeed = string.Empty;
        string TotalEnergy = string.Empty;
        string Advice = string.Empty;
        string Carb = string.Empty;
        string Fat = string.Empty;
        string Protein = string.Empty;
        string gCarb = string.Empty;
        string gFat = string.Empty;
        string gProtein = string.Empty;
        string Water = string.Empty;

        public frmHeathy()
        {
            InitializeComponent();
            Width = pnlIn.Width;
            btnLowActive.Click += Choice_Click;
            btnNormalActive.Click += Choice_Click;
            btnHighActive.Click += Choice_Click;
            btnMale.Click += Choice_Click;
            btnFemale.Click += Choice_Click;
        }

        Color NormalColor = Color.FromArgb(78, 114, 169), ActiveColor = Color.White;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (pnlOut.Location.X < 5)
            {
                timer1.Stop();
            }
            else
            {
                pnlOut.Location = new Point(pnlOut.Location.X - 10, pnlOut.Location.Y);
                pnlIn.Location = new Point(pnlIn.Location.X - 10, pnlIn.Location.Y);
            }
        }

        private void GetKnown()
        {
            Known.Add("Height", tbxHeight.Text);
            Known.Add("Weight", tbxWeight.Text);
            Known.Add("Age", tbxAge.Text);
            Known.Add("Gender", Gender);
            Known.Add("Habit", Habit);
            Known.Add("Waist", tbxWaist.Text);
            Known.Add("Neck", tbxNeck.Text);
            if (!string.IsNullOrEmpty(tbxHip.Text))
            {
                Known.Add("Hip", tbxHip.Text);
            }
        }

        private void Calculate()
        {
            BMI = Solver.Solve(Rules, ref Known, nameof(BMI));
            BodyFat = Solver.Solve(Rules, ref Known, nameof(BodyFat));
            CaloNeed = Solver.Solve(Rules, ref Known, nameof(CaloNeed));
            TotalEnergy = Solver.Solve(Rules, ref Known, nameof(TotalEnergy));
            Protein = Solver.Solve(Rules, ref Known, nameof(Protein));
            Carb = Solver.Solve(Rules, ref Known, nameof(Carb));
            Fat = Solver.Solve(Rules, ref Known, nameof(Fat));
            gProtein = Solver.Solve(Rules, ref Known, nameof(gProtein));
            gCarb = Solver.Solve(Rules, ref Known, nameof(gCarb));
            gFat = Solver.Solve(Rules, ref Known, nameof(gFat));
            Advice = Solver.Solve(Rules, ref Known, nameof(Advice));
            Water = Solver.Solve(Rules, ref Known, nameof(Water));

            // round value
            BMI = Math.Round(double.Parse(BMI)).ToString();
            BodyFat = Math.Round(double.Parse(BodyFat)).ToString();
            CaloNeed = Math.Round(double.Parse(CaloNeed)).ToString();
            TotalEnergy = Math.Round(double.Parse(TotalEnergy)).ToString();
            Protein = Math.Round(double.Parse(Protein)).ToString();
            Carb = Math.Round(double.Parse(Carb)).ToString();
            Fat = Math.Round(double.Parse(Fat)).ToString() ;
            gProtein = Math.Round(double.Parse(gProtein)).ToString();
            gCarb = Math.Round(double.Parse(gCarb)).ToString();
            gFat = Math.Round(double.Parse(gFat)).ToString();
            Advice = string.Format(Advice, Environment.NewLine);
            Water = Math.Round(double.Parse(Water)).ToString();
        }

        private void DisplayResult()
        {
            tbxBMI.Text = BMI;
            tbxBodyFat.Text = BodyFat + " %";
            tbxCaloNeed.Text = CaloNeed + " cal";
            tbxTotalEnergy.Text = TotalEnergy + " cal/ngày";
            lblAdvice.Text = Advice;
            lblProtein.Text = Protein + " cal";
            lblCarb.Text = Carb + " cal";
            lblFat.Text = Fat + " cal";
            lblGramCarb.Text = gCarb + " gram";
            lblGramProtein.Text = gProtein + " gram";
            lblGramFat.Text = gFat + " gram";
            lblWater.Text += Water + " ml nước mỗi ngày nhé.";
        }

        private bool CheckInput()
        {
            if (string.IsNullOrEmpty(tbxHeight.Text))
            {
                MessageBox.Show("Bạn quên nhập chiều cao rồi!");
                return false;
            }
            if (string.IsNullOrEmpty(tbxWeight.Text))
            {
                MessageBox.Show("Bạn quên nhập cân nặng rồi!");
                return false;
            }
            if (string.IsNullOrEmpty(tbxAge.Text))
            {
                MessageBox.Show("Bạn quên nhập tuổi rồi!");
                return false;
            }
            if (string.IsNullOrEmpty(tbxWaist.Text))
            {
                MessageBox.Show("Bạn quên nhập vòng eo rồi!");
                return false;
            }
            if (string.IsNullOrEmpty(tbxNeck.Text))
            {
                MessageBox.Show("Bạn quên nhập vòng cổ rồi!");
                return false;
            }
            if (string.IsNullOrEmpty(Gender))
            {
                MessageBox.Show("Bạn quên chọn giới tính rồi!");
                return false;
            }
            if (string.IsNullOrEmpty(Habit))
            {
                MessageBox.Show("Bạn quên chọn trường \"Bạn là người:\" rồi!");
                return false;
            }
            if (Gender == "Female" && string.IsNullOrEmpty(tbxHip.Text))
            {
                MessageBox.Show("Bạn quên nhập vòng hông rồi!");
                return false;
            }
            return true;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            // input is invalid
            if (!CheckInput())
            {
                return;
            }
            GetKnown();
            Calculate();
            DisplayResult();
            timer1.Start();
        }

        private void frmHeathy_Load(object sender, EventArgs e)
        {
            
        }

        private void btnLowActive_Click(object sender, EventArgs e)
        {
            Habit = "LowActive";
        }

        private void btnNormalActive_Click(object sender, EventArgs e)
        {
            Habit = "Active";
        }

        private void btnHighActive_Click(object sender, EventArgs e)
        {
            Habit = "TooActive";
        }

        private void btnMale_Click(object sender, EventArgs e)
        {
            Gender = "Male";
        }

        private void btnFemale_Click(object sender, EventArgs e)
        {
            Gender = "Female";
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmKnowledge("BMI");
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            var frm = new frmNutrient();
            Hide();
            frm.ShowDialog();
            Show();
        }

        private void Choice_Click(object sender, EventArgs e)
        {
            var btn = sender as Button;
            var container = btn.Parent as Panel;
            foreach (Button item in container.Controls)
            {
                item.BackColor = NormalColor;
                item.Font = new Font(item.Font, FontStyle.Regular);
                item.ForeColor = Color.White;
            }
            btn.BackColor = ActiveColor;
            btn.Font = new Font(btn.Font, FontStyle.Bold);
            btn.ForeColor = Color.FromArgb(78, 114, 169);
        }
    }
}
