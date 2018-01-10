using Project.SoldierBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

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
        }

    }
}
