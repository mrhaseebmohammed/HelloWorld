using System;
using HelloWorldAPI.Models;

namespace HelloWorldAPI.Utils
{
    public class Utils
    {
        public static bool IsValidCulture(string Culture)
        {
            return Culture == "en-US" || Culture == "es-ES";
        }

        public static void WriteToConsoleDB(string wordToWrite, WriteToConfig config)
        {
            if (config.TargetConsole)
            {
                Console.WriteLine(wordToWrite);
            }

            if (config.TargetDB)
            {
                // TODO Write to DB.
            }
        }
    }
}