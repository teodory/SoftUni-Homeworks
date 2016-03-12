using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Text.RegularExpressions;

class Problem3
{
    static void Main()
    {
        // речник който да пази търсените думи като ключове, ако има съвпадение да инкрементира
        var words = new Dictionary<string, int>();

        string inputWords = Console.ReadLine().ToLower();
        while (inputWords != "end")
        {
            words.Add(inputWords, 0);
            inputWords = Console.ReadLine();
        }

        using (StreamReader reader = new StreamReader("../../../text.txt"))
        {
            Regex regex = new Regex(@"[^\w+]");

            //чете ред от файла и го слага в масив от думи (прави ги малки) за да обходим всяка
            string line = reader.ReadLine().ToLower();

            string[] wordsFromLine = regex.Split(line);        // ако файла е празен ще хвърли грешка

            while (line != null)
            {
                for (int i = 0; i < wordsFromLine.Length; i++)
                {
                    if (words.ContainsKey(wordsFromLine[i]))   //проверява за ключ
                    {
                        words[wordsFromLine[i]]++;
                    }
                    //Console.WriteLine(wordsFromLine[i]);
                }

                line = reader.ReadLine();
                if (line != null)                   //проверка за празен ред
                {
                    wordsFromLine = regex.Split(line.ToLower());
                }
            }
        }
        using (StreamWriter writer = new StreamWriter("../../results.txt"))
        {
            foreach (var item in words)
            {
                writer.WriteLine(item.Key + " - " + item.Value);
                //Console.WriteLine(item.Key + " - " + item.Value);
            }
        }
        

    }
}

