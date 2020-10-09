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
            string []array = new string[] { "" };
            array = message.Split(" ");
            string mood = "";
            /*if(message=="I am in Sad Mood :(")
                mood = "Sad";
            else if (message == "I am in Happy Mood :)")
                mood = "Happy";*/
            try
            {
                mood = array[3];
            }
            catch(IndexOutOfRangeException e)
            {
                mood = "Happy";
            }
            return mood;
        }
    }
}
