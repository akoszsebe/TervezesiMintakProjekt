using Project.SoldierBehaviors;
using System;

namespace Project.GameLogic
{
    class AirFightLogicStrategy : IGameLogicStrategy
    {
        public void Fight(ref SoldierBehavior solder1,ref SoldierBehavior solder2)
        {
            int s1x = 5;
            int s2x = 5;
            if (solder1.GetName() == "GroundforcesSoldierBehavior") s1x = 1;
            if (solder2.GetName() == "GroundforcesSoldierBehavior") s2x = 1;
            if (solder1.GetName() == "NavyforceSoldierBehavior") s1x = 5;
            if (solder2.GetName() == "NavyforceSoldierBehavior") s2x = 5;

            var whoShoots = new Random();
            if (whoShoots.Next(1, 100) % 2 == 0)
            {
                solder1.Attak(ref solder2, s1x);
            }
            else
            {
                solder2.Attak(ref solder1, s2x);
            }

        }
    }
}
