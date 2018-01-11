using Project.WeaponDecorator;

namespace Project.SoldierBehaviors
{
    class NavyforceSoldierBehavior : SoldierBehavior
    {
        public NavyforceSoldierBehavior(IWeapon weapon) : base(20, weapon)
        {
        }
        public override void Attak(ref SoldierBehavior soldier,int multiplier)
        {
            soldier.health -= 10*multiplier;
            if (soldier.health <= 0)
            {
                IWeapon tmpWeapon = soldier.GetWeapon();
                soldier = new DeadSoldierBehavior(tmpWeapon);
            };
        }
    }
}
