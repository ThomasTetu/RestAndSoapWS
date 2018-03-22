using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SOAPVelib
{
    public class VelibOperations : IVelibOperations
    {
        private static string BASE_URI = "https://api.jcdecaux.com/vls/v1/";
        private static string API_KEY = "&apiKey=54891361888ee7897e3778b99473f96067b77ad7";

        public Station GetStationData(string city, string station)
        {
            Station stationObject = new Station();

            string data = GetContractDataFromServer(city);
            if (data != "-1")
            {
                JArray stationArray = JArray.Parse(data);

                for (int i = 0; i < stationArray.Count(); i++)
                {
                    JObject item = (JObject)stationArray[i];
                    if (((string)item["name"]).ToLower().Contains(station.ToLower()))
                    {
                        stationObject.city = (string)item["contract_name"];
                        stationObject.name = (string)item["name"];
                        stationObject.address = (string)item["address"];
                        stationObject.availableBikes = (int)item["available_bikes"];
                    }
                    return stationObject;
                }
            }  
            return null;
        }

        public IList<string> GetContracts()
        {
            IList<string> contractList = new List<string>();
            string data = GetContractsFromServer();

            if (data != "-1")
            {
                JArray contractArray = JArray.Parse(data);

                for (int i = 0; i < contractArray.Count(); i++)
                {
                    JObject item = (JObject)contractArray[i];
                    contractList.Add((String)item["name"]);
                }
            }
            return contractList;
        }

        public IList<string> GetStations(string city)
        {
            IList<string> stationList = new List<string>();
            string data = GetContractDataFromServer(city);
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

        private string GetContractsFromServer()
        {
            WebRequest request = WebRequest.Create(BASE_URI + "contracts?" + API_KEY);
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

        private string GetContractDataFromServer(string city)
        {
            string cityName = Char.ToUpper(city[0]) + city.Substring(1, city.Length - 1).ToLower();

            // Create a request for the URL. 
            WebRequest request = WebRequest.Create( BASE_URI + "stations?contract=" + cityName + API_KEY);
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
