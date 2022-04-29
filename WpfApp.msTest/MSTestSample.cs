using Microsoft.VisualStudio.TestTools.UnitTesting;
using SUT = WpfApp;

//https://docs.microsoft.com/en-us/visualstudio/test/using-microsoft-visualstudio-testtools-unittesting-members-in-unit-tests?view=vs-2022

//https://docs.microsoft.com/en-us/dotnet/core/testing/

namespace WpfApp.msTest
{
    [TestClass]
    public class WpfAppTest
    {
        [TestMethod]
        [DataTestMethod]
        [DataRow(20, 30, 50)]
        [DataRow(30, 30, 60)]
        [TestProperty("Category", "PlateTests")]
        public void SampleTestCase(int x, int y, int z)
        {
            var sut = new Controllers.PlateController();
            var r = sut.AddNums(x, y);
            Assert.AreEqual(r, z); 
        }
        [TestMethod]
        [TestProperty("Category","WellTests")]
        public void SampleTestCase2()
        {
           
        }
    }
}
