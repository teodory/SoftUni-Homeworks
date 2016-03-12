using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Animals
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age)
            :base(name, age, "male")
        {

        }

        public override string MakeASound()
        {
            return "Meeeeowww";
        }
    }
}
