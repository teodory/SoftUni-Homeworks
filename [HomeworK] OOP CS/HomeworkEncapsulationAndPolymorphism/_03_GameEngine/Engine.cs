using _03_GameEngine.Characters;
using _03_GameEngine.Items;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03_GameEngine
{
    class Engine
    {
        internal void Run()
        {
            //create mage Nakov 3 4 Red
            //add Nakov axe Axe 

            List<Character> champions = new List<Character>();

            string[] line = Console.ReadLine().Split(' ');

            while (line[0] != "")
            {
                if (line[0].Equals("create"))
                {
                    champions.Add(CreateCharacter(line));
                }
                else
                {
                    string characterId = line[1];
                    
                    Item item = CreateItem(line);

                    champions.First(c => c.ID == characterId).AddToInventory(item);
                    //champions.First(c => c.ID == characterId).ApplyItemEffects(item);
                }

                CheckForPastBonus(champions);
                line = Console.ReadLine().Split(' ');
            }

            foreach (Character ch in champions)
            {
                Console.WriteLine(ch);
                Console.WriteLine();
            }

            Console.WriteLine("Fin");
        }

        public Character CreateCharacter(string[] line)
        {
            string charType = line[1];
            string id = line[2];
            int x = int.Parse(line[3]);
            int y = int.Parse(line[4]);
            string team = line[5];

            switch (charType)
            {
                case "mage" :               

                    return new Mage(id, x, y, (Team)Enum.Parse(typeof(Team), team));

                case "warrior":
                    return new Warrior(id, x, y, (Team)Enum.Parse(typeof(Team), team));

                case "healer":
                    return new Healer(id, x, y, (Team)Enum.Parse(typeof(Team), team));
            }

            return null;
        }

        public Item CreateItem( string[] line)
        {
            string type = line[2];
            string id = line[3];

            switch (type)
            {
                case "axe" :
                    return new Axe(id);
                case "shield":
                    return new Shield(id);
                case "injection":
                    return new Injection(id);
                case "pill":
                    return new Pill(id);
            }

            return null;

           
        }

        public void CheckForPastBonus(List<Character> champs)
        {
            //foreach (Character ch in champs)
            //{
            //    foreach (Item item in ch.Inventory)
            //    {
            //        if (item.IsBonus)
            //        {
            //            item.Timeout--;
            //            if (item.Timeout == 0)
            //            {
            //                ch.RemoveItemEffects(item);
            //                ch.Inventory.Remove(item);
            //            }
            //            //Console.WriteLine(item.Timeout + " **************");
            //        }
            //    }
                //ch.Inventory.Where(i => i.IsBonus == true).Select(i => i.ToString() + " +++++++");

                //List<Bonus> bonusList = ch.Inventory
                //    .Where(i => i.IsBonus)
                //    .Cast<Bonus>()
                //    .ToList();

             
            //}
        }

    }
}
