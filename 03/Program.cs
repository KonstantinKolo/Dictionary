using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03
{
    class Program
    {
        static void Main(string[] args)
        {
            string type;
            int quantity;
            Dictionary<string, int> dict = new Dictionary<string, int>();
            while (true)
            {
                type = Console.ReadLine();
                if(type == "stop")
                {
                    break;
                }
                quantity = int.Parse(Console.ReadLine());
                if (dict.ContainsKey(type))
                {
                    dict[type] = dict[type] + quantity;
                }
                else
                {
                    dict.Add(type, quantity);
                }
            }
            foreach (KeyValuePair<string, int> ele1 in dict)
            {
                Console.WriteLine("{0} -> {1}",
                          ele1.Key, ele1.Value);
            }
        }
    }
}
