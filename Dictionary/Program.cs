using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dictionary
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input = Console.ReadLine().Split(' ').Select(s => s.ToLowerInvariant()).ToArray();
            Dictionary<string, int> dict = new Dictionary<string, int>();
            foreach (var element in input)
            {
                if (dict.ContainsKey(element))
                {
                    dict[element] = dict[element] + 1;
                }
                else
                {
                    dict.Add(element, 1);
                }
            }
            foreach (var pair in dict)
            {
                if (pair.Value % 2 != 0)
                {
                    Console.Write(pair.Key + " ");
                }
            }
        }
    }
}
