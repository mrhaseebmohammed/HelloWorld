using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    public class TranslateController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get(string word)
        {

            // TODO Replace with in-memory caching of localized file.
            // TODO Determine user's culture and return translation based on that.

            JObject translation = JObject.Parse(System.IO.File.ReadAllText("./Localization/en-US.json"));

            if (translation[word] == null)
            {
                return "-1";
            }
            else
            {
                return (string)translation[word];
            }
        }

    }
}
