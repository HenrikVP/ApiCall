//using Newtonsoft.Json;
using System.Net;

namespace ApiCall
{
    internal class FishApi
    {
        //https://www.fishwatch.gov/api/species
        public FishApi()
        {
            GetData();
        }
        void GetData()
        {
            Console.Write("Search: ");
            string input = Console.ReadLine();

            string url = @"https://api.gbif.org/v1/species/search?habitat=marine&q="+input;
            string json = new WebClient().DownloadString(url);
            Root root = System.Text.Json.JsonSerializer.Deserialize<Root>(json);
            //Root root = JsonConvert.DeserializeObject<Root>(json);
            foreach (var item in root.results)
            {              
                Console.WriteLine(item.canonicalName);
                
                foreach (var desc in item.descriptions)
                {
                    Console.WriteLine(desc.description);
                }
            }
        }

    }
}
