using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace HuntTheWumpus
{
    using System.Data;

    public class HighScore
    {
        HighScore[] highScoreValues = new HighScore[10];
        String[] highScoreNames = new String[10];
        public String[,] getHighScoreValues1()
        {
            string[,] stringdata = new string[10, 2];
            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\HuntTheWumpus\\HuntTheWumpus\\highScoreValues1.txt");//File.Open("..\\..\\highScore.txt", FileMode.Open);
           for (int i = 0; i <10; i++)
           {
               string[] temp;
               temp = lines[i].Split(',');
               for(int j = 0; j<temp.Length; j++)
               {
                   stringdata[i, j] = temp[j];   
               }
           }
           return stringdata;
            
           
        }
        public String[,] getHighScoreValues2()
        {
            string[,] stringdata = new string[10, 2];
            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\HuntTheWumpus\\HuntTheWumpus\\highScoreValues2.txt");//File.Open("..\\..\\highScore.txt", FileMode.Open);
            for (int i = 0; i < 10; i++)
            {
                string[] temp;
                temp = lines[i].Split(',');
                for (int j = 0; j < temp.Length; j++)
                {
                    stringdata[i, j] = temp[j];
                }
            }
            return stringdata;
        }
        public String[,] getHighScoreValues3()
        {
            string[,] stringdata = new string[10, 2];
            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\HuntTheWumpus\\HuntTheWumpus\\highScoreValues3.txt");//File.Open("..\\..\\highScore.txt", FileMode.Open);
            for (int i = 0; i < 10; i++)
            {
                string[] temp;
                temp = lines[i].Split(',');
                for (int j = 0; j < temp.Length; j++)
                {
                    stringdata[i, j] = temp[j];
                }
            }
            return stringdata;
        }
        public String[,] getHighScoreValues4()
        {
            string[,] stringdata = new string[10, 2];
            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\HuntTheWumpus\\HuntTheWumpus\\highScoreValues4.txt");//File.Open("..\\..\\highScore.txt", FileMode.Open);
            for (int i = 0; i < 10; i++)
            {
                string[] temp;
                temp = lines[i].Split(',');
                for (int j = 0; j < temp.Length; j++)
                {
                    stringdata[i, j] = temp[j];
                }
            }
            return stringdata;
        }
        public String[,] getHighScoreValues5()
        {
            string[,] stringdata = new string[10, 2];
            string[] lines = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\HuntTheWumpus\\HuntTheWumpus\\highScoreValues5.txt");//File.Open("..\\..\\highScore.txt", FileMode.Open);
            for (int i = 0; i < 10; i++)
            {
                string[] temp;
                temp = lines[i].Split(',');
                for (int j = 0; j < temp.Length; j++)
                {
                    stringdata[i, j] = temp[j];
                }
            }
            return stringdata;
        }
        public void insertNewScore1(String a, int value)
        {
           Boolean done = false;
           string[,] s = getHighScoreValues1();
           if (Convert.ToInt32(s[0, 1]) < value)
           {
               for (int x = 9; x > 0; x--)
               {
                   s[x, 0] = s[x - 1, 0];
                   s[x, 1] = s[x - 1, 1];
               }
               s[0, 0] = a;
               s[0, 1] = value.ToString();
               done = true;
           }
           else if (done == false)
           {

               for (int i = 1; i < 10; i++)
               {
                   if (Convert.ToInt32(s[i, 1]) < value)
                   {
                       for (int j = 9; j > i; j--)
                       {
                           s[j, 0] = s[j - 1, 0];
                           s[j, 1] = s[j - 1, 1];
                       }
                       s[i, 0] = a;
                       s[i, 1] = value.ToString();
                       break;
                   }

               }
           }
           using (StreamWriter sw = new StreamWriter("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\HuntTheWumpus\\HuntTheWumpus\\highScoreValues1.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    String m = s[i, 0] + "," + s[i, 1];
                    sw.WriteLine(m);
                }
            }
           
        }
        public void insertNewScore2(String a, int value)
        {
            Boolean done = false;
            string[,] s = getHighScoreValues1();
            if (Convert.ToInt32(s[0, 1]) < value)
            {
                for (int x = 9; x > 0; x--)
                {
                    s[x, 0] = s[x - 1, 0];
                    s[x, 1] = s[x - 1, 1];
                }
                s[0, 0] = a;
                s[0, 1] = value.ToString();
                done = true;
            }
            else if (done == false)
            {

                for (int i = 1; i < 10; i++)
                {
                    if (Convert.ToInt32(s[i, 1]) < value)
                    {
                        for (int j = 9; j > i; j--)
                        {
                            s[j, 0] = s[j - 1, 0];
                            s[j, 1] = s[j - 1, 1];
                        }
                        s[i, 0] = a;
                        s[i, 1] = value.ToString();
                        break;
                    }

                }
            }
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\HuntTheWumpus\\HuntTheWumpus\\highScoreValues2.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    String m = s[i, 0] + "," + s[i, 1];
                    sw.WriteLine(m);
                }
            }
        }
        
          public void insertNewScore3(String a, int value)
        {
            Boolean done = false;
            string[,] s = getHighScoreValues1();
            if (Convert.ToInt32(s[0, 1]) < value)
            {
                for (int x = 9; x > 0; x--)
                {
                    s[x, 0] = s[x - 1, 0];
                    s[x, 1] = s[x - 1, 1];
                }
                s[0, 0] = a;
                s[0, 1] = value.ToString();
                done = true;
            }
            else if (done == false)
            {

                for (int i = 1; i < 10; i++)
                {
                    if (Convert.ToInt32(s[i, 1]) < value)
                    {
                        for (int j = 9; j > i; j--)
                        {
                            s[j, 0] = s[j - 1, 0];
                            s[j, 1] = s[j - 1, 1];
                        }
                        s[i, 0] = a;
                        s[i, 1] = value.ToString();
                        break;
                    }

                }
            }
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\HuntTheWumpus\\HuntTheWumpus\\highScoreValues3.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    String m = s[i, 0] + "," + s[i, 1];
                    sw.WriteLine(m);
                }
            }
        }
          public void insertNewScore4(String a, int value)
        {
            Boolean done = false;
            string[,] s = getHighScoreValues1();
            if (Convert.ToInt32(s[0, 1]) < value)
            {
                for (int x = 9; x > 0; x--)
                {
                    s[x, 0] = s[x - 1, 0];
                    s[x, 1] = s[x - 1, 1];
                }
                s[0, 0] = a;
                s[0, 1] = value.ToString();
                done = true;
            }
            else if (done == false)
            {

                for (int i = 1; i < 10; i++)
                {
                    if (Convert.ToInt32(s[i, 1]) < value)
                    {
                        for (int j = 9; j > i; j--)
                        {
                            s[j, 0] = s[j - 1, 0];
                            s[j, 1] = s[j - 1, 1];
                        }
                        s[i, 0] = a;
                        s[i, 1] = value.ToString();
                        break;
                    }

                }
            }
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\HuntTheWumpus\\HuntTheWumpus\\highScoreValues4.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    String m = s[i, 0] + "," + s[i, 1];
                    sw.WriteLine(m);
                }
            }
        }
          public void insertNewScore5(String a, int value)
        {
            Boolean done = false;
            string[,] s = getHighScoreValues1();
            if (Convert.ToInt32(s[0, 1]) < value)
            {
                for (int x = 9; x > 0; x--)
                {
                    s[x, 0] = s[x - 1, 0];
                    s[x, 1] = s[x - 1, 1];
                }
                s[0, 0] = a;
                s[0, 1] = value.ToString();
                done = true;
            }
            else if (done == false)
            {

                for (int i = 1; i < 10; i++)
                {
                    if (Convert.ToInt32(s[i, 1]) < value)
                    {
                        for (int j = 9; j > i; j--)
                        {
                            s[j, 0] = s[j - 1, 0];
                            s[j, 1] = s[j - 1, 1];
                        }
                        s[i, 0] = a;
                        s[i, 1] = value.ToString();
                        break;
                    }

                }
            }
            using (StreamWriter sw = new StreamWriter("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\HuntTheWumpus\\HuntTheWumpus\\highScoreValues5.txt"))
            {
                for (int i = 0; i < 10; i++)
                {
                    String m = s[i, 0] + "," + s[i, 1];
                    sw.WriteLine(m);
                }
            }
        }
       
    }


}
