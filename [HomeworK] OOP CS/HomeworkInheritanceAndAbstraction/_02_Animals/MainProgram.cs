using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02_Animals
{
    class MainProgram
    {
        static void Main(string[] args)
        {
         
            Dog dog1 = new Dog("Jhony", 10, "male");
            Cat cat1 = new Cat("Kotka", 1, "female");
            Frog frog1 = new Frog("Green", 99, "male");
            Kitten kitten1 = new Kitten("Pussy", 18);
            Tomcat tomcat1 = new Tomcat("Tom", 22);
            Dog dog2 = new Dog("Balkan", 1, "male");
            Frog frog2 = new Frog("Karpat", 12, "male");
            Kitten kitten2 = new Kitten("Kitenik", 22);
            Dog dog3 = new Dog("StreetFighter", 5, "female");

            Animal[] animals = new Animal[9];

            animals[0] = dog1;
            animals[1] = cat1;
            animals[2] = frog1;
            animals[3] = kitten1;
            animals[4] = tomcat1;
            animals[5] = dog2;
            animals[6] = frog2;
            animals[7] = kitten2;
            animals[8] = dog3;

             
            foreach (var kind in animals.GroupBy(a => a.GetType().Name))
            {
                double avrAge = kind.Select(a => a.Age).Average();
                Console.WriteLine("Animal : {0} - AverageAge: {1}", kind.Key, avrAge);
            }
        }
    }
}
