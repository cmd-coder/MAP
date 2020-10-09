using System;

namespace MAP
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to mood Analyser Program");
        }

        public string moodAnalyser(string message)
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
