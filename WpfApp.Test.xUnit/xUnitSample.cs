using System;
using Xunit;
using SUT = WpfApp.Controllers;


//https://xunit.net/
//https://docs.microsoft.com/en-us/dotnet/core/testing/unit-testing-code-coverage?tabs=windows
//https://xunit.net/docs/comparisons?msclkid=888b3625c6d711ec92e4e60e43f96cda

namespace WpfApp.Test.xUnit
{
    public class xUnitSample
    {
        private SUT.PlateController ctl;
        xUnitSample()
        {
            ctl = new SUT.PlateController();
        }
        [Theory]
        [InlineData(2,2,4)]
        []
        public void InputListToTestCase(int x, int y, int z)
        {
            Assert.Equal(z, ctl.AddNums(x, y));
            
        }
    }
}
