using System;
using Project.Iterators;

namespace Project.BattleFieldFactorys
{
    class RomanianArmy : RedArmy
    { 
        public RomanianArmy(MyCollection soldiers)
        {
            army = soldiers;
        }

        public override void Outfights(NaziArmy ra)
        {
            Console.WriteLine(this.GetType().Name + " Outfights " + ra.GetType().Name);
        }
    }
}