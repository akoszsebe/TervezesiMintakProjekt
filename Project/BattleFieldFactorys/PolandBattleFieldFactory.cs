using Project.Iterators;

namespace Project.BattleFieldFactorys
{
    class PolandBattleFieldFactory : BattleFieldFactory
    {
        public override NaziArmy CreateNaziArmy(MyCollection soldiers)
        {
            return new HungarianArmy(soldiers);
        }

        public override RedArmy CreateRedArmy(MyCollection soldiers)
        {
            return new RomanianArmy(soldiers);
        }
    }
}
