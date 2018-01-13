using Project.Iterators;

namespace Project.BattleFieldFactorys
{
    abstract class BattleFieldFactory
    {
        public abstract NaziArmy CreateNaziArmy(MyCollection soldiers);
        public abstract RedArmy CreateRedArmy(MyCollection soldiers);

    }
}
