using System;
using System.Collections.Generic;
using SomeTestsExamples.Logic;

namespace TestsMyRepos
{
    public class MyFakeRepository<T> : IRepository<T>
    {
        private IEnumerable<T> Collection = null;

        public MyFakeRepository() { }

        public MyFakeRepository(IEnumerable<T> collection)
        {
            Collection = collection;
        }

        public IEnumerable<T> Get()
        {
            return (Collection);
        }

        public IEnumerable<T> Where(Func<T, bool> filter)
        {
            throw new NotImplementedException();
        }
    }
}