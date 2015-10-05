using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HuntTheWumpus
{
    public partial class HighScoreForm : Form
    {
        public HighScore _HighScore;

        public HighScoreForm()
        {
            InitializeComponent();
        }

        private void Back_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void cave1_Click(object sender, EventArgs e)
        {
            HighScore _HighScore = new HighScore();
            name1.Text = _HighScore.getHighScoreValues1()[0, 0];
            name2.Text = _HighScore.getHighScoreValues1()[1, 0];
            name3.Text = _HighScore.getHighScoreValues1()[2, 0];
            name4.Text = _HighScore.getHighScoreValues1()[3, 0];
            name5.Text = _HighScore.getHighScoreValues1()[4, 0];
            name6.Text = _HighScore.getHighScoreValues1()[5, 0];
            name7.Text = _HighScore.getHighScoreValues1()[6, 0];
            name8.Text = _HighScore.getHighScoreValues1()[7, 0];
            name9.Text = _HighScore.getHighScoreValues1()[8, 0];
            name10.Text = _HighScore.getHighScoreValues1()[9, 0];
            score1.Text = _HighScore.getHighScoreValues1()[0, 1];
            score2.Text = _HighScore.getHighScoreValues1()[1, 1];
            score3.Text = _HighScore.getHighScoreValues1()[2, 1];
            score4.Text = _HighScore.getHighScoreValues1()[3, 1];
            score5.Text = _HighScore.getHighScoreValues1()[4, 1];
            score6.Text = _HighScore.getHighScoreValues1()[5, 1];
            score7.Text = _HighScore.getHighScoreValues1()[6, 1];
            score8.Text = _HighScore.getHighScoreValues1()[7, 1];
            score9.Text = _HighScore.getHighScoreValues1()[8, 1];
            score10.Text = _HighScore.getHighScoreValues1()[9, 1];
        }

        private void cave2_Click(object sender, EventArgs e)
        {
            HighScore _HighScore = new HighScore();
            name1.Text = _HighScore.getHighScoreValues2()[0, 0];
            name2.Text = _HighScore.getHighScoreValues2()[1, 0];
            name3.Text = _HighScore.getHighScoreValues2()[2, 0];
            name4.Text = _HighScore.getHighScoreValues2()[3, 0];
            name5.Text = _HighScore.getHighScoreValues2()[4, 0];
            name6.Text = _HighScore.getHighScoreValues2()[5, 0];
            name7.Text = _HighScore.getHighScoreValues2()[6, 0];
            name8.Text = _HighScore.getHighScoreValues2()[7, 0];
            name9.Text = _HighScore.getHighScoreValues2()[8, 0];
            name10.Text = _HighScore.getHighScoreValues2()[9, 0];
            score1.Text = _HighScore.getHighScoreValues2()[0, 1];
            score2.Text = _HighScore.getHighScoreValues2()[1, 1];
            score3.Text = _HighScore.getHighScoreValues2()[2, 1];
            score4.Text = _HighScore.getHighScoreValues2()[3, 1];
            score5.Text = _HighScore.getHighScoreValues2()[4, 1];
            score6.Text = _HighScore.getHighScoreValues2()[5, 1];
            score7.Text = _HighScore.getHighScoreValues2()[6, 1];
            score8.Text = _HighScore.getHighScoreValues2()[7, 1];
            score9.Text = _HighScore.getHighScoreValues2()[8, 1];
            score10.Text = _HighScore.getHighScoreValues2()[9, 1];
        }

        private void cave3_Click(object sender, EventArgs e)
        {
            HighScore _HighScore = new HighScore();
            name1.Text = _HighScore.getHighScoreValues3()[0, 0];
            name2.Text = _HighScore.getHighScoreValues3()[1, 0];
            name3.Text = _HighScore.getHighScoreValues3()[2, 0];
            name4.Text = _HighScore.getHighScoreValues3()[3, 0];
            name5.Text = _HighScore.getHighScoreValues3()[4, 0];
            name6.Text = _HighScore.getHighScoreValues3()[5, 0];
            name7.Text = _HighScore.getHighScoreValues3()[6, 0];
            name8.Text = _HighScore.getHighScoreValues3()[7, 0];
            name9.Text = _HighScore.getHighScoreValues3()[8, 0];
            name10.Text = _HighScore.getHighScoreValues3()[9, 0];
            score1.Text = _HighScore.getHighScoreValues3()[0, 1];
            score2.Text = _HighScore.getHighScoreValues3()[1, 1];
            score3.Text = _HighScore.getHighScoreValues3()[2, 1];
            score4.Text = _HighScore.getHighScoreValues3()[3, 1];
            score5.Text = _HighScore.getHighScoreValues3()[4, 1];
            score6.Text = _HighScore.getHighScoreValues3()[5, 1];
            score7.Text = _HighScore.getHighScoreValues3()[6, 1];
            score8.Text = _HighScore.getHighScoreValues3()[7, 1];
            score9.Text = _HighScore.getHighScoreValues3()[8, 1];
            score10.Text = _HighScore.getHighScoreValues3()[9, 1];
        }

        private void cave4_Click(object sender, EventArgs e)
        {
            HighScore _HighScore = new HighScore();
            name1.Text = _HighScore.getHighScoreValues4()[0, 0];
            name2.Text = _HighScore.getHighScoreValues4()[1, 0];
            name3.Text = _HighScore.getHighScoreValues4()[2, 0];
            name4.Text = _HighScore.getHighScoreValues4()[3, 0];
            name5.Text = _HighScore.getHighScoreValues4()[4, 0];
            name6.Text = _HighScore.getHighScoreValues4()[5, 0];
            name7.Text = _HighScore.getHighScoreValues4()[6, 0];
            name8.Text = _HighScore.getHighScoreValues4()[7, 0];
            name9.Text = _HighScore.getHighScoreValues4()[8, 0];
            name10.Text = _HighScore.getHighScoreValues4()[9, 0];
            score1.Text = _HighScore.getHighScoreValues4()[0, 1];
            score2.Text = _HighScore.getHighScoreValues4()[1, 1];
            score3.Text = _HighScore.getHighScoreValues4()[2, 1];
            score4.Text = _HighScore.getHighScoreValues4()[3, 1];
            score5.Text = _HighScore.getHighScoreValues4()[4, 1];
            score6.Text = _HighScore.getHighScoreValues4()[5, 1];
            score7.Text = _HighScore.getHighScoreValues4()[6, 1];
            score8.Text = _HighScore.getHighScoreValues4()[7, 1];
            score9.Text = _HighScore.getHighScoreValues4()[8, 1];
            score10.Text = _HighScore.getHighScoreValues4()[9, 1];
        }

        private void cave5_Click(object sender, EventArgs e)
        {
            HighScore _HighScore = new HighScore();
            name1.Text = _HighScore.getHighScoreValues5()[0, 0];
            name2.Text = _HighScore.getHighScoreValues5()[1, 0];
            name3.Text = _HighScore.getHighScoreValues5()[2, 0];
            name4.Text = _HighScore.getHighScoreValues5()[3, 0];
            name5.Text = _HighScore.getHighScoreValues5()[4, 0];
            name6.Text = _HighScore.getHighScoreValues5()[5, 0];
            name7.Text = _HighScore.getHighScoreValues5()[6, 0];
            name8.Text = _HighScore.getHighScoreValues5()[7, 0];
            name9.Text = _HighScore.getHighScoreValues5()[8, 0];
            name10.Text = _HighScore.getHighScoreValues5()[9, 0];
            score1.Text = _HighScore.getHighScoreValues5()[0, 1];
            score2.Text = _HighScore.getHighScoreValues5()[1, 1];
            score3.Text = _HighScore.getHighScoreValues5()[2, 1];
            score4.Text = _HighScore.getHighScoreValues5()[3, 1];
            score5.Text = _HighScore.getHighScoreValues5()[4, 1];
            score6.Text = _HighScore.getHighScoreValues5()[5, 1];
            score7.Text = _HighScore.getHighScoreValues5()[6, 1];
            score8.Text = _HighScore.getHighScoreValues5()[7, 1];
            score9.Text = _HighScore.getHighScoreValues5()[8, 1];
            score10.Text = _HighScore.getHighScoreValues5()[9, 1];
        }

        private void name1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
