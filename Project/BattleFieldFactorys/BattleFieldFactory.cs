using Project.SoldierBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BattleFieldFactorys
{
    abstract class BattleFieldFactory
    {
        public abstract NatziArmy CreateNatziArmy(List<SoldierBehavior> soldiers);
        public abstract RedArmy CreateRedArmy(List<SoldierBehavior> soldiers);

    }
}
