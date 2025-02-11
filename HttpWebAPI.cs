using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Azure.Functions.Worker;
using Microsoft.Extensions.Logging;

namespace Company.Function
{
    public class HttpWebAPI
    {
        private readonly ILogger<HttpWebAPI> _logger;

        public HttpWebAPI(ILogger<HttpWebAPI> logger)
        {
            _logger = logger;
        }

        [Function("HttpWebAPI")]
        public IActionResult Run([HttpTrigger(AuthorizationLevel.Anonymous, "get", "post")] HttpRequest req)
        {
            _logger.LogInformation("C# HTTP trigger function processed a request.");
            return new OkObjectResult("Welcome to Azure Functions!");
        }
    }
}
