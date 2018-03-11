using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SOAPVelib
{
    public class VelibOperations : IVelibOperations
    {
        public int GetNbAvailableBikes(string city, string station)
        {
            int res = 0;

            string data = GetDataFromServer(city);
            if (data != "-1")
            {
                JArray stationArray = JArray.Parse(data);

                for (int i = 0; i < stationArray.Count(); i++)
                {
                    JObject item = (JObject)stationArray[i];
                    if (((string)item["name"]).ToLower().Contains(station.ToLower()))
                    {
                        res = (int)item["available_bikes"];
                        return res;
                    }
                }
            }  
            return -1;
        }

        public IList<string> GetStations(string city)
        {
            IList<string> stationList = new List<string>();
            string data = GetDataFromServer(city);
            if(data != "-1")
            {
                JArray stationArray = JArray.Parse(data);
                for (int i = 0; i < stationArray.Count(); i++)
                {
                    JObject item = (JObject)stationArray[i];
                    stationList.Add((String)item["name"]);
                }
            }
            
            return stationList;
        }

        private string GetDataFromServer(string city)
        {
            string cityName = Char.ToUpper(city[0]) + city.Substring(1, city.Length - 1).ToLower();

            // Create a request for the URL. 
            WebRequest request = WebRequest.Create("https://api.jcdecaux.com/vls/v1/stations?contract="+ cityName + "&apiKey=54891361888ee7897e3778b99473f96067b77ad7");
            // If required by the server, set the credentials.
            //
            request.Credentials = CredentialCache.DefaultCredentials;
            // Get the response.
            WebResponse response;
            try
            {
                response = request.GetResponse();
                // Display the status.
                Console.WriteLine(((HttpWebResponse)response).StatusDescription);
                // Get the stream containing content returned by the server.
                Stream dataStream = response.GetResponseStream();
                // Open the stream using a StreamReader for easy access.
                StreamReader reader = new StreamReader(dataStream);
                // Read the content.
                string responseFromServer = reader.ReadToEnd();
                return responseFromServer;
            }
            catch (Exception e)
            {
                return "-1";
            }           
        }
    }
}
