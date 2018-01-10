using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BattleFieldFactory
{
    class GermanArmy : NatziArmy
    {
        public override void Outfights(RedArmy ra)
        {
            Console.WriteLine(this.GetType().Name + " legyozi " + ra.GetType().Name);
        }
    }
}
