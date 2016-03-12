using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class Problem7
{
    static void Main()
    {

        string input = Console.ReadLine();

        Dictionary<string, HashSet<string>> phoneBook = new Dictionary<string, HashSet<string>>();



        while (input != "search")
        {
            string name = input.Split('-')[0];
            string number = input.Split('-')[1];

            if (!phoneBook.ContainsKey(name))
            {
                phoneBook.Add(name, new HashSet<string>());
            }
            phoneBook[name].Add(number);

            input = Console.ReadLine();
        }

        input = Console.ReadLine();

        while (input != "END")
        {
            if (phoneBook.ContainsKey(input))
            {
                Console.WriteLine("{0} -> {1}",input, string.Join("; ", phoneBook[input]));
            }
            else
            {
                Console.WriteLine("Contact {0} does not exist.", input);
            }

            input = Console.ReadLine();
        }

    }
}

