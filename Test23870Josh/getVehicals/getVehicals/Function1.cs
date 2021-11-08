using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using DocumentFormat.OpenXml.Math;

namespace getVehicals
{
    public static class Function1
    {
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public int Model { get; set; }
            public double Year { get; set; }
            public double MPL { get; set; }

            public Vehicle(string strBrand, string strModel, int intYear, double dblMPG)

            {
                VIN = strVIN;
                Make = strMake;
                Model = strModel;
                Year = intYear;
                MPL = dblMPL;

            }
        [FunctionName("Function1")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";
            {
                Vehicle Toyota = new Vehicle("Toyota", "Land Cruiser", "2020", "26");
                Vehicle Toyota = new Vehicle("Toyota", "Tundra", "2018", "20");
                Vehicle Ford = new Vehicle("Ford", "Ranger", "2021", "19");
            }
             private class Vehicle
        {
            public string VIN { get; set; }
            public string Make { get; set; }
            public int Model { get; set; }
            public double Year { get; set; }
            public double MPL { get; set; }

            public Vehicle(string strBrand, string strModel, int intYear, double dblMPG)

            {
                VIN = strVIN;
                Make = strMake;
                Model = strModel;
                Year = intYear;
                MPL = dblMPL;

            }
        }
            return new OkObjectResult(responseMessage);
        }
    }
}
