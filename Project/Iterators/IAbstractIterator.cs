using System;
using System.Collections.Generic;
using System.Text;

namespace Project.Iterators
{
    interface IAbstractIterator
    {
        Item First();
        Item Next();
        bool IsDone { get; }
        Item CurrentItem { get; }
    }
}
