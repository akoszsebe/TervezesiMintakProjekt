namespace Project.WeaponDecorator
{
    class WeaponAccessory : IWeapon
    {
        IWeapon weapon { get; set; }

        public WeaponAccessory(IWeapon weapon)
        {
            this.weapon = weapon;
        }

        public virtual void Aim_And_Fire()
        {
            weapon.Aim_And_Fire();
        }

        public virtual string GetName()
        {
            return weapon.GetName() + " accessory - ";
        }
    }
}
