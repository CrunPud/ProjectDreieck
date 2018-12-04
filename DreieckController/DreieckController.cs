using System.Configuration;

namespace DreieckController
{
    public class DreieckController
    {
        private readonly string _hostUrl;
        
        public DreieckController()
        {
            _hostUrl = ConfigurationManager.AppSettings["DreieckHostUrl"];
        }


    }
}
