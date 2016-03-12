using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine.Items
{
    class Injection : Bonus
    {
        //Injection – Bonus item with HealthEffect of 200 for 3 turns. 
        //If a character's health points fall under 1 after the 
        //bonus times out (and is removed), his/her health points become 1.

        public Injection(string id)
            :base(id, 200, 0, 0, 3)
        {
        }

    }
}
