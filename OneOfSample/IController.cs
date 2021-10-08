using System;
using System.Collections.Generic;
using System.Text;

namespace OneOfSample
{
    public interface IController<T>
    {
        ApiResult CreateUser(T toCreate);
    }
}
