using Project.GameLogic;
using Project.Iterators;
using Project.SoldierBehaviors;
using System;


namespace Project.BattleFieldFactorys
{
    class LiveWar
    {
        private NaziArmy naziArmy;
        private RedArmy redArmy;

        public LiveWar(BattleFieldFactory factory,MyCollection naziSoldiers, MyCollection redSoldiers)
        {
            naziArmy = factory.CreateNaziArmy(naziSoldiers);
            redArmy = factory.CreateRedArmy(redSoldiers);
            Console.WriteLine("- In Nazi army are : " + naziArmy.GetType().Name +" soldiers");
            Console.WriteLine("- In Red  army are : " + redArmy.GetType().Name +" soldiers");
        }

        public void StartWar(IGameLogicStrategy gameLogicStrategy)
        {
            Iterator nIterator = naziArmy.army.CreateIterator();
            Iterator rIterator = redArmy.army.CreateIterator();

            while (Counter.LiveCounter(naziArmy.army) > 1 && Counter.LiveCounter(redArmy.army) > 1) 
            {
                Item nItem = nIterator.First();
                Item rItem = rIterator.First();
                while (!nIterator.IsDone || !rIterator.IsDone)
                {
                    if (!nIterator.IsDone) if (nItem.Soldier.GetName().StartsWith("DeadSoldierBehavior")) nItem = nIterator.Next();
                    if (!rIterator.IsDone) if (rItem.Soldier.GetName().StartsWith("DeadSoldierBehavior")) rItem = rIterator.Next();
                    if (nIterator.IsDone) break;
                    if (rIterator.IsDone) break;
                    SoldierBehavior n = nItem.Soldier;
                    SoldierBehavior r = rItem.Soldier;
                    gameLogicStrategy.Fight(ref n, ref r);
                    nItem.Soldier = n;
                    rItem.Soldier = r;
                    nItem = nIterator.Next();
                    rItem = rIterator.Next();
                }
            }
            int natziLives = Counter.LiveCounter(naziArmy.army);
            int redLives = Counter.LiveCounter(redArmy.army);

            Console.WriteLine("-----------------------------");

            if (natziLives < redLives)
                redArmy.Outfights(naziArmy);
            else
                naziArmy.Outfights(redArmy);
                         
            Console.WriteLine("-----------------------------");
        }
    }
}
