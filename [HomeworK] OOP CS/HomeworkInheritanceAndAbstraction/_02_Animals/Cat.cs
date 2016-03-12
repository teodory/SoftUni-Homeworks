﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Animals
{
    class Cat : Animal
    {

        public Cat(string name, int age, string gender)
            :base(name,age,gender)
        {

        }

        public override string MakeASound()
        {
            return "Cat make meeeeow";
        }
    }
}
