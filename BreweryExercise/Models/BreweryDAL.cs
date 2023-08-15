using Newtonsoft.Json;
using System.Net;

namespace BreweryExercise.Models
{
    public class BreweryDAL
    {
        public static List<BreweryModel> GetBreweries(string city) //Adjust here
        {
            //Adjust
            //Setup
            string url = $"https://api.openbrewerydb.org/v1/breweries?by_city={city}";

            //Request
            HttpWebRequest request = WebRequest.CreateHttp(url);
            HttpWebResponse response = (HttpWebResponse)request.GetResponse();

            //Converting to json
            StreamReader reader = new StreamReader(response.GetResponseStream());
            string JSON = reader.ReadToEnd();

            //Convert to c#
            List<BreweryModel> result = JsonConvert.DeserializeObject<List<BreweryModel>>(JSON);
            return result;
        }
    }
}
