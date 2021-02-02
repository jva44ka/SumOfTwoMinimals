using NUnit.Framework;
using SumOfTwoMinimals.App;

namespace SumOfTwoMinimals.Tests
{
    public class Tests
    {
        [Test]
        public void Test132()
        {
            var result = new SumFinder().GetSumOfTwoMinimals(new int[] { 1, 3, 2 });
            Assert.AreEqual(result, 1 + 2);
        }

        [Test]
        public void Test123()
        {
            var result = new SumFinder().GetSumOfTwoMinimals(new int[] { 1, 2, 3 });
            Assert.AreEqual(result, 1 + 2);
        }

        [Test]
        public void Test12345()
        {
            var result = new SumFinder().GetSumOfTwoMinimals(new int[] { 1, 2, 3, 4, 5 });
            Assert.AreEqual(result, 1 + 2);
        }

        [Test]
        public void TestReversed()
        {
            var result = new SumFinder().GetSumOfTwoMinimals(new int[] { 5, 4, 3, 2, 1 });
            Assert.AreEqual(result, 1 + 2);
        }

        [Test]
        public void TestShakedSet()
        {
            var result = new SumFinder().GetSumOfTwoMinimals(new int[] { 5, 10, 3, -3, 2, 4 });
            Assert.AreEqual(result, -3 + 2);
        }

        [Test]
        public void Test3Instead2()
        {
            var result = new SumFinder().GetSumOfTwoMinimals(new int[] { 4, 4, 4, 2, 1, 1 });
            Assert.AreEqual(result, 2);
        }
    }
}