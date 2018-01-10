using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BattleFieldFactory
{
    abstract class BattleFieldFactory
    {
        public abstract NatziArmy CreateNatziArmy();
        public abstract RedArmy CreateRedArmy();

    }
}
