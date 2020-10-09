using Microsoft.VisualStudio.TestTools.UnitTesting;
using MAP;

namespace UnitTestMAP
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Program MoodAnalyzer = new Program();
            string mood = "Sad";
            string mood2 = MoodAnalyzer.moodAnalyser("I am in Sad Mood");
            Assert.AreEqual(mood, mood2);
        }

        [TestMethod]
        public void TestMethod2()
        {
            Program MoodAnalyzer = new Program();
            string mood = "Happy";
            string mood2 = MoodAnalyzer.moodAnalyser("I am in Happy Mood");
            Assert.AreEqual(mood, mood2);
        }
    }
}
