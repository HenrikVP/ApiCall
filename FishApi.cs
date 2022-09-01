//using Newtonsoft.Json;
using System.Net;

namespace ApiCall
{
    internal class FishApi
    {
        //https://www.fishwatch.gov/api/species
        public FishApi()
        {
            Root root = new();
            Root root2 = GetData<Root>(root);
            Person root3 = GetData<Person>(new Person());
            ShowData(root);
        }

        private void ShowData(Root root)
        {
            foreach (var item in root.results)
            {
                Console.WriteLine(item.canonicalName);

                foreach (var desc in item.descriptions)
                {
                    Console.WriteLine(desc.description);
                }
            }
        }

        T GetData<T>(T tType)
        {
            Console.Write("Search: ");
            string input = Console.ReadLine();

            string url = @"https://api.gbif.org/v1/species/search?habitat=marine&q="+input;
            string json = new WebClient().DownloadString(url);
            tType = System.Text.Json.JsonSerializer.Deserialize<T>(json);
            //Root root = JsonConvert.DeserializeObject<Root>(json);
            return tType;
        }

    }

    internal class Person
    {
    }
}
