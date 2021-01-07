using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SomeTestsExamples.Entities;

namespace SomeTestsExamples
{
    [Route("[controller]/")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            HttpClient client = new HttpClient();
            string json = client.GetStringAsync("https://jsonplaceholder.typicode.com/posts").Result;

            List<Post> posts = JsonConvert.DeserializeObject<List<Post>>(json);

            return (Json(posts));
        }
    }
}
