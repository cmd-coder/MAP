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
            string mood = "";
            if(message=="I am in Sad Mood :(")
                mood = "Sad";
            if (message == "I am in Happy Mood :)")
                mood = "Happy";
            return mood;
        }
    }
}
