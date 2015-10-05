using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace HuntTheWumpus
{
    public class PlayerObject
    {
        private int _arrows = 3;
        private int _goldCoins;
        private int _turnsTaken;


        public int arrows
        {
            get { return _arrows; }
            set { _arrows = value; }

        }
        public int goldCoins
        {
            get { return _goldCoins; }
            set { _goldCoins = value; }

        }
        public int turnsTaken
        {
            get { return _turnsTaken; }
            set { _turnsTaken = value; }
            

        }
        public int getFinalScore()
        {

            return 100-(turnsTaken+goldCoins+(10*arrows));
        }

    }
}
