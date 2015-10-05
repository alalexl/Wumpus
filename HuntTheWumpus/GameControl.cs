using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace HuntTheWumpus
{
    public class GameControl
    {
        public Graphics _Graphics;
        public Trivia _Trivia;
        public PlayerObject _PlayerObject;
        public MapObject _MapObject;
        public HighScore _HighScore;
        public Question _TriviaForm;
        public Sound _Sound;
        private int maxCoins = 100;
        public String name;
        public int caveNum;
        public Boolean moved;
        Random r = new Random();

        public GameControl()
        {
            _MapObject = new MapObject();
            _MapObject._Cave.start(MainForm.caveNum);
            _Trivia = new Trivia();
            _HighScore = new HighScore();
            _PlayerObject = new PlayerObject();            
            _Graphics = new Graphics(this);
            _TriviaForm = new Question();
            _Sound = new Sound();
        }

        public void move(int room)
        {
            foreach(PictureBox p in _Graphics.directions)
            {
                if (p.Visible == true)
                {
                    p.Visible = false;
                }
            }
            _Sound.moveSound();
            MessageBox.Show("Q: "+_Trivia.getQuestion()+" A: "+_Trivia.getcorrectAnswer());
            _PlayerObject.turnsTaken++;
            _PlayerObject.goldCoins++;
            maxCoins--;
            _MapObject.playerLocation = room;
            _Sound.earnGoldCoinsSound();
        }

        public int getRoom()
        {
            return _MapObject.playerLocation;
        }

        public int getGold()
        {
            return _PlayerObject.goldCoins;
        }

        public int getArrows()
        {
            return _PlayerObject.arrows;
        }

        public void checkCoins()
        {
            if (maxCoins == 0)
            {
                MessageBox.Show("You have run out of coins!");
                newHighScore();
            }
        }

        public void purchaseArrows()
        {
            _TriviaForm.reset();            
            if (_PlayerObject.goldCoins < 3)
            {
                MessageBox.Show("You don't have enough gold coins!");
            }
            else
            {
                _TriviaForm.check = _TriviaForm.everything;
                _TriviaForm.ShowDialog();
                if (_TriviaForm.correct >= 2)
                {
                    _Sound.purchaseSound();
                    System.Windows.Forms.MessageBox.Show("You bought two arrows!");
                    _PlayerObject.arrows += 2;
                    _PlayerObject.goldCoins = _PlayerObject.goldCoins - 3;
                    _TriviaForm.Hide();
                }
            }
            
        }

        public void purchaseSecret()
        {
            _TriviaForm.reset();
            if (_PlayerObject.goldCoins < 3)
            {
                MessageBox.Show("You don't have enough gold coins!");
            }
            else
            {
                _TriviaForm.check = _TriviaForm.everything;
                _TriviaForm.ShowDialog();
                if (_TriviaForm.correct >= 2)
                {
                    _Sound.purchaseSound();
                    System.Windows.Forms.MessageBox.Show(_MapObject.secrets());
                    _PlayerObject.arrows += 2;
                    _PlayerObject.goldCoins -= 3;
                    _TriviaForm.Hide();
                }
            }            
        }

        public void shootArrow(int room)
        {
            if (_MapObject.shootsArrow(room))
            {
                _Sound.arrowSound();
                _PlayerObject.arrows--;
                MessageBox.Show("Congratulations! You have slain the Wumpus!");
                newHighScore();
            }
            else
            {
                _Sound.arrowMissSound();
                _PlayerObject.arrows--;
                MessageBox.Show("You missed!");
                if (_PlayerObject.arrows == 0)
                {
                    System.Windows.Forms.MessageBox.Show("You have no more arrows!");                    
                }
            }
        }

        public int getTurns()
        {
            return _PlayerObject.turnsTaken;
        }

        public void checkHazards()
        {
            _MapObject.checkBats();
            _MapObject.checkPits();
            _MapObject.checkWumpus();
        }

        public void encounterBat()
        {
            moved = false;
            if (this.getRoom() == this.getBat1() || this.getRoom() == this.getBat2())
            {
                moved = true;
                _Sound.batSound();
                _Graphics.displayBats();
                _MapObject.playerLocation = r.Next(1, 30);
                System.Windows.Forms.MessageBox.Show("You were transported to room "+_MapObject.playerLocation);
                _Graphics.closeBats();
            }
        }

        public void encounterPit()
        {
            if (this.getRoom() == this.getPit1() || this.getRoom() == this.getPit2())
            {
                _Sound.pitSound();
                if (_PlayerObject.goldCoins < 3)
                {
                    MessageBox.Show("You ran into a pit and don't have enough gold coins! You have died!");
                    newHighScore();
                }
                else
                {
                    _TriviaForm.reset();
                    _Graphics.displayPit();
                    System.Windows.Forms.MessageBox.Show("You fell into a pit! Quick! Answer these questions!");
                    _Graphics.closePit();
                    _TriviaForm.check = _TriviaForm.everything;
                    _TriviaForm.ShowDialog();
                    _PlayerObject.goldCoins -= _TriviaForm.everything;
                    if (_TriviaForm.correct >= 2)
                    {
                        System.Windows.Forms.MessageBox.Show("You made it out!");
                        _MapObject.playerLocation = _MapObject.startLocation;
                    }
                    else
                    {
                        MessageBox.Show("You have died in the pit!");
                        newHighScore();
                    }
                }      
            }
        }

        public void encounterWumpus()
        {
            if (this.getRoom() == this.getWumpus())
            {
                if (_PlayerObject.goldCoins < 5)
                {
                    MessageBox.Show("You ran into the Wumpus and don't have enough gold coins! You have died!");
                    newHighScore();
                }
                else
                {
                    _TriviaForm.reset();
                    _Graphics.displayWumpus();
                    System.Windows.Forms.MessageBox.Show("It's the Wumpus! Quick! Answer these questions!");
                    _Graphics.closeWumpus();
                    _TriviaForm.check = _TriviaForm.wumpus;
                    _TriviaForm.ShowDialog();
                    _PlayerObject.goldCoins -= _TriviaForm.wumpus;
                    if (_TriviaForm.correct >= 3)
                    {
                        System.Windows.Forms.MessageBox.Show("You wounded the Wumpus!");
                        _MapObject.wumpusMove(_MapObject._Cave.wumpusMove(_MapObject.wumpusLocation));
                    }
                    else
                    {
                        System.Windows.Forms.MessageBox.Show("You have died to the Wumpus!");
                        newHighScore();
                    }
                }
            }
        }

        public void useCoin()
        {
            _PlayerObject.goldCoins--;
        }
        
        public int[] getRoomDirections()
        {
            return _MapObject.getRoomDirections();
        }

        public int[] getRoomConnection()
        {
            return _MapObject.getRoomConnections();
        }

        public int getBat1()
        {
            return _MapObject.bat1;
        }

        public int getBat2()
        {
            return _MapObject.bat2;
        }

        public int getPit1()
        {
            return _MapObject.pit1;
        }

        public int getPit2()
        {
            return _MapObject.pit2;
        }

        public int getWumpus()
        {
            return _MapObject.wumpusLocation;
        }

        public void newHighScore()
        {
            
            name = Interaction.InputBox("What is your name?", "", string.Empty, -1, -1);
            if (caveNum == 1)
            {

                MessageBox.Show("You ended with a score of " + _PlayerObject.getFinalScore() + "!");
                _HighScore.insertNewScore1(name, _PlayerObject.getFinalScore());
                _Graphics.Hide();
            }
            else if (caveNum == 2)
            {
                _HighScore.insertNewScore2(name, _PlayerObject.getFinalScore());
                MessageBox.Show("You ended with a score of " + _PlayerObject.getFinalScore() + "!");
                _Graphics.Hide();
            }
            else if (caveNum == 3)
            {
                _HighScore.insertNewScore3(name, _PlayerObject.getFinalScore());
                MessageBox.Show("You ended with a score of " + _PlayerObject.getFinalScore() + "!");
                _Graphics.Hide();
            }
            else if (caveNum == 4)
            {
                _HighScore.insertNewScore4(name, _PlayerObject.getFinalScore());
                MessageBox.Show("You ended with a score of " + _PlayerObject.getFinalScore() + "!");
                _Graphics.Hide();
            }
            else if (caveNum == 5)
            {
                _HighScore.insertNewScore5(name, _PlayerObject.getFinalScore());
                MessageBox.Show("You ended with a score of " + _PlayerObject.getFinalScore() + "!");
                _Graphics.Hide();
            }
        }
     }
}

