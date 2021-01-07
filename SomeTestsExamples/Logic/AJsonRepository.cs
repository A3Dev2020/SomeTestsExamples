using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace SomeTestsExamples.Logic
{
    public abstract class AJsonRepository<T> : IRepository<T>
    {
        protected IEnumerable<T> Collection;

        public void ConsumeData(string json)
        {
            Collection = JsonConvert.DeserializeObject<List<T>>(json);
        }

        public IEnumerable<T> Get()
        {
            return (Collection);
        }

        public IEnumerable<T> Where(Func<T, bool> filter)
        {
            return (Get().Where(filter));
        }
    }
}
