using _03_GameEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine.Items
{
    abstract class Bonus : Item, ITimeout
    {

        public Bonus(string id, int health, int defence, int attack, int timeOut)
            :base(id, health, defence, attack)
        {
            this.Timeout = timeOut;
            this.Countdown = timeOut;
        }

        public int Timeout { get; set; }

        public int Countdown { get; set; }

        public bool HasTimedOut { get; set; }


    }
}
