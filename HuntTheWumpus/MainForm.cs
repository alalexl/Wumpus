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
    public partial class MainForm : Form
    {
        public static int caveNum = 0;
        public GameControl _GameControl;

        public MainForm()
        {
            InitializeComponent();
            
        }

        private void Start_Click(object sender, EventArgs e)
        {
            if (caveNum == 0)
            {
                System.Windows.Forms.MessageBox.Show("You must pick a cave!");
            }
            else
            {
                _GameControl = new GameControl();
                _GameControl.caveNum = caveNum;
                _GameControl._MapObject._Cave.start(caveNum);
                _GameControl._Graphics.Show();
            }
        }

        private void Minigame_Click(object sender, EventArgs e)
        {
            Form1 mForm = new Form1();
            mForm.Show();
        }

        private void HighScores_Click(object sender, EventArgs e)
        {
            HighScoreForm hsForm = new HighScoreForm();
            hsForm.Show();
        }

        private void chooseCave1_Click(object sender, EventArgs e)
        {
            caveNum = 1;
            this.Start_Click(sender, e);
        }

        private void chooseCave2_Click(object sender, EventArgs e)
        {
            caveNum = 2;
            this.Start_Click(sender ,e);
        }

        private void chooseCave3_Click(object sender, EventArgs e)
        {
            caveNum = 3;
            this.Start_Click(sender, e);
        }

        private void chooseCave4_Click(object sender, EventArgs e)
        {
            caveNum = 4;
            this.Start_Click(sender, e);
        }

        private void chooseCave5_Click(object sender, EventArgs e)
        {
            caveNum = 5;
            this.Start_Click(sender, e);
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }
    }
}
