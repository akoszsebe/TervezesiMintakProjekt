using Project.Iterators;
using System;

namespace Project
{
    class Printer
    {
        public static void Print(MyCollection collection)
        {
            Iterator iterator = collection.CreateIterator();
            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                Console.WriteLine(item.GetDetails());
            }
            Console.WriteLine();
        }
    }
}
