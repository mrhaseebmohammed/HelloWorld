using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using HelloWorldAPI.Models;
using HelloWorldAPI.Utils;

namespace HelloWorldAPI.Controllers
{
    [Route("api/[controller]")]
    public class TranslateController : Controller
    {
        // GET api/values
        [HttpGet]
        public string Get(TranslateModel wordToTranslate)
        {
            // TODO Replace with in-memory caching of localized file.
            // TODO Determine user's culture and return translation based on that.
            // Although to be useful across multiple consumers, requesting the culture would be best.
            // TODO Request culture on initial poke to API. Put culture in JWT.
            // TODO Add token/JWT to API.

            if (Utils.Utils.IsValidCulture(wordToTranslate.Culture))
            {
                JObject translation = JObject.Parse(System.IO.File.ReadAllText("./Localization/" + wordToTranslate.Culture + ".json"));

                if (translation[wordToTranslate.Word] == null)
                {
                    //TODO Log error regarding missing/invalid word.
                    return "-1";
                }
                else
                {
                    return (string)translation[wordToTranslate.Word];
                }
            }
            else
            {
                // TODO Log error regarding missing/invalid culture.
                return null;
            }
        }

    }
}
