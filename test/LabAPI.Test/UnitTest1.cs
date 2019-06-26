using System;
using Xunit;
using LabAPI.Controllers;


namespace LabAPI.Test
{
    public class UnitTest1
    {
        ValuesController controller = new ValuesController();
        [Fact]
        public void GetReturnsMyName()
        {
         var returnValue = controller.Get(1);
            Assert.Equal("Sun Harry", returnValue.Value);
    
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
