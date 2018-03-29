using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Data;
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
        private static StationCache cache = new StationCache();
        private int timeOut = 5;

        public Station ParseStationData(string data,string station)
        {
            Station stationObject = new Station();
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
                        stationObject.latitude = (double)(item["position"]["lat"]);
                        stationObject.longitude = (double)(item["position"]["lng"]);
                        
                        return stationObject;
                    }
                    
                
                }
            }
            return null;
        }

        public Station GetStationData(string city, string station)
        {
            foreach(DataRow row in cache.GetRows())
            {
                if (row["Name"].ToString().Equals(city) && (station != "" && row["StationName"].ToString().Contains(station))){
                    if (((DateTime) row["AddedDate"]).AddMinutes(timeOut).CompareTo(DateTime.Now) >= 0)
                    {
                        return (Station)row["Station"];
                    }
                    else
                    {
                        row.Delete();
                        break;
                    }
                }
            }

            Station stationObject = ParseStationData(GetContractDataFromServer(city), station);
            cache.AddRow(stationObject);

            return stationObject;
        }

        private IList<string> ParseContracts(string data)
        {
            IList<string> contractList = new List<string>();
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

        public IList<string> GetContracts()
        {
            return ParseContracts(GetContractsFromServer());           
        }

        private IList<String> ParseStations(string data)
        {
            IList<string> stationList = new List<string>();
            if (data != "-1")
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

        public IList<string> GetStations(string city)
        {
            return ParseStations(GetContractDataFromServer(city));
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

        private Task<string> GetContractFromServerAsync()
        {
            return Task.Run(() => {
                return GetContractsFromServer();
            });
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

        private Task<String> GetContractDataFromServerAsync(String city)
        {
            return Task.Run(() =>
            {
                return GetContractDataFromServer(city);
            });
        }

        public async Task<IList<string>> GetStationsAsync(string city)
        {
            Task<string> getStationData = GetContractDataFromServerAsync(city);
            string data = await getStationData;

            return ParseStations(data);
        }

        public async Task<IList<string>> GetContractsAsync()
        {
            Task<string> getContracts = GetContractFromServerAsync();
            string contracts = await getContracts;

            return ParseContracts(contracts);
        }

        public async Task<Station> GetStationDataAsync(string city, string station)
        {
            Task<string> getStationData = GetContractDataFromServerAsync(city);
            string data = await getStationData;

            return ParseStationData(data, station);
        }
    }
}
