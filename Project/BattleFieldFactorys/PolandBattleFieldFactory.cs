using Project.Iterators;

namespace Project.BattleFieldFactorys
{
    class PolandBattleFieldFactory : BattleFieldFactory
    {
        public override NatziArmy CreateNatziArmy(MyCollection soldiers)
        {
            return new GermanArmy(soldiers);
        }

        public override RedArmy CreateRedArmy(MyCollection soldiers)
        {
            return new RussianArmy(soldiers);
        }
    }
}
