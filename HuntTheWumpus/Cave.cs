using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;

namespace HuntTheWumpus
{
    public class Cave
    {
        Random r = new Random();
        public int[,] caveRepresentation = new int[31, 7];
        public int temp;
        public int past;
        public int test;
        ArrayList wumpus = new ArrayList();
        ArrayList previousvalues = new ArrayList();
        public Cave()
        {

        }
        public int[] getRoomDirections(int n)
        {
            int[] temp = new int[3];
            temp[0] = caveRepresentation[n-1, 1];
            temp[1] = caveRepresentation[n-1, 2];
            temp[2] = caveRepresentation[n-1, 3];
            return temp;
            //takes in the current room number, returns array of directions that the room connects to
        }
        public int[] getRoomConnections(int n)
        {
            int[] temp = new int[3];
            temp[0] = caveRepresentation[n-1, 4];
            temp[1] = caveRepresentation[n-1, 5];
            temp[2] = caveRepresentation[n-1, 6];
            return temp;
            //takes in the current room number, returns array of connections to room numbers (not directions)
        }
        public ArrayList wumpusMove(int n)
        {
            int[] values = new int[3];
            int k = r.Next(1, 4);
            int c = r.Next(4, 7);
            int array = r.Next(0, 3);
            int marker;
            marker = c;
            int addition = caveRepresentation[n - 1, c];
            if (addition == 0)
            {             
                marker = 4;
                addition = caveRepresentation[n - 1, marker];
            }
            previousvalues.Add(addition);
            values = getRoomConnections(addition);
            while (values[1] == 0)
            {
                while (c == marker)
                {
                    c = r.Next(4, 7);
                }
                addition = temp = caveRepresentation[n - 1, c];
                values = getRoomConnections(addition);
            }
            previousvalues.Add(addition);
            wumpus.Add(addition);
            for (int i = 0; i < k; i++)
            {
                if (i == 0)
                {
                    values = getRoomConnections(addition);
                    past = caveRepresentation[addition - 1, c];
                    if (past == 0)
                    {                        
                        marker = 4;
                        past = caveRepresentation[addition - 1, marker];
                    }
                    while (past == n)
                    {
                            c = r.Next(4, 7);
                            marker = c;
                            past = caveRepresentation[addition - 1, c];
                            while (past == 0)
                            {
                                while (c == marker || c == 4)
                                {
                                    c = r.Next(5, 7);
                                    past = caveRepresentation[addition - 1, c];
                                }
                        }
                    }
                    previousvalues.Add(past);
                    wumpus.Add(past);
                }
                else
                {                    
                    past = temp = caveRepresentation[past-1, c];
                    if (past == 0)
                    {
                        c = 4;
                        past = temp = caveRepresentation[test - 1, c];
                    }
                    array = r.Next(0, 3);
                    values = getRoomConnections(past);   
                    if (values[1] == 0)
                    {
                        i--;
                        continue;                       
                    }
                    int check = 0;
                    while (check<previousvalues.Count)
                    {
                        if (past == Convert.ToInt32(previousvalues[check]))
                        {
                            c = r.Next(4, 7);
                            marker = c;
                            past = caveRepresentation[past - 1, c];
                            while (past == 0)
                            {
                                while (c == marker || c == 4)
                                {
                                    c = r.Next(5, 7);
                                    past = caveRepresentation[past - 1, c];
                                    check = 0;
                                }
                            }
                        }
                        check++;
                    }
                    test = past;
                    previousvalues.Add(past);
                    wumpus.Add(past);
                }
                
                //takes in current wumpus room number, returns rooms that the wumpus moves to. 
            }
            return wumpus;
        }
    
        public void start(int n)
        {
            String[] temp = new String[30];
            String[] reallybro = new String[7];
            int[] values = new int[7];
            char delimiter = ',';
            if (n == 1)
            {
                temp = System.IO.File.ReadAllLines(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\cave 1.txt");
            }
            else if (n == 2)
            {
                temp = System.IO.File.ReadAllLines(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\cave 2.txt");
            }
            else if (n == 3)
            {
                temp = System.IO.File.ReadAllLines(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\cave 3.txt");
            }
            else if (n == 4)
            {
                temp = System.IO.File.ReadAllLines(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\cave 4.txt");
            }
            else if (n == 5)
            {
                temp = System.IO.File.ReadAllLines(@"C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\cave 5.txt");
            }
                for (int i = 0; i < 30; i++)
                {
                    reallybro = temp[i].Split(delimiter);
                    for (int j = 0; j < 7; j++)
                    {                        
                        caveRepresentation[i, j] = Convert.ToInt32(reallybro[j]);
                    }
                }
            }
        }
    }
