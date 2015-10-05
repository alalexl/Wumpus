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
    public partial class Question : Form
    {
        Trivia _trivia = new Trivia();
        public int correct;
        public int times;
        public int check;
        public int ecorrect = 2;
        public int wcorrect = 3;
        public int everything = 3;
        public int wumpus = 5;


        public void reset()
        {
            times = 0;
            correct = 0;
        }

        public Question()
        {
            InitializeComponent();
            reset();
        }

        public void button1_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = _trivia.getQuestion();
            textBox2.Text = _trivia.getAnswer1();
            textBox3.Text = _trivia.getAnswer2();
            textBox4.Text = _trivia.getAnswer3();
            textBox5.Text = _trivia.getAnswer4();
            textBox6.Text = correct.ToString();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }
      
        private void button2_Click(object sender, EventArgs e)
        {
            if (_trivia.getcorrectAnswer().Equals(textBox2.Text))
            {
                _trivia.setCorrect(true);
                MessageBox.Show("Congratulations!");
                correct++;
                times++;
            }
            else
            {
                MessageBox.Show("Sorry!");
                times++;
            }
            if (times == check)
            {
                this.Hide();
            }
            button1_Click_1(sender, e);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            
            if (_trivia.getcorrectAnswer().Equals(textBox3.Text))
            {
                _trivia.setCorrect(true);
                MessageBox.Show("Congratulations!");
                correct++;
                times++;
            }
            else
            {
                MessageBox.Show("Sorry!");
                times++;
            }
            if (times == check)
            {
                this.Hide();
            }
            button1_Click_1(sender, e);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            if (_trivia.getcorrectAnswer().Equals(textBox4.Text))
            {
                _trivia.setCorrect(true);
                MessageBox.Show("Congratulations!");
                correct++;
                times++;
            }
            else
            {
                MessageBox.Show("Sorry!");
                times++;
            }
            if (times == check)
            {
                this.Hide();
            }
            button1_Click_1(sender, e);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (_trivia.getcorrectAnswer().Equals(textBox5.Text))
            {
                _trivia.setCorrect(true);
                MessageBox.Show("Congratulations!");
                correct++;
                times++;
                
            }
            else
            {
                MessageBox.Show("Sorry!");
                times++;
            }
            if (times == check)
            {
                this.Hide();
            }
            button1_Click_1(sender, e);
        }

        private void Question_Load(object sender, EventArgs e)
        {
            textBox1.Text = _trivia.getQuestion();
            textBox2.Text = _trivia.getAnswer1();
            textBox3.Text = _trivia.getAnswer2();
            textBox4.Text = _trivia.getAnswer3();
            textBox5.Text = _trivia.getAnswer4();
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            
        }

        //disables the X close button
        private const int CP_NOCLOSE_BUTTON = 0x200;
        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams myCp = base.CreateParams;
                myCp.ClassStyle = myCp.ClassStyle | CP_NOCLOSE_BUTTON;
                return myCp;
            }
        }
    }       
}
