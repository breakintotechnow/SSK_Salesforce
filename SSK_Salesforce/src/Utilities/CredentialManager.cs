using Microsoft.VisualStudio.TestPlatform.CommunicationUtilities.Resources;
using Newtonsoft.Json;
using OpenQA.Selenium.BiDi.Modules.Script;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSK_Salesforce.src.Utilities
{

    public class CredentialManager
    {
        public string Url { get; set; }
        public string LoginName { get; set; }
        public string Password { get; set; }

        public string LT_USERNAME { get; set; }
        public string LT_ACCESS_KEY { get; set; }

        public static CredentialManager LoadCredentials()
        {

            //string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //C:\Users\Selenium\source\repos\SSK_Salesforce\SSK_Salesforce\src\Utilities\Resources\testData.json
            //string filePath = Path.Combine(baseDirectory, @"SSK_Salesforce\src\Utilities\Resources\testData.json");

            //string filePath = @"SSK_Salesforce\src\Utilities\Resources\details.json";
            //Console.WriteLine("File Path Found: " + filePath);

            //var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Resources", "details.json");
            // Console.WriteLine("File Path Found: " + filePath);
            // details.json file not found: C: \Users\Selenium\source\repos\SSK_Salesforce\SSK_Salesforce\bin\Debug\net8.0\Resources\details.json


            //var filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "details.json");
            //Console.WriteLine("File Path Found: " + filePath);
            // details.json file not found: C: \Users\Selenium\source\repos\SSK_Salesforce\SSK_Salesforce\bin\Debug\net8.0\details.json


            //   string baseDirectory = AppDomain.CurrentDomain.BaseDirectory;
            //     string filePath = Path.Combine(baseDirectory, @"SSK_Salesforce\src\Utilities\Resources\testData.json");
            // Console.WriteLine("File Path Found: " + filePath);
            // C: \Users\Selenium\source\repos\SSK_Salesforce\SSK_Salesforce\bin\Debug\net8.0\details.json

            string filePath = Path.Combine(AppDomain.CurrentDomain.BaseDirectory,
                "src", "Utilities", "Resources", "details.json");
            Console.WriteLine("File Path Found: " + filePath);



            if (!File.Exists(filePath))
            {
                throw new FileNotFoundException($"details.json file not found: {filePath}");
            }

            string json = File.ReadAllText(filePath);
            return JsonConvert.DeserializeObject<CredentialManager>(json);
        }
    }
}