using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine.Items
{
    class Axe : Item
    {
        const int HealthEffect = 0;
        const int DefenseEffect = 0;
        const int AttackEffect = 75;

        public Axe(string id)
            :base(id, HealthEffect, DefenseEffect, AttackEffect)
        {

        }
    }
}
