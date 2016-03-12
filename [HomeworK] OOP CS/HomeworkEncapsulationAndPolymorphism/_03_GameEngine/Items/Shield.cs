using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine.Items
{
    class Shield : Item
    {
        const int HealthEffect = 0;
        const int DefenseEffect = 50;
        const int AttackEffect = 0;

        public Shield(string id)
            :base(id, HealthEffect, DefenseEffect, AttackEffect)
        {

        }
    }
}
