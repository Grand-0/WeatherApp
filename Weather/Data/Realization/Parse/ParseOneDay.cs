using System.IO;
using System.Net;
using WeatherAppWPF.Data.GhostEntity.Intefaces;
using WeatherAppWPF.Data.RequestPath;

namespace WeatherAppWPF.Data.Parse
{
    public class ParseOneDay : IParse<OneDay>
    {
        public string GetResponce(OneDay Path)
        {
            string parseString = "";
            string path = $"{Path.FirstToken}{Path.CityName}{Path.SecondToken}{Path.RequestKey}";

            HttpWebRequest request = (HttpWebRequest)WebRequest.CreateHttp(path);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    parseString = reader.ReadToEnd();
                }
            }

            response.Close();
            return parseString;
        }
    }
}
