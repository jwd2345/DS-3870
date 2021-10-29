using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using Newtonsoft.Json;

namespace VehicleBrand
{

    public static class getVehicle
    {
        private class Brand
        {
            public string Name { get; set; }
            public string Address { get; set; }
            public string City { get; set; }
            public string State { get; set; }
            public string ZIP { get; set; }
            public Brand(string strName, string strAddress, string strCity, string strState, string strZIP)
            {
                Name = strName;
                Address = strAddress;
                City = strCity;
                State = strState;
                ZIP = strZIP;

            }
        }
        private class Vehicle
        {
            public string Brand { get; set; }
            public string Model { get; set; }
            public int Year { get; set; }
            public double MPG { get; set; }
            public Vehicle(string strBrand, string strModel, int intYear, double dblMPG)

            {
                Brand = strBrand;
                Model = strModel;
                Year = intYear;
                MPG = dblMPG;

            }
        }

        [FunctionName("getVehicle")]
#pragma warning disable CS1998 // Async method lacks 'await' operators and will run synchronously
        public static async Task<IActionResult> Run(
#pragma warning restore CS1998 // Async method lacks 'await' operators and will run synchronously
        [HttpTrigger(AuthorizationLevel.Anonymous, "get", "post", Route = null)] HttpRequest req,
            ILogger log)
        {
            string strModel = req.Query["Model"];
            log.LogInformation("HTTP trigger on getVehicle processed a request for: " + strModel);
            {
                Vehicle Toyota = new Vehicle("Toyota", "Land Cruiser", "2020", "26");
                Vehicle Toyota = new Vehicle("Toyota", "Tundra", "2018", "20");
                Vehicle Ford = new Vehicle("Ford", "Ranger", "2021", "19");
                Vehicle Ford = new Vehicle("Ford", "Mustang", "2012", "23");
                Vehicle Volkswagen = new Vehicle("Volkswagen", "Jetta", "2022", "29");
                Vehicle Volkswagen = new Vehicle("Volkswagen", "Golf GTI", "2020", "24");

                List<Vehicle> arrVehicle = new List<Vehicle>();
                arrVehicle.Add(Toyota);
                arrVehicle.Add(Ford);
                arrVehicle.Add(Volkswagen);

                List<Vehicle> lstFord = new List<Vehicle>();
                List<Vehicle> lstToyota = new List<Vehicle>();
                List<Vehicle> lstVolkswagen = new List<Vehicle>();
                foreach (Vehicle vehCurrent in arrVehicle)
                {
                    if (vehCurrent.Brand)
                    {
                        lstFord.Add(vehCurrent);
                    }
                    else
                    {
                        lstToyota.Add(vehCurrent);
                        {
                            lstVolkswagen.Add(vehCurrent);
                        }
                    }

                }
            }
        }
