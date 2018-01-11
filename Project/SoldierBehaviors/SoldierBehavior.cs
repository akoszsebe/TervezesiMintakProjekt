using Project.WeaponDecorator;

namespace Project.SoldierBehaviors
{
    abstract class SoldierBehavior
    {
        public int health { get; set; }
        private IWeapon weapon { get; set; }

        protected SoldierBehavior(int starthealth,IWeapon weapon)
        {
            this.health = starthealth;
            this.weapon = weapon; 
        }

        public IWeapon GetWeapon() => weapon;

        public string GetName() => this.GetType().Name + " -> health = "+ health;

        public abstract void Attak(ref SoldierBehavior soldier,int multiplier);
    }
}
