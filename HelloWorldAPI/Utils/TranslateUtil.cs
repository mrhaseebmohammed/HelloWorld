namespace HelloWorldAPI.Utils
{
    public class Utils
    {
        public static bool IsValidCulture(string Culture)
        {
            return Culture == "en-US" || Culture == "es-ES";
        }
    }
}