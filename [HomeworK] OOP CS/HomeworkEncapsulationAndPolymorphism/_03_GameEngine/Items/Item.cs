using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine
{
    public abstract class Item : GameObject
    {
        //Contains fields HealthEffect, DefenseEffect, AttackEffect and affects the fields of the character who uses the item.
        private int healthEffect;
        private int defenseEffect;
        private int attackEffect;

        public Item(string id, int health, int defence, int attack)
            :base(id)
        {
            this.HealthEffect = health;
            this.DefenseEffect = defence;
            this.AttackEffect = attack;
        }

        public int HealthEffect { get; set; }

        public int DefenseEffect { get; set; }

        public int AttackEffect 
        { 
            get { return this.attackEffect; }
            set { this.attackEffect = value; }
        }
 

        public override string ToString()
        {
            return this.ID;
        }

    }
}
