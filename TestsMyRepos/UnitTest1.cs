using System.Linq;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using RepoLibrary;
using SomeTestsExamples;
using SomeTestsExamples.Entities;
using SomeTestsExamples.Logic;

namespace TestsMyRepos
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            IRepository<Post> repo = new LocalRepository<Post>("posts.json");

            Assert.AreEqual(repo.Get().Count(), 100);

            repo = new APIRepository<Post>("https://jsonplaceholder.typicode.com/posts");

            Assert.AreEqual(repo.Get().Count(), 100);
        }

        [TestMethod]
        public void TestMethod2()
        {
            IRepository<Post> repo = new MyFakeRepository<Post>();

            Assert.AreEqual(repo.Get(), null);
        }

        [TestMethod]
        public void TestMethod3()
        {
            IRepository<Post> repo = new LocalRepository<Post>("posts.json");
            TestController ctrl = new TestController(repo);

            Assert.IsInstanceOfType(ctrl.Truc(), typeof(JsonResult));
        }

        [TestMethod]
        public void TestMethod4()
        {
            IRepository<Post> repo = new MyFakeRepository<Post>();
            TestController ctrl = new TestController(repo);

            Assert.IsInstanceOfType(ctrl.Truc(), typeof(JsonResult));
        }
    }
}
