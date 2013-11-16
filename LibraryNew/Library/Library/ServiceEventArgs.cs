using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Library
{
    class ServiceEventArgs<TItem> : EventArgs
    {
        public Operation Operation { get; private set; }
        public TItem Value { get; private set; }
        public int ItemsCount { get; private set; }
    
        public ServiceEventArgs(Operation op, TItem value, int itemsCount)
        {
            Operation = op;
            Value = value;
            ItemsCount = itemsCount;
        }
    }
}
