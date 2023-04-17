using Google.Cloud.Translation.V2;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TradutorApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var client = TranslationClient.CreateFromApiKey(Utility.apiKey);
            var response = client.TranslateText("קוד הדגמה", LanguageCodes.Hebrew, LanguageCodes.Portuguese);
            Console.WriteLine(response.TranslatedText);
        }
    }
}
