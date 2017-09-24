using System;
using Xunit;
using HelloWorldAPI;
using HelloWorldAPI.Models;
using Microsoft.Extensions.Options;

namespace HelloWorldAPITests
{
    public class HelloWorldAPIValuesControllerTest
    {
        //TODO Add build command to copy over localization folder to keep files in sync with test project.

        [Fact]
        public void ShouldReturnHelloWorldInEnglish()
        {
            WriteToConfig writeToConfig = new WriteToConfig();
            writeToConfig.TargetConsole = false;
            writeToConfig.TargetDB = false;

            IOptions<WriteToConfig> options = Options.Create<WriteToConfig>(writeToConfig);

            var controller = new HelloWorldAPI.Controllers.TranslateController(options);

            TranslateModel wordToTranslate = new TranslateModel();
            wordToTranslate.Culture = "en-US";
            wordToTranslate.Word = "helloWorld";

            var result = controller.Get(wordToTranslate);

            Assert.Equal("Hello World", result);
        }

        [Fact]
        public void ShouldReturnHelloWorldInSpanish()
        {
            WriteToConfig writeToConfig = new WriteToConfig();
            writeToConfig.TargetConsole = false;
            writeToConfig.TargetDB = false;

            IOptions<WriteToConfig> options = Options.Create<WriteToConfig>(writeToConfig);

            var controller = new HelloWorldAPI.Controllers.TranslateController(options);

            TranslateModel wordToTranslate = new TranslateModel();
            wordToTranslate.Culture = "es-ES";
            wordToTranslate.Word = "helloWorld";

            var result = controller.Get(wordToTranslate);

            Assert.Equal("Hola Mundo", result);
        }

        [Fact]
        public void ShouldReturnErrorCode()
        {
            WriteToConfig writeToConfig = new WriteToConfig();
            writeToConfig.TargetConsole = false;
            writeToConfig.TargetDB = false;

            IOptions<WriteToConfig> options = Options.Create<WriteToConfig>(writeToConfig);

            var controller = new HelloWorldAPI.Controllers.TranslateController(options);

            TranslateModel wordToTranslate = new TranslateModel();
            wordToTranslate.Culture = "en-US";
            wordToTranslate.Word = "SuperCallousFragileMysticHexedByHalitosis";

            var result = controller.Get(wordToTranslate);

            Assert.Equal("-1", result);
        }

        [Fact]
        public void ShouldReturnNull()
        {
            WriteToConfig writeToConfig = new WriteToConfig();
            writeToConfig.TargetConsole = false;
            writeToConfig.TargetDB = false;

            IOptions<WriteToConfig> options = Options.Create<WriteToConfig>(writeToConfig);

            var controller = new HelloWorldAPI.Controllers.TranslateController(options);

            TranslateModel wordToTranslate = new TranslateModel();
            wordToTranslate.Culture = "zn-ZN";
            wordToTranslate.Word = "helloWorld";

            var result = controller.Get(wordToTranslate);

            Assert.Equal(null, result);
        }
    }
}
