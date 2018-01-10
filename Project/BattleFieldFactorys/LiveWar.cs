using Project.SoldierBehaviors;
using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BattleFieldFactorys
{
    class LiveWar
    {
        private NatziArmy natziArmy;
        private RedArmy redArmy;

        public LiveWar(BattleFieldFactory factory,List<SoldierBehavior> natziSoldiers, List<SoldierBehavior> redSoldiers)
        {
            natziArmy = factory.CreateNatziArmy(natziSoldiers);
            redArmy = factory.CreateRedArmy(redSoldiers);
        }

        public void StartWar()
        {
            redArmy.Outfights(natziArmy);
        }
    }
}
