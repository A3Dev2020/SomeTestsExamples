using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using SomeTestsExamples.Entities;
using SomeTestsExamples.Logic;

namespace SomeTestsExamples
{
    [Route("[controller]/")]
    public class TestController : Controller
    {
        public IActionResult Index()
        {
            //APIRepository<Post> repo = 
            //LocalRepository<Post> repo = new LocalRepository<Post>("posts.json");

            AJsonRepository<Post> repo = new APIRepository<Post>("https://jsonplaceholder.typicode.com/posts");
            AJsonRepository<Post> repo2 = new LocalRepository<Post>("posts.json");

            IEnumerable<Post> posts = repo.Where(i => i.Body.Contains("volupta"));

            JsonSerializerOptions serializerSettings = new JsonSerializerOptions();

            serializerSettings.WriteIndented = true;
            return Json(posts, serializerSettings);
        }
    }
}
