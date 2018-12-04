using System.Configuration;
using RestSharp;

namespace DreieckController
{
    public class Client
    {
        private readonly string _hostUrl;
        private readonly string _serviceCode;
        
        public Client()
        {
            _hostUrl = ConfigurationManager.AppSettings["DreieckHostUrl"];
            _serviceCode = ConfigurationManager.AppSettings["DreieckServiceCode"];
        }

        /// <summary>
        /// Returns a short description of a triangle
        /// </summary>
        /// <param name="sides">The lengths of the sides of the triangle. Should have length of 3.</param>
        /// <returns></returns>
        public string GetTriangleDescription(int[] sides)
        {
            if (sides.Length != 3)
                return $"A triangle has 3 sides, not {sides.Length} you dummy";

            var client = new RestClient(_hostUrl);

            var request = new RestRequest("api/Dreieck", Method.GET);
            request.AddParameter("code", _serviceCode);
            request.AddParameter("sidea", sides[0]);
            request.AddParameter("sideb", sides[1]);
            request.AddParameter("sidec", sides[2]);

            return client.Execute(request).Content;
        }
    }
}
