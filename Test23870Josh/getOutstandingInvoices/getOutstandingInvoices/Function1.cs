using System;
using System.IO;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.AspNetCore.Http;
using Microsoft.Extensions.Logging;
using Newtonsoft.Json;
using System.Data.SqlClient;
using System.Data;

namespace getOutstandingInvoices
{
    public static class Function1
    {
        //Server=tcp:myserver.database.windows.net,1433;Database=myDataBase;UserID=mylogin@myserver;Password=myPassword;Trusted_Connection=False;Encrypt=True;
        [FunctionName("getOutstandingInvoices")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", Route = null)] HttpRequest req,
            ILogger log,
            SqlConnection conCustomers)
        {
            log.LogInformation("C# HTTP trigger on getOutstandingInvoices");

            string name = req.Query["name"];
            DataSet dsCustomers = new DataSet();
            string strConnection = "ConnectionString";
            string strQuery = "Select * FROM tblInvoices.CustomerID = tblCustomers.CustomerID, tblInvoices WHERE InvoiceNumber = @parInvoiceNumber, Amount = @parAmount, Paid = @parPaid";
            bool blnfound = true;
            try
            {
                using (SqlConnection comCustomers = new SqlConnection(strConnection)) ;
                using (SqlCommand comCustomers = new SqlCommand(strQuery, conCustomers)) ;

                {
                    SqlParameter parCustomerName = new SqlParameter("parName", SqlDbType.VarChar);
                    parCustomerName.Value = strCustomerName;
                    comCustomers.Parameters.Add(parCustomerName);

                    SqlParameter parMinInvoiceValue = new SqlParameter("parMinInvoiceValue", SqlDbType.Decimal(12, 2));
                    parMinInvoiceValue.Value = strMinInvoiceValue;
                    comInvoices.Parameters.Add(parMinInvoiceValue);

                }
            } 
            catch (Exception ex)
            {
                return new OkObjectResult(ex.Message.ToString());
            }
            if (blnfound == false);
            {
                return new OkObjectResult = (dsCustomer.Tables[0]) ;
            }
        } else 

            return new OkObjectResult = "Employees Not Found"; 
            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
        }
    }
}
