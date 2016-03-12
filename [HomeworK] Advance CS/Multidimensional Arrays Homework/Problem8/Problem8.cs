using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


class Problem8
{
    static void Main()
    {
        string input = Console.ReadLine();

        Dictionary<string, SortedDictionary<string, SortedSet<string>>> allData 
            = new Dictionary<string, SortedDictionary<string, SortedSet<string>>>();

        while (input != "END")
        {
            string city = input.Split(';')[0];
            string venue = input.Split(';')[1];
            string performer = input.Split(';')[2];

            if (!allData.ContainsKey(city))
            {
                allData.Add(city, new SortedDictionary<string, SortedSet<string>>());
            }
            if (!allData[city].ContainsKey(venue))
            {
                allData[city].Add(venue, new SortedSet<string>());
            }

            allData[city][venue].Add(performer);

            input = Console.ReadLine();
        }

        foreach (var city in allData)
        {
            Console.WriteLine(city.Key);
            foreach (var perf in city.Value)
            {
                Console.WriteLine("-> {0}: {1}", perf.Key, string.Join(", ", perf.Value));
            }
        }
    }
}

