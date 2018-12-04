using System;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.Azure.WebJobs;
using Microsoft.Azure.WebJobs.Extensions.Http;
using Microsoft.Azure.WebJobs.Host;

namespace DreieckService
{
    public static class Dreieck
    {
        [FunctionName("Dreieck")]
        public static async Task<HttpResponseMessage> Run([HttpTrigger(AuthorizationLevel.Function, "get", "post", Route = null)]HttpRequestMessage req, TraceWriter log)
        {
            log.Info("C# HTTP trigger function processed a request.");

            double sideA = 0;
            double sideB = 0;
            double sideC = 0;

            try
            {
                // parse query parameter
                sideA = double.Parse(req.GetQueryNameValuePairs()
                    .FirstOrDefault(val => val.Key.Equals("sidea"))
                    .Value);
                sideB = double.Parse(req.GetQueryNameValuePairs()
                    .FirstOrDefault(val => val.Key.Equals("sideb"))
                    .Value);
                sideC = double.Parse(req.GetQueryNameValuePairs()
                    .FirstOrDefault(val => val.Key.Equals("sidec"))
                    .Value);
            }
            catch (Exception ex)
            {
                return req.CreateResponse(HttpStatusCode.BadRequest, $"An error occurred while trying to process your triangle with sides [{sideA}, {sideB}, {sideC}]");
            }

            var response = req.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(new Triangle(new double[] { sideA, sideB, sideC }).GetDescription());

            return response;
        }
    }
}


