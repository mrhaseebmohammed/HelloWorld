using System;
using Xunit;
using HelloWorldAPI;

namespace HelloWorldAPITests
{
    public class HelloWorldAPIValuesControllerTest
    {

        //TODO Add build command to copy over localization folder to keep files in sync with test project.

        [Fact]
        public void ShouldReturnHelloWorld()
        {
            var controller = new HelloWorldAPI.Controllers.TranslateController();

            var result = controller.Get("helloWorld");

            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void ShouldReturnErrorCode()
        {
            var controller = new HelloWorldAPI.Controllers.TranslateController();

            var result = controller.Get("SuperCallousFragileMysticHexedByHalitosis");

            Assert.Equal("-1", result);
        }
    }
}
