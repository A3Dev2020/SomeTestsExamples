using System.Collections.Generic;
using System.Net.Http;

namespace RepoLibrary
{
    public class APIRepository<T> : AJsonRepository<T>
    {
        private string URL;

        public APIRepository(string url)
        {
            URL = url;
        }

        public override IEnumerable<T> Get()
        {
            HttpClient client = new HttpClient();
            string json = client.GetStringAsync(URL).Result;

            ConsumeData(json);
            return (base.Get());
        }
    }
}