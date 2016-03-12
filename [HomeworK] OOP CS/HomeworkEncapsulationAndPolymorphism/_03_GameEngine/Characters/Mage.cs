using _03_GameEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine.Characters
{
    class Mage : Character, IAttack
    {
        //•	Mage – implements IAttack and interacts by attacking alive characters from the other team. 
        //Always picks the last target. 
        //Has default Health points of 150, Defense points of 50, Attack points of 300 and Range of 5.

        const int health = 150;
        const int defence = 50;
        const int range = 5;

        private int attack;

        public Mage(string id, int x, int y, Team team)
            : base(id, x, y, team, health, defence, range)
        {
            this.Attack = 300;
        }

        public int Attack
        {
            get { return this.attack; }
            set { this.attack = value; }
        }

        public override Character GetTarget(IEnumerable<Character> targets)
        {
            return targets.LastOrDefault(c => c.IsAlive && c.Team != this.Team);
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            RemoveItemEffects(item);
        }

        protected override void ApplyItemEffects(Item item)
        {
            base.ApplyItemEffects(item);
            this.Attack += item.AttackEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            base.RemoveItemEffects(item);
            this.Attack -= item.AttackEffect;
        }

        public override string ToString()
        {
            return base.ToString() + " Attack: " +
                this.Attack;
        }

    }
}
