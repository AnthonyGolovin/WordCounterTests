using Microsoft.VisualStudio.TestTools.UnitTesting;
using WordCounterLogic;
// using WordCounterMain;

namespace WordCounterLogic.Tests
{
    [TestClass]
    public class WordCounterTest
    {
        [TestMethod]
        public void UserInput_CountsWordDuplicates_ReturnsNumberOfDuplicates()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter();
            Assert.AreEqual(2,newRepeatCounter.UserInput("pew pew words", "pew"));
            Assert.AreEqual(3,newRepeatCounter.UserInput("yung thug was yung when he was yung", "yung"));
        }

        [TestMethod]
        public void UserInput_TestCapitalLetters_ReturnsDuplicatesNumber()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter();
            Assert.AreEqual(5,newRepeatCounter.UserInput("long john silvers LONG loNG LonG LoNg", "long"));
            Assert.AreEqual(4,newRepeatCounter.UserInput("pong pong pong long tong pong", "PONG"));
            Assert.AreEqual(2,newRepeatCounter.UserInput("QERQGFEWR34355GVDFGBDDGFfgegdfdfg", "5"));

        } 
        
        [TestMethod]
        public void UserInput__ReturnsNumberOfDuplicates()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter();
            Assert.AreEqual(2,newRepeatCounter.UserInput("pew pew words", "pew"));
            Assert.AreEqual(3,newRepeatCounter.UserInput("yung thug was yung when he was yung", "yung"));
        }
        
    }
}