namespace TriviaGameApp
{
    internal class QuestionUnit
    {
        private string m_Answers;
        private string m_CorrectAnswer;
        private string m_Explanation;
        private string m_Question;

        public string Answer
        {
            get { return m_Answers; }
            set { m_Answers = value; }
        }

        public string CorrectAnswer
        {
            get { return m_CorrectAnswer; }
            set { m_CorrectAnswer = value; }
        }

        public string Explanation
        {
            get { return m_Explanation; }
            set { m_Explanation = value; }
        }

        public string Question
        {
            get { return m_Question; }
            set { m_Question = value; }
        }
    }
}