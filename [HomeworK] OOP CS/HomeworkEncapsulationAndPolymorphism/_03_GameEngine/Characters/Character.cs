using _03_GameEngine.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine
{
    public abstract class Character : GameObject
    {
        //X and Y coordinates, Health points, Defense points, 
        //Team (Blue or Red), Inventory (list of items), 
        //Range (for interacting with other champions) and 
        //IsAlive (for tracking if the character is dead or alive). 

        //Holds the methods AddToInventory/RemoveFromInventory (adds/removes an item to the character's inventory), 
        //ApplyItemEffects/RemoveItemEffects (applies/removes the item's effect on the character) and 
        //GetTarget (gets the most suitable target to interact with).

        private int x, y;
        private int health;
        private int defence;

        private Team team;
        private List<Item> inventory = new List<Item>();
        private int range;

        private bool isAlive;

        
        public Character(string id, int x, int y, Team team, int health, int defence, int range)
            :base(id)
        {
            this.X = x;
            this.Y = y;
            this.Team = team;
            this.Health = health;
            this.Defence = defence;
            this.Range = range;
            this.IsAlive = true;
            this.Inventory = new List<Item>();
        }

        public int X { get; set; }

        public int Y { get; set; }

        internal Team Team { get; set; }

        public int Health
        { 
            get { return this.health; }
            set { this.health = value; }
        }

        public int Defence { get; set; }

        public int Range { get; set; }

        public bool IsAlive { get; set; }

        public List<Item> Inventory
        {
            get;
            private set;
        }

        public abstract void AddToInventory(Item item);

        public abstract void RemoveFromInventory(Item item);
        
        protected virtual void ApplyItemEffects(Item item)
        {
            this.Health += item.HealthEffect;
            this.Defence += item.DefenseEffect;
        }

        protected virtual void RemoveItemEffects(Item item)
        {
            this.Health -= item.HealthEffect;
            this.Defence -= item.DefenseEffect;
            if (this.Health < 0)
            {
                this.Health = 1;
            }
        }

        public abstract Character GetTarget(IEnumerable<Character> targets);

        public override string ToString()
        {
            return string.Format(
                "--Name: {0}, Team: {2}, Health: {1}, Defense: {3}",
                this.ID,
                this.Health,
                this.Team,
                this.Defence);
                
        }
        
    }
}
