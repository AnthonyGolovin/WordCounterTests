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
            Assert.AreEqual(2,newRepeatCounter.UserInput("QERQGFEWR34355GVDFGBDDGFfgegdfdfg 555 5 555 5", "5"));

        } 
        
        [TestMethod]
        public void UserInput_TestContiniousString_ReturnsNumberOfDuplicates()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter();
            Assert.AreEqual(0,newRepeatCounter.UserInput("johnjohnjohnjohn", "john"));
            Assert.AreEqual(1,newRepeatCounter.UserInput("bosssauceboss wow boss", "boss"));
        }

        [TestMethod]
        public void UserInput_DoubleSpace_ReturnsNumberOfDuplicates()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter();
            Assert.AreEqual(2,newRepeatCounter.UserInput("log  log  dog", "log"));
            Assert.AreEqual(1,newRepeatCounter.UserInput("t h i n g t,h,i,n,g  thing  gniht", "thing"));
        }

        [TestMethod]
        public void UserInput_Punctuation_ReturnsNumberOfDuplicates()
        {
            RepeatCounter newRepeatCounter = new RepeatCounter();
            Assert.AreEqual(1,newRepeatCounter.UserInput("Gus got off the bus, but he actually didnt", "bus"));
            Assert.AreEqual(1,newRepeatCounter.UserInput("There once was a barnacle so ugly that everyone died, the end.", "end"));
        }
        
    }
}