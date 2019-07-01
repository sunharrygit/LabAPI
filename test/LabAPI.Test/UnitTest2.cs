using System;
using Xunit;
using LabAPI.Controllers;


namespace LabAPI.Test
{
    public class UnitTest2
    {
        LabsController controller = new LabsController();
        [Fact]
        public void GetReturnsMyName()
        {
         var returnValue = controller.Get(1);
            Assert.Equal("It is my controller", returnValue.Value);    
        }

        [Fact]
        public void GetReturnsHello()
        {
            string s = "Harry";
         var returnValue = controller.Get(s);
            Assert.Equal("Hello "+s+", welcome to Harry's Lab!", returnValue.Value);  
        }

        [Fact]
        public void Test1()
        {

        }
    }
}
