namespace Project.Iterators
{
    internal class Iterator : IAbstractIterator
    {
        private MyCollection myCollection;
        private int current = 0;
        private int step = 1;

        public Iterator(MyCollection myCollection)
        {
            this.myCollection = myCollection;
        }

        public bool IsDone => current >= myCollection.Count;

        public Item CurrentItem => myCollection[current] as Item;

        public Item First()
        {
            current = 0;
            return myCollection[current] as Item;
        }

        public Item Next()
        {
            current += step;
            if (!IsDone)
                return myCollection[current] as Item;
            else
                return null;
        }

        public int Step
        {
            get { return step; }
            set { step = value; }
        }
    }
}