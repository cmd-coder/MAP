using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAP;

namespace UnitTestMAP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethodSadMood()
        {
            Program MoodAnalyzer = new Program("I am in sad Mood :(");
            string mood = "sad";
            string mood2 = MoodAnalyzer.moodAnalyser();
            Assert.AreEqual(mood, mood2);
        }

        [TestMethod]
        public void TestMethodAnyMood()
        {
            Program MoodAnalyzer = new Program("I am in Any Mood :)");
            string mood = "happy";
            string mood2 = MoodAnalyzer.moodAnalyser();
            Assert.AreEqual(mood, mood2);
        }

        [TestMethod]
        public void TestMethodNullMood()
        {
            /*Program MoodAnalyzer = new Program();
            string mood = "Happy";
            string mood2 = MoodAnalyzer.moodAnalyser();
            Assert.AreEqual(mood, mood2);*/
            string mood = null;
            Program MoodAnalyser = new Program(mood);
            try
            {
                string mood2 = MoodAnalyser.moodAnalyser();
            }
            catch(MoodAnalysisException mae)
            {
                Assert.AreEqual("Mood should not be null", mae.Message);
            }
        }
        
        [TestMethod]
        public void TestMethodEmptyMood()
        {
            string mood = string.Empty;
            Program MoodAnalyser = new Program(mood);
            try
            {
                string mood2 = MoodAnalyser.moodAnalyser();
            }
            catch(MoodAnalysisException mae)
            {
                Assert.AreEqual("Mood should not be empty", mae.Message);
            }
        }
    }
}
