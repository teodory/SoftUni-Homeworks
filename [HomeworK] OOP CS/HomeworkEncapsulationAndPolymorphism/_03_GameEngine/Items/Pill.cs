using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine.Items
{
    class Pill : Bonus
    {
        //Pill – Bonus item with AttackEffect of 100 for 1 turn
        public Pill(string id)
            :base(id, 0, 0, 100, 1)
        {
        }
    }
}
