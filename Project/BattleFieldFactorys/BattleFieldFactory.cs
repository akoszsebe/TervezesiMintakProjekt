using Project.Iterators;

namespace Project.BattleFieldFactorys
{
    abstract class BattleFieldFactory
    {
        public abstract NatziArmy CreateNatziArmy(MyCollection soldiers);
        public abstract RedArmy CreateRedArmy(MyCollection soldiers);

    }
}
