using System.IO;

namespace TriviaGameApp
{
    internal class FileIO
    {
        private StreamWriter fil;

        public void DisplayFile()
        {
            string filePath = "Questions.txt";
            //thought of using try/catch/finally here, but no matter what
            //I want the file to be recreated in case of corruption or unintended editing

            File.Delete(filePath);                  //delete the file
            fil = new StreamWriter(filePath);       //start writing to the new file
            fil.WriteLine("1) December 17, 1903, the Wright Brothers made their first flight, in what North Carolina town?");
            fil.WriteLine("Columbus,Pittsburgh,Kitty Hawk,Khitomer");
            fil.WriteLine("C");
            fil.WriteLine("Kitty Hawk is where the historic flight took place.");
            fil.WriteLine("2) In 1914 President Wilson denounced what material object as a symbol of \"the arrogance of wealth\"?");
            fil.WriteLine("Electricity,Automobile,Telephone,Gold");
            fil.WriteLine("B");
            fil.WriteLine("The automobile is what President Wilson denounced as the symbol of the arrogance of wealth.");
            fil.WriteLine("3) Which famous person was stabbed to death on March 15, 44 B.C.?");
            fil.WriteLine("Zeus,Batman,Ezio Auditore de Firenze,Julius Caesar");
            fil.WriteLine("D");
            fil.WriteLine("Julius Caesar was stabbed to death on March 15, 44 B.C.");
            fil.WriteLine("4) What was the name of the first permanent English settlement?");
            fil.WriteLine("Plymouth Rock,Jamestown,Washington D.C.,New York");
            fil.WriteLine("B");
            fil.WriteLine("Jamestown, VA was the first permanent English settlement, settled on May 14, 1607.");
            fil.WriteLine("5) Who was the first person to suggest Daylight Savings Times?");
            fil.WriteLine("Benjamin Franklin,George Washington,John Hancock,Abraham Lincoln");
            fil.WriteLine("A");
            fil.WriteLine("Benjamin Franklin first mentioned Daylight Savings Time in 1784.");
            fil.Close();
        }

        public void ParseAnswers(string line, ref string[] fields)
        {
            int startPos = 0;
            int stopPos = 0;

            for (int index = 0; index < 4; index++)
            {
                stopPos = line.IndexOf(',', startPos); //the comma is used as a delimiter
                if (stopPos == -1)
                    stopPos = line.Length;
                fields[index] = line.Substring(startPos, stopPos - startPos);
                startPos = stopPos + 1;
            }
        }
    }
}