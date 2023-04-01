using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            Dictionary<string, string> dict = new Dictionary<string, string>();
            while (true)
            {
                input = Console.ReadLine().Split(' ').ToArray();
                if (input[0] == "A")
                {
                    if (dict.ContainsKey(input[1]))
                    {
                        dict[input[1]] = input[2];
                    }
                    else
                    {
                        dict.Add(input[1], input[2]);
                    }
                }
                else if (input[0] == "S")
                {
                    if (dict.ContainsKey(input[1]))
                    {
                        Console.WriteLine("{0} -> {1}", input[1],dict[input[1]]);
                    }
                    else
                    {
                        Console.WriteLine("Contact {0} does not exist", input[1]);
                    }
                }
                else
                {
                    break;
                }
            }
        }
    }
}
