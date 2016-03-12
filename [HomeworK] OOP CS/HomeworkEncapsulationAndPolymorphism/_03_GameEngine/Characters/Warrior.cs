using _03_GameEngine.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine
{
    //Warrior – implements IAttack and interacts by attacking alive characters from the other team.
    //Always picks the first target. Has default Health points of 200, Defense points of 100, Attack points of 150 and Range of 2.

    class Warrior : Character, IAttack
    {
        const int health = 200;
        const int defence = 100;
        const int range = 2;

        private int attack;

        //create characterClass id x y team
        //create mage Nakov 3 4 Red

        public Warrior(string id, int x, int y, Team team)
            :base(id, x, y, team, health, defence , range)
        {
            this.Attack = 150;
        }

        public int Attack 
        { 
            get { return this.attack; }
            set { this.attack = value; }
        }

     
        public override Character GetTarget(IEnumerable<Character> targets)
        {
            return targets.FirstOrDefault(c => c.IsAlive && c.Team != this.Team);
        }

        public override string ToString()
        {
            //StringBuilder output = new StringBuilder();
            //output.AppendLine(string.Format("{0}\r\nCoordinates: {1} {2}\r\nTeam: {3}\r\nH D A: {4} {5} {6}\r\nRange: {7} Alive: {8}",
            //    this.GetType().Name + " " + this.ID, this.X, this.Y, this.Team, this.Health, this.Defence, this.Attack, this.Range, this.IsAlive));
            //output.Append(string.Format("Items: {0}", this.Inventory.Count > 0 ? string.Join(", ", this.Inventory) : "empty"));

            return base.ToString() + " Attack: " + this.Attack;
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

    }
}
