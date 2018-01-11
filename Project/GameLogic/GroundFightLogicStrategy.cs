using System;
using Project.SoldierBehaviors;

namespace Project.GameLogic
{
    class GroundFightLogicStrategy : IGameLogicStrategy
    {
        public void Fight(ref SoldierBehavior soldier1,ref SoldierBehavior soldier2)
        {
            int s1x = 1;
            int s2x = 1;
            if (soldier1.GetName() == "AirforceSoldierBehavior") s1x = 5;
            if (soldier2.GetName() == "AirforceSoldierBehavior") s2x = 5;
            if (soldier1.GetName() == "NavyforceSoldierBehavior") s1x = 0;
            if (soldier2.GetName() == "NavyforceSoldierBehavior") s2x = 0;

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
