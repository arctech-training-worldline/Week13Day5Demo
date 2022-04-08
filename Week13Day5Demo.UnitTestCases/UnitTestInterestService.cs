using NUnit.Framework;
using Week13Day5Demo.BusinessLogic;

namespace Week13Day5Demo.UnitTestCases
{
    public class UnitTestInterestService
    {
        //[SetUp]
        //public void Setup()
        //{
        //}

        [Test]
        [TestCase(1000, 1, 15, 150)]
        [TestCase(1000, 3, 0, 0)]
        [TestCase(1000, 10, 1500, 150000)]
        public void TestSimpleInterest(double p, int n, double r, int expectedValue)
        {
            var interestService = new InterestService();

            var interest = interestService.SimpleInterest(p, n, r);

            Assert.AreEqual(expectedValue, interest);
        }

        [Test]
        public void TestEmi()
        {
            var interestService = new InterestService();
            
            var expectedValue = 487;

            var emi = interestService.GetEmi(10000, 2, 15.5);

            Assert.AreEqual(expectedValue, emi);
        }
    }
}