﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Project.BattleFieldFactory
{
    class PolandBattleFieldFactory : BattleFieldFactory
    {
        public override NatziArmy CreateNatziArmy()
        {
            return new GermanArmy();
        }

        public override RedArmy CreateRedArmy()
        {
            return new RussianArmy();
        }
    }
}
