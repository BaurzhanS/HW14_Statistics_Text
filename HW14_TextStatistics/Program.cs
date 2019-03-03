using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HW14_TextStatistics
{
    class Program
    {
        static void Main(string[] args)
        {
            string s = "Вот дом, Который построил Джек. А это пшеница, Которая в темном " +
                "чулане хранится В доме, Который построил Джек. А это веселая " +
                "птица­ синица, Которая часто вору­ет пшеницу, Которая в темном " +
                "чулане хранится В доме, Который построил Джек.";
            
            string[] words = s.Split(' ');
            Dictionary<string, int> dic = new Dictionary<string, int>();

            foreach (var word in words)
            {
                if (dic.ContainsKey(word))
                    dic[word] += 1;
                else
                    dic.Add(word, 1);
            }
            Console.WriteLine("Слово:\t\tКоличество:");
           
            foreach (var word in dic)
            {
                if (word.Key.Length > 7)
                    Console.WriteLine("{0}\t{1}", word.Key, word.Value);
                else
                    Console.WriteLine("{0}\t\t{1}", word.Key, word.Value);
            }
           
            Console.WriteLine("Всего слов: {0} из них {1} уникальных",words.Length, dic.Keys.Count());

        }
    }
}
