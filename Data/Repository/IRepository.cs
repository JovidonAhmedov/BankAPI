using System;
using System.Collections.Generic;
using System.Text;

namespace Data.Repository
{
    public interface IRepository<T>
    {
        T get(long id);
        T create(T item);
    }
}
