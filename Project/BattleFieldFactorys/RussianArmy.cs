using Project.Iterators;
using System;

namespace Project.BattleFieldFactorys
{
    class RussianArmy : RedArmy
    {
        public RussianArmy(MyCollection soldiers)
        {
            army = soldiers;
        }
        public override void Outfights(NaziArmy na)
        {
            Console.WriteLine(this.GetType().Name + " Outfights " + na.GetType().Name);
        }
    }
}
