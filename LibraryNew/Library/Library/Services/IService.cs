using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Library.Repositories;

namespace Library.Services
{
    interface IService<TItem>
    {
        event EventHandler<ServiceEventArgs<TItem>> Updated;
    }
}