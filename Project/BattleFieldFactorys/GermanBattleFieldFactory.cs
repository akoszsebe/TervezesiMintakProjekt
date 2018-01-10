using Project.SoldierBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BattleFieldFactorys
{
    class GermanBattleFieldFactory : BattleFieldFactory
    {
        public override NatziArmy CreateNatziArmy(List<SoldierBehavior> soldiers)
        {
            return new GermanArmy(soldiers);
        }

        public override RedArmy CreateRedArmy(List<SoldierBehavior> soldiers)
        {
            return new RussianArmy(soldiers);
        }
    }
}
