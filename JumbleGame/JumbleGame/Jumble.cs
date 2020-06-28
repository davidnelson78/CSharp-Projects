using System;

namespace JumbleGame
{
    internal class Jumble
    {
        private string[] arrayWord = { "cranberries", "friendship", "december", "conservation", "vacation", "invitation", "elephant", "unique", "christmas", "kentucky" };
        private char[] displayWord;
        private string hiddenWord;

        public string HiddenWord
        {
            get { return hiddenWord; }
        }

        public Jumble()
        {
            GenerateRandom();
            ScrambleWord();
        }

        public bool CompareResult(string guess)
        {
            bool value;
            if (guess == hiddenWord)
                value = true;
            else
                value = false;
            return value;
        }

        public string DisplayScramble()
        {
            string returnvalue = null;

            for (int i = 0; i < displayWord.Length; i++)
                returnvalue = returnvalue + displayWord[i];
            return returnvalue;
        }

        public void GenerateRandom()
        {
            int number;
            Random generate = new Random();
            number = generate.Next(arrayWord.Length);
            hiddenWord = arrayWord[number];
        }

        public void ScrambleWord()
        {
            int random;
            char temp;
            Random randObj = new Random();
            displayWord = new char[hiddenWord.Length];
            for (int i = 0; i < hiddenWord.Length; i++)
            {
                do
                    random = randObj.Next(hiddenWord.Length);
                while (displayWord[random] != 0);

                temp = hiddenWord[i];
                displayWord[random] = temp;
            }
        }
    }
}