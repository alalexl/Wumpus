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
    public partial class Form1 : Form
    {
        
        private long millisecondsStart;
        private long deltatime;
        private int buttonsClicked;
        private Random random = new Random();
        private int order1;
        private int order2;
        private long deltatime1;
        private long millisecondsStart1;
        private int timeBetweenClicks;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            millisecondsStart = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            millisecondsStart1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            buttonsClicked = 0;
            order1 = 0;
            order2 = 0;
            Timer timer = new Timer();
            timeBetweenClicks = 5000;

        }

        private void button2_Click(object sender, EventArgs e)
        {




        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
        private void textBox1_KeyDown(object sender, System.Windows.Forms.KeyEventArgs e)
        {

            if (e.KeyCode == Keys.F1)
            {
                //MessageBox("pad 0 pressed");
                
            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            MessageBox.Show("You Lose!");
            this.Close();
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            textBox1.Text = timeBetweenClicks.ToString();
            order1++;
            if (!(order1-order2==1))
            {
                MessageBox.Show("Out of Order");
                this.Close();
            }
            if (buttonsClicked > 30)
            {
                MessageBox.Show("You Win!");
                this.Close();
            }
            deltatime = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            deltatime = deltatime - millisecondsStart;
            if (deltatime > timeBetweenClicks)
            {
                MessageBox.Show("Too Slow");
                this.Close();
            }


          
            ClickMe.Location = new Point(random.Next(0, 500), random.Next(0, 500));
            if (timeBetweenClicks < 4000)
            {
                button3.Location = new Point(random.Next(0, 500), random.Next(0, 500));
                button4.Location = new Point(random.Next(0, 500), random.Next(0, 500));
                button5.Location = new Point(random.Next(0, 500), random.Next(0, 500));
                button6.Location = new Point(random.Next(0, 500), random.Next(0, 500));
                
            }
            if (timeBetweenClicks < 3500)
            {
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button3.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                button5.ForeColor = Color.Black;
                button6.ForeColor = Color.Black;
            }
            millisecondsStart = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            buttonsClicked++;
            if (timeBetweenClicks > 1500)
            {
                timeBetweenClicks = timeBetweenClicks - 100;
            }
            
        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = timeBetweenClicks.ToString();
            order2++;
            if (!(order1 == order2))
            {
                MessageBox.Show("Out of Order");
                this.Close();

            }
            if (buttonsClicked > 30)
            {
                MessageBox.Show("You Win!");
                this.Close();
            }
            deltatime1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            deltatime1 = deltatime1 - millisecondsStart1;
            if (deltatime > timeBetweenClicks) 
            {
                MessageBox.Show("Too Slow");
                this.Close();
            }
            

            button2.Location = new Point(random.Next(0, 500), random.Next(0, 500));
            if (timeBetweenClicks < 4000)
            {
                button3.Location = new Point(random.Next(0, 500), random.Next(0, 500));
                button4.Location = new Point(random.Next(0, 500), random.Next(0, 500));
                button5.Location = new Point(random.Next(0, 500), random.Next(0, 500));
                button6.Location = new Point(random.Next(0, 500), random.Next(0, 500));
            }
            if (timeBetweenClicks < 3500)
            {
                button3.BackColor = Color.Red;
                button4.BackColor = Color.Red;
                button5.BackColor = Color.Red;
                button6.BackColor = Color.Red;
                button3.ForeColor = Color.Black;
                button4.ForeColor = Color.Black;
                button5.ForeColor = Color.Black;
                button6.ForeColor = Color.Black;
                
            }
            millisecondsStart1 = DateTime.Now.Ticks / TimeSpan.TicksPerMillisecond;
            buttonsClicked++;
            if (timeBetweenClicks > 1500)
            {
                timeBetweenClicks = timeBetweenClicks - 100;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong button!");
            this.Close();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong button!");
            this.Close();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong button!");
            this.Close();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Wrong button!");
            this.Close();
        }

        private void textBox1_TextChanged_2(object sender, EventArgs e)
        {

        }

       
    }
}
