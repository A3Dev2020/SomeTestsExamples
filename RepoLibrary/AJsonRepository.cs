using System;
using System.Collections.Generic;
using System.Linq;
using Newtonsoft.Json;
using SomeTestsExamples.Logic;

namespace RepoLibrary
{
    public abstract class AJsonRepository<T> : IRepository<T>
    {
        protected IEnumerable<T> Collection;

        public void ConsumeData(string json)
        {
            Collection = JsonConvert.DeserializeObject<List<T>>(json);
        }

        public virtual IEnumerable<T> Get()
        {
            return (Collection);
        }

        public IEnumerable<T> Where(Func<T, bool> filter)
        {
            return (Get().Where(filter));
        }
    }
}
