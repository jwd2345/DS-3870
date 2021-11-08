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
        [FunctionName("getVehicle")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string strCodeName = req.Query["getVehicle"];
    
            DataSet dsgetVehicle = new DataSet();
            string strConnection = "Server=tcp:myserver.database.windows.net,1433;Database=myDataBase;UserID=mylogin@myserver;Password=myPassword;Trusted_Connection=False;Encrypt=True;
            {
                using (SqlConnection congetVehicle = new SqlConnection(strConnection))
                using (SqlCommand comgetVehicle = new SqlCommand(strQuery, congetVehicle))
                {
                    SqlParameter par = new SqlParameter("parVehicle", SqlDbType.VarChar);
                    parVehicle.Value = strVehicle;
                    comgetVehicle.Parameters.Add(parVehicle);

                    SqlDataAdapter daSpyAgencies = new SqlDataAdapter(comgetVehicle);
                    daSpyAgencies.Fill(dsgetVehicle;
                    return new OkObjectResult(JsonConvert.SerializeObject(dsgetVehicle.Tables[0]));
                }
            }
            catch (Exception ex)
            {
                return new OkObjectResult(ex.Message.ToString());
            }


            string name = req.Query["name"];

            string requestBody = await new StreamReader(req.Body).ReadToEndAsync();
            dynamic data = JsonConvert.DeserializeObject(requestBody);
            name = name ?? data?.name;

            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";
            {
                Vehicle Toyota = new Vehicle("VIN-78re540jk93j", "Ford", "Maverick", "2022", );
                Vehicle Toyota = new Vehicle("VIN-VH5820req", "Toyota", "Prius", "2010",);
                Vehicle Ford = new Vehicle("VIN-MIL839", "Mercedes", "UniMog","1990", );
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
