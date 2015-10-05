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
    public partial class Graphics : Form
    {
        Timer timer = new Timer();
        public PictureBox[] directions = new PictureBox[6];
        TextBox[] directionsText = new TextBox[6];
        GameControl _GameControl;
        int[] directions2;
        int[] connections;
        Random r = new Random();
        public Graphics(GameControl g)
        {

            InitializeComponent();
            _GameControl = g;
            displayArrows();
            displayGold();
            displayTurns();
            displayRoom();
            directions[0] = Direction1;
            directions[1] = Direction2;
            directions[2] = Direction3;
            directions[3] = Direction4;
            directions[4] = Direction5;
            directions[5] = Direction6;
            directions2 = _GameControl.getRoomDirections();
            connections = _GameControl.getRoomConnection();
            directionsText[0] = Arrow1;
            directionsText[1] = Arrow2;
            directionsText[2] = Arrow3;
            directionsText[3] = Arrow4;
            directionsText[4] = Arrow5;
            directionsText[5] = Arrow6;
            setDirectionsWithRoom();
            
        }
        public void setDirectionsWithRoom()
        {
            foreach(TextBox t in directionsText)
            {
                t.Text = "";
            }
            for (int x =0; x<directions2.Length; x++)
            {
                if (directions2[x] != 0)
                {
                    directions[directions2[x] - 1].Visible = true;
                    directionsText[directions2[x] - 1].Text = "Room " + connections[x].ToString();
                }
            }
        }

        public void displayGold()
        {
            GoldCount.Text = _GameControl.getGold().ToString();
        }
        public void displayArrows()
        {
            ArrowBox.Text = _GameControl.getArrows().ToString();
        }
        public void displayTurns()
        {
            TurnCount.Text = _GameControl.getTurns().ToString() + " turns";
        }
        public void displayRoom()
        {
            RoomBox.Text = "Room " + _GameControl.getRoom().ToString();
        }
        public void displayBats()
        {
            Bats.Visible = !Bats.Visible;
        }

        public void closeBats()
        {
            Bats.Visible = false;
        }
        public void displayPit()
        {
            pit.Visible = !pit.Visible;
        }
        public void closePit()
        {
            pit.Visible = false;
        }
        public void displayWumpus()
        {
            Wumpus.Visible = !Wumpus.Visible;
        }
        public void closeWumpus()
        {
            Wumpus.Visible = false;
        }
        private void pictureBox4_Click(object sender, EventArgs e)
        {

        }

        private void GoldCount_TextChanged(object sender, EventArgs e)
        {

        }
        public void setGoldCount(int goldCount)
        {
            GoldCount.Text = goldCount.ToString();
        }

        private void ArrowPurchase_Click(object sender, EventArgs e)
        {
            _GameControl.purchaseArrows();
            this.refresh();            
        }

        private void purchaseSecret_Click_1(object sender, EventArgs e)
        {
            _GameControl.purchaseSecret();
            this.refresh();
        }

        public void clearDirections()
        {
            Direction1.Visible = false;
            Direction2.Visible = false;
            Direction3.Visible = false;
            Direction4.Visible = false;
            Direction5.Visible = false;
            Direction6.Visible = false;

        }
        
        public void refresh()
        {
            _GameControl.checkHazards();
            _GameControl.encounterBat();
            if (_GameControl.moved) _GameControl.checkHazards();
            _GameControl.encounterPit();
            _GameControl.encounterWumpus();
            _GameControl.checkCoins();
            displayArrows();
            displayGold();
            displayTurns();
            displayRoom();
            directions[0] = Direction1;
            directions[1] = Direction2;
            directions[2] = Direction3;
            directions[3] = Direction4;
            directions[4] = Direction5;
            directions[5] = Direction6;
            clearDirections();
            directions2 = _GameControl.getRoomDirections();
            connections = _GameControl.getRoomConnection();
            setDirectionsWithRoom();
        }
        private void Direction6_Click(object sender, EventArgs f)
        {
            MouseEventArgs e = (MouseEventArgs) f;
            if (Direction6.Visible)
            {
                int roomIndex;
                int room = 0;
                for (int i = 0; i < directions2.Length; i++)
                {
                    if (directions2[i] == 6)
                    {
                        roomIndex = i;
                        room = connections[roomIndex];
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    _GameControl.shootArrow(_GameControl.getRoom());
                }
                else
                {
                    _GameControl.move(room);
                    //this.refresh();
                }
                this.refresh();
            }
        }

        private void Direction1_Click(object sender, EventArgs f)
        {
            MouseEventArgs e = (MouseEventArgs) f;
            if (Direction1.Visible)
            {
                int roomIndex;
                int room = 0;
                for (int i = 0; i < directions2.Length; i++)
                {
                    if (directions2[i] == 1)
                    {
                        roomIndex = i;
                        room = connections[roomIndex];
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    _GameControl.shootArrow(room);
                }
                else
                {
                    _GameControl.move(room);
                    //this.refresh();
                }
                this.refresh();
            }
        }

        private void Direction2_Click(object sender, EventArgs f)
        {
            MouseEventArgs e = (MouseEventArgs) f;
            if (Direction2.Visible)
            {
                int roomIndex;
                int room = 0;
                for (int i = 0; i < directions2.Length; i++)
                {
                    if (directions2[i] == 2)
                    {
                        roomIndex = i;
                        room = connections[roomIndex];
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    _GameControl.shootArrow(room);
                }
                else
                {
                    _GameControl.move(room);
                    //this.refresh();
                }
                this.refresh();
            }
        }

        private void Direction3_Click(object sender, EventArgs f)
        {
            MouseEventArgs e = (MouseEventArgs) f;
            if (Direction3.Visible)
            {
                int roomIndex;
                int room = 0;
                for (int i = 0; i < directions2.Length; i++)
                {
                    if (directions2[i] == 3)
                    {
                        roomIndex = i;
                        room = connections[roomIndex];
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    _GameControl.shootArrow(room);                    
                }
                else
                {
                    _GameControl.move(room);
                    //this.refresh();
                }
                this.refresh();
            }
        }

        private void Direction4_Click(object sender, EventArgs f)
        {
            MouseEventArgs e = (MouseEventArgs) f;
            if (Direction4.Visible)
            {
                int roomIndex;
                int room = 0;
                for (int i = 0; i < directions2.Length; i++)
                {
                    if (directions2[i] == 4)
                    {
                        roomIndex = i;
                        room = connections[roomIndex];
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    _GameControl.shootArrow(room);
                }
                else
                {
                    _GameControl.move(room);
                    //this.refresh();
                }
                this.refresh();
            }
        }

        private void Direction5_Click(object sender, EventArgs f)
        {
            MouseEventArgs e = (MouseEventArgs) f;
            if (Direction5.Visible)
            {
                int roomIndex;
                int room = 0;
                for (int i = 0; i < directions2.Length; i++)
                {
                    if (directions2[i] == 5)
                    {
                        roomIndex = i;
                        room = connections[roomIndex];
                    }
                }
                if (e.Button == MouseButtons.Right)
                {
                    _GameControl.shootArrow(room);
                }
                else
                {
                    _GameControl.move(room);
                    //this.refresh();
                }
                this.refresh();
            }
        }

        private void Bats_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged_1(object sender, EventArgs e)
        {

        }

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
