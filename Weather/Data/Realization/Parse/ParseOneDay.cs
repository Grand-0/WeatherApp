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

            HttpWebRequest request = (HttpWebRequest)WebRequest.CreateHttp($"{Path.FirstToken}{Path.CityName}{Path.SecondToken}{Path.RequestKey}");
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();
            using (Stream stream = response.GetResponseStream())
            {
                using (StreamReader reader = new StreamReader(stream))
                {
                    while(reader.ReadLine() != null)
                    {
                        parseString += reader.ReadLine();
                    }
                }
            }
            return parseString;
        }
    }
}
