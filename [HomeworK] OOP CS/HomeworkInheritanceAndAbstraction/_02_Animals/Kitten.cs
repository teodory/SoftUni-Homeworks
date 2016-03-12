using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Animals
{
    class Kitten : Cat
    {
        public Kitten(string name, int age)
            : base(name, age, "female ")
        {

        }

        public override string MakeASound()
        {
            return base.MakeASound() + " " + base.Gender ;
        }
    }
}
