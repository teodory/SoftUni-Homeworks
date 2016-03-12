using _03_GameEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine.Characters
{
    class Healer : Character , IHeal
    {

        //Healer – implements IHeal and interacts by healing alive characters from his/her own team. 
        //Always picks the target with the least Health points (cannot target self). 
        //Has default Health points of 75, Defense points of 50, Healing points of 60 and Range of 6.

        const int health = 75;
        const int defence = 50;
        const int healing = 60;
        const int range = 6;

        private int heal;

        public Healer(string id, int x, int y, Team team)
            : base(id, x, y, team, health, defence, range)
        {
            this.Healing = healing;
        }

        protected override void ApplyItemEffects(Item item)
        {
            this.Defence += item.DefenseEffect;
            this.Health += item.HealthEffect;
        }

        protected override void RemoveItemEffects(Item item)
        {
            this.Defence -= item.DefenseEffect;
            this.Health -= item.HealthEffect;
        }

        public override void AddToInventory(Item item)
        {
            this.Inventory.Add(item);
            base.ApplyItemEffects(item);
        }

        public override void RemoveFromInventory(Item item)
        {
            this.Inventory.Remove(item);
            base.RemoveItemEffects(item);
        }

        public override Character GetTarget(IEnumerable<Character> targets)
        {
            return targets
                    .OrderBy(t => t.Health)
                    .First(c => c.IsAlive && c.Team == this.Team && !c.Equals(this));
        }

        public override string ToString()
        {
            //StringBuilder output = new StringBuilder();
            //output.AppendLine(string.Format("{0}\r\nCoordinates: {1} {2}\r\nTeam: {3}\r\nH D A: {4} {5} {6}\r\nRange: {7} Alive: {8}",
            //    this.GetType().Name + " " + this.ID, this.X, this.Y, this.Team, this.Health, this.Defence, healing, this.Range, this.IsAlive));
            //output.Append(string.Format("Items: {0}", this.Inventory.Count > 0 ? string.Join(", ", this.Inventory) : "empty"));

            return base.ToString() + " Healing: " + this.Healing;
        }

        public int Healing
        {
            get
            {
                return this.heal;
            }
            set
            {
                this.heal = value;
            }
        }
    }
}
