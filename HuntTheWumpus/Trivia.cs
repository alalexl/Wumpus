using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HuntTheWumpus
{
    public class Trivia
    {
        private static int qs = 100;
        private String[] questions = new String[qs];
        private String[] possibleAnswers = new String[qs];
        private String[] correctAnswer;
        private Boolean[] questionsAsked = new Boolean[qs];
        private int number;
        private Boolean correct;
        Random rand = new Random();

        public Trivia()
        {
            questions = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\\\SampleQuestion.txt");
            possibleAnswers = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\\\SampleAnswer.txt");
            correctAnswer = System.IO.File.ReadAllLines("C:\\Users\\Alex\\Documents\\Visual Studio 2010\\Projects\\WumpusTest\\WumpusTest\\\\correctAnswers.txt");

        }

        public String getQuestion()
        {
            number = rand.Next(0, 99);
            if (questionsAsked[number] == false)
            {
                questionsAsked[number] = true;

                return questions[number];
            }
            else return getQuestion();
        }
        public String getcorrectAnswer()
        {
            return correctAnswer[number];

        }
        public String getAnswer1()
        {
            return possibleAnswers[number * 4];
        }
        public String getAnswer2()
        {
            return possibleAnswers[number * 4 + 1];
        }
        public String getAnswer3()
        {
            return possibleAnswers[number * 4 + 2];
        }
        public String getAnswer4()
        {
            return possibleAnswers[number * 4 + 3];
        }
        public Boolean getCorrect()
        {
            return correct;
        }
        public void setCorrect(Boolean b)
        {
            correct = b;
        }
    }
}