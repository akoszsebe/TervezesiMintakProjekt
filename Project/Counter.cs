using Project.Iterators;

namespace Project
{
    class Counter
    {
        public static int LiveCounter(MyCollection collection)
        {
            Iterator iterator = collection.CreateIterator();
            int lives = 0;
            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                if (!item.GetDetails().StartsWith("DeadSoldierBehavior")) lives++;
            }
            return lives;
        }


        public static int DeadCounter(MyCollection collection)
        {
            Iterator iterator = collection.CreateIterator();
            int deads = 0;
            for (Item item = iterator.First(); !iterator.IsDone; item = iterator.Next())
            {
                if (item.GetDetails().StartsWith("DeadSoldierBehavior")) deads++;
            }
            return deads;
        }
    }
}
