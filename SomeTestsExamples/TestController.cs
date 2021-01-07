using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using RepoLibrary;
using SomeTestsExamples.Entities;
using SomeTestsExamples.Logic;

namespace SomeTestsExamples
{
    [Route("[controller]/")]
    public class TestController : Controller
    {
        private IRepository<Post> Repository;

        public TestController(IRepository<Post> repo)
        {
            Repository = repo;
        }

        public IActionResult Index()
        {
            IEnumerable<Post> posts = Repository.Where(i => i.Body.Contains("volupta"));

            JsonSerializerOptions serializerSettings = new JsonSerializerOptions();

            serializerSettings.WriteIndented = true;
            return Json(posts, serializerSettings);
        }

        [HttpGet("truc")]
        public IActionResult Truc()
        {
            IEnumerable<Post> posts = Repository.Get();

            if (posts == null)
                return (Json("KO"));

            Repository.Get();
            return (Json("OK"));
        }
    }
}
