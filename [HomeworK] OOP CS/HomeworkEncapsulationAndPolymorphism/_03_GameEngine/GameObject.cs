using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace _03_GameEngine
{
    public abstract class GameObject
    {
        private string id;

        public GameObject(string id)
        {
            this.ID = id;
        }

        public string ID {
            get
            {
                return this.id;
            }
            set
            {
                if(string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The ID value is wrong");
                }

                this.id = value;
            }
        }
    }
}
