using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BattleFieldFactory
{
    class LiveWar
    {
        private NatziArmy natziArmy;
        private RedArmy redArmy;

        public LiveWar(BattleFieldFactory factory)
        {
            natziArmy = factory.CreateNatziArmy();
            redArmy = factory.CreateRedArmy();
        }

        public void StartFight()
        {
            redArmy.Outfights(natziArmy);
        }
    }
}
