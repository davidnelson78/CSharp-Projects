using System;
using System.IO;

namespace TriviaGameApp
{
    internal class QuestionBank
    {
        private const int NUM_ANSWERS = 4;
        private const int NUM_QUESTIONS = 5;
        private QuestionUnit[] m_Questions = new QuestionUnit[NUM_QUESTIONS];

        public int GetNumberofAnswers
        {
            get { return NUM_ANSWERS; }
        }

        public int GetNumberofQuestions
        {
            get { return NUM_QUESTIONS; }
        }

        public string GETAnswer(int index)
        {
            return m_Questions[index].Answer;
        }

        public string GETCorrectAnswer(int index)
        {
            return m_Questions[index].CorrectAnswer;
        }

        public string GETExplanation(int index)
        {
            return m_Questions[index].Explanation;
        }

        public string GETQuestion(int index)
        {
            return m_Questions[index].Question;
        }

        public void ReadQuestionFile(string path)
        {
            int questionCounter = 0;
            string text = null;
            FileInfo theSourceFile = new FileInfo(@path);

            try
            {
                StreamReader reader = theSourceFile.OpenText();

                text = reader.ReadLine();
                while (text != null)
                {
                    m_Questions[questionCounter] = new QuestionUnit();

                    m_Questions[questionCounter].Question = text;
                    m_Questions[questionCounter].Answer = reader.ReadLine();
                    m_Questions[questionCounter].CorrectAnswer = reader.ReadLine();
                    m_Questions[questionCounter].Explanation = reader.ReadLine();

                    text = reader.ReadLine();
                    questionCounter = questionCounter + 1;
                }
                reader.Close();
            }
            catch (System.IO.IOException e)
            {
                Console.Error.WriteLine(e.Message);
            }
        }
    }
}