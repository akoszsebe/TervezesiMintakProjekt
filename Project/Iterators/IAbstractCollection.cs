using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Project.Iterators
{
    interface IAbstractCollection
    {
        Iterator CreateIterator(); 
    }
}
