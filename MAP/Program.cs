using System;

namespace MAP
{
    public class Program
    {
        string message = "";
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mood Analyser Program");
        }

        public Program()
        {

        }

        public Program(string message)
        {
            this.message = message;
        }

        public string moodAnalyser()
        {
            try
            {
                if(message.Equals(string.Empty))
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY_MESSAGE, "Mood should not be empty");
                }
                if (message.Contains("sad"))
                    return "sad";
                else
                    return "happy";
            }
            catch(NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL_MESSAGE, "Mood should not be null");
            }
        }
    }
}
