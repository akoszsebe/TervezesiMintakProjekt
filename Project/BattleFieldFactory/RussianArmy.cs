using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BattleFieldFactory
{
    class RussianArmy : RedArmy
    {
        public override void Outfights(NatziArmy na)
        {
            Console.WriteLine(this.GetType().Name + " legyozi " + na.GetType().Name);
        }
    }
}
