namespace getOutstandingInvoices
{
    public static class Function1Base
    {
        //Server=tcp:myserver.database.windows.net,1433;Database=myDataBase;UserID=mylogin@myserver;Password=myPassword;Trusted_Connection=False;Encrypt=True;
        [FunctionName("getOutstandingInvoices")]
        public static async Task<IActionResult> Run(
            [HttpTrigger(AuthorizationLevel.Function, "get", , Route = null)] HttpRequest req,
            ILogger log)
        {
            log.LogInformation("C# HTTP trigger function processed a request.");

            string name = req.Query["name"];

            string strConnection = "ConnectionString";
            string strQuery = "Select * FROM tblCustomers, tblInvoices";
            SqlConnection conCustomers = new SqlConnection(strConnection);


            string responseMessage = string.IsNullOrEmpty(name)
                ? "This HTTP triggered function executed successfully. Pass a name in the query string or in the request body for a personalized response."
                : $"Hello, {name}. This HTTP triggered function executed successfully.";

            return new OkObjectResult(responseMessage);
        }
    }
}