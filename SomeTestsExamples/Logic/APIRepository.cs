using System;
using System.Net.Http;

namespace SomeTestsExamples.Logic
{
    public class APIRepository<T> : AJsonRepository<T>
    {
        public APIRepository(string url)
        {
            HttpClient client = new HttpClient();
            string json = client.GetStringAsync(url).Result;

            ConsumeData(json);
        }
    }
}