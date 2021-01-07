using System;
using System.Collections.Generic;

namespace SomeTestsExamples.Logic
{
    public interface IRepository<T>
    {
        IEnumerable<T> Get();
        IEnumerable<T> Where(Func<T, bool> filter);
    }
}