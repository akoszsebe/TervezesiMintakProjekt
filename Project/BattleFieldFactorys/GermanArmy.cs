using System;
using System.Collections.Generic;
using System.Text;
using Project.SoldierBehaviors;

namespace Project.BattleFieldFactorys
{
    class GermanArmy : NatziArmy
    { 
        public GermanArmy(List<SoldierBehavior> soldiers)
        {
            army = new List<SoldierBehavior>(soldiers);
        }

        public override void Outfights(RedArmy ra)
        {
            Console.WriteLine(this.GetType().Name + " legyozi " + ra.GetType().Name);
        }
    }
}
