using Project.SoldierBehaviors;

namespace Project.Iterators
{
    class Item
    {
        private SoldierBehavior soldier;

        public Item(SoldierBehavior soldier)
        {
            this.soldier = soldier;
        }

        public SoldierBehavior Soldier
        {
            get { return soldier; }
            set { soldier = value; }
        }

        public string GetDetails() => soldier.GetName() + " with " + soldier.GetWeapon().GetName();
        

    }
}
