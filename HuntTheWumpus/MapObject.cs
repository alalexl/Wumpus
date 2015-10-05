using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.Windows.Forms;

namespace HuntTheWumpus
{
    public class MapObject
    {
        public Cave _Cave;

        public MapObject()
        {
            _Cave = new Cave();
            setHazards();
            setPlayerLocation();
            setWumpusLocation();
        }

        Random rnd = new Random();

        private int _startLocation;
        private int _playerLocation;
        private int _wumpusLocation;
        private int _bat1;
        private int _bat2;
        private int _pit1;
        private int _pit2;

        public int startLocation
        {
            get { return _startLocation; }
        }

        public int playerLocation
        {
            get { return _playerLocation; }
            set { _playerLocation = value; }
        }
        public int wumpusLocation
        {
            get { return _wumpusLocation; }
            set { _wumpusLocation = value; }
        }
        public int bat1
        {
            get { return _bat1; }
            set { _bat1 = value; }
        }
        public int bat2
        {
            get { return _bat2; }
            set { _bat2 = value; }
        }
        public int pit1
        {
            get { return _pit1; }
            set { _pit1 = value; }
        }
        public int pit2
        {
            get { return _pit2; }
            set { _pit2 = value; }
        }
        private String status;

        public void setPlayerLocation()
        {
            
            _startLocation = rnd.Next(1, 30);
            playerLocation = _startLocation;
            int[] connections = getRoomConnections();
            if (connections[1] == 0)
            {
                if (_Cave.caveRepresentation[playerLocation, 4] == pit1 || _Cave.caveRepresentation[playerLocation, 4] == pit2)
                {
                    setPlayerLocation();
                }
            }
        }

        public void setWumpusLocation()
        {
            wumpusLocation = rnd.Next(1, 30);
            Boolean redo = true;
            do
            {
                if (wumpusLocation == playerLocation)
                {
                    wumpusLocation = rnd.Next(1, 30);
                }
                else
                    redo = false;
            }
            while (redo);
        }

        public void wumpusMove(ArrayList possible)
        {
            wumpusLocation = (int) possible[rnd.Next(possible.Count)];
        }


        public void setHazards()
        {
            bat1 = rnd.Next(1, 30);
            bat2 = rnd.Next(1, 30);
            pit1 = rnd.Next(1, 30);
            pit2 = rnd.Next(1, 30);
            int[] impossible = new int[] { playerLocation, bat1, bat2, pit1, pit2 };

            for (int i = 1; i < impossible.Length; i++)
            {
                Boolean redo;
                do
                {
                    redo = false;
                    for (int j = i - 1; j >= 0; j--)
                    {
                        if (impossible[i] == impossible[j])
                            redo = true;
                    }
                    if (redo)
                        impossible[i] = rnd.Next(1, 30);
                }
                while (redo);
            }
            bat1 = impossible[1];
            bat2 = impossible[2];
            pit1 = impossible[3];
            pit2 = impossible[4];
        }

        public int[] getRoomDirections()
        {
            return _Cave.getRoomDirections(playerLocation);
        }

        public int[] getRoomConnections()
        {
            return _Cave.getRoomConnections(playerLocation);
        }

        public String wumpusAttitude()
        {
            int a = rnd.Next(1, 3);
            if (a == 1)
                status = "Asleep";
            else if (a == 2)
                status = "Awake";
            else if (a == 3)
                status = "Moving";
            return status;
        }

        public void checkPits()
        {
            for (int j = 0; j < getRoomConnections().Length; j++)
            {
                if (getRoomConnections()[j] == pit1 || getRoomConnections()[j] == pit2)
                {
                    MessageBox.Show("I feel a draft");
                }
            }
        }

        public void checkBats()
        {
            for (int j = 0; j < getRoomConnections().Length; j++)
            {
                if (getRoomConnections()[j] == bat1 || getRoomConnections()[j] == bat2)
                {
                    MessageBox.Show("Bats nearby");
                }
            }
        }

        public void checkWumpus()
        {
            for (int j = 0; j < getRoomConnections().Length; j++)
            {
                if (getRoomConnections()[j] == wumpusLocation)
                {
                    MessageBox.Show("I smell a Wumpus!");
                }
            }
        }
        public Boolean shootsArrow(int room)
        {
            Boolean madeIt = false;
            int[] neighbors = _Cave.getRoomConnections(playerLocation);
            for (int i = 0; i < neighbors.Length; i++)
            {
                if (wumpusLocation == room)
                    madeIt = true;
            }
            return madeIt;
        }


        public String secrets()
        {
            
            String String1 = "The wumpus is in room number " + wumpusLocation;
            String String2 = "There is a bat in room number " + bat1;
            String String3 = "There is a bat in room number " + bat2;
            String String4 = "There is a pit in room number " + pit1;
            String String5 = "There is a pit in room number " + pit2;
            String[] options = new String[] { String1, String2, String3, String4, String5 };
            List<String> temp = new List<String>(options);
            String secret;
            if (temp.Count == 0)
            {
                temp = new List<string>(options);
            }

                int rand = rnd.Next(0, temp.Count - 1);
                secret = temp[rand];
                temp.RemoveAt(rand);
                return secret;
        }
    }
}