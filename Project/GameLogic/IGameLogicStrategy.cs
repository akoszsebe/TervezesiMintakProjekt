using Project.SoldierBehaviors;

namespace Project.GameLogic
{
    interface IGameLogicStrategy
    {
        void Fight(ref SoldierBehavior solder1,ref SoldierBehavior solder2);
    }
}
