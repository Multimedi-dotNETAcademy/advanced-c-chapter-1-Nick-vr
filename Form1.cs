using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace advanced_c_chapter_1_Nick_vr
{
    public partial class formGrades : Form
    {
        public int achievedPercentage { get; set; }
        public string achievedGrade { get; set; }

        public formGrades()
        {
            InitializeComponent();
        }

        private void numericResult_ValueChanged(object sender, EventArgs e)
        {
            achievedPercentage = (int)numericResult.Value;
        }

        private void btnCheckResult_Click(object sender, EventArgs e)
        {
            lblGrade.Text = $"Achieved grade is {GetGrade(achievedPercentage)}";
        }

        /// <summary>
        /// Grades by USA
        /// A - 90-100
        /// B - 80-89
        /// C - 70-79
        /// D - 60-69
        /// E/F - 0-59
        /// </summary>
        private string GetGrade(int percent)
        {
            if (achievedPercentage <= 59)
            {
                achievedGrade = "F";
            }
            else if (achievedPercentage <= 69)
            {
                achievedGrade = "D";
            }
            else if (achievedPercentage <= 79)
            {
                achievedGrade = "C";
            }
            else if (achievedPercentage <= 89)
            {
                achievedGrade = "B";
            }
            else
            {
                achievedGrade = "A";
            }

            return achievedGrade;
        }
    }
}