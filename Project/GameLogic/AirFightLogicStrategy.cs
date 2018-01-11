using Project.SoldierBehaviors;
using System;

namespace Project.GameLogic
{
    class AirFightLogicStrategy : IGameLogicStrategy
    {
        public void Fight(ref SoldierBehavior soldier1,ref SoldierBehavior soldier2)
        {
            int s1x = 5;
            int s2x = 5;
            if (soldier1.GetName() == "GroundforcesSoldierBehavior") s1x = 1;
            if (soldier2.GetName() == "GroundforcesSoldierBehavior") s2x = 1;
            if (soldier1.GetName() == "NavyforceSoldierBehavior") s1x = 5;
            if (soldier2.GetName() == "NavyforceSoldierBehavior") s2x = 5;

            var whoShoots = new Random();
            if (whoShoots.Next(1, 100) % 2 == 0)
            {
                soldier1.Attak(ref soldier2, s1x);
            }
            else
            {
                soldier2.Attak(ref soldier1, s2x);
            }

        }
    }
}
