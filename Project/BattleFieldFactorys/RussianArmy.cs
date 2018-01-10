using Project.SoldierBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BattleFieldFactorys
{
    class RussianArmy : RedArmy
    {
        public RussianArmy(List<SoldierBehavior> soldiers)
        {
            army = new List<SoldierBehavior>(soldiers);
        }
        public override void Outfights(NatziArmy na)
        {
            Console.WriteLine(this.GetType().Name + " legyozi " + na.GetType().Name);
        }
    }
}
