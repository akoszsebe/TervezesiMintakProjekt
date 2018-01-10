using Project.SoldierBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BattleFieldFactorys
{
    abstract class RedArmy
    {
        public List<SoldierBehavior> army { get; set; }
        public abstract void Outfights(NatziArmy na);
    }
}
