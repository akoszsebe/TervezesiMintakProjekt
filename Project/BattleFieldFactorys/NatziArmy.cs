using Project.Iterators;

namespace Project.BattleFieldFactorys
{
    abstract class NatziArmy
    {
        public MyCollection army { get; set; }
        public abstract void Outfights(RedArmy ra);
    }
}
