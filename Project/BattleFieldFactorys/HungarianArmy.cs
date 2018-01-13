using System;
using Project.Iterators;

namespace Project.BattleFieldFactorys
{
    class HungarianArmy : NaziArmy
    { 
        public HungarianArmy(MyCollection soldiers)
        {
            army = soldiers;
        }

        public override void Outfights(RedArmy ra)
        {
            Console.WriteLine(this.GetType().Name + " Outfights " + ra.GetType().Name);
        }
    }
}