using NUnit.Framework;
using SUT = WpfApp.Controllers; // System Under Test 

//https://docs.nunit.org/
namespace WpfApp.Test.nUnit
{
    public class Tests
    {
        private Controllers.PlateController ctl;

        [SetUp]
        public void Setup()
        {
            ctl = new SUT.PlateController();
        }

        [Category("nUnit.Plates")]
        [TestCase(10,20,30)]
        [TestCase(2,2,4)]
        public void MultiArgTest(int x, int y, int z)
        {
            var r = ctl.AddNums(x, y);
            Assert.AreEqual(r, z);
        }
        [TestCaseSource(nameof(DivideCases))]
        [Category("nUnit.Plates")]
        public void DivideTest(int n, int d, int q)
        {
            Assert.AreEqual(q, n / d);
        }

        static object[] DivideCases =
        {
        new object[] { 12, 3, 4 },
        new object[] { 12, 2, 6 },
        new object[] { 12, 4, 3 }
    };
    }
}