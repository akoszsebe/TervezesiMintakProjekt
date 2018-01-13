using Project.Iterators;

namespace Project.BattleFieldFactorys
{
    abstract class RedArmy
    {
        public MyCollection army { get; set; }
        public abstract void Outfights(NaziArmy na);
    }
}
