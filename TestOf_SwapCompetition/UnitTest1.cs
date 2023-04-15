using Swap_Competition;
namespace TestOf_SwapCompetition
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void ReturnTrueifCharactersAreEqual()
        {

            SwapString swapString = new SwapString();
            bool word= swapString.AreEqual("noon", "moon");
            Assert.IsTrue(word);
        }
        [TestMethod]
        public void GiveAnotherStrings()
        {
            SwapString swapString = new SwapString();
            bool word1 = swapString.AreEqual("trap", "part");
            Assert.IsTrue(word1);
        }
    }
}