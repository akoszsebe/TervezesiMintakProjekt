using Project.Iterators;

namespace Project.BattleFieldFactorys
{
    abstract class NaziArmy
    {
        public MyCollection army { get; set; }
        public abstract void Outfights(RedArmy ra);
    }
}
