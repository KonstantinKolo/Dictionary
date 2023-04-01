using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] input;
            double sum = 0;
            Dictionary<string, int> quantity = new Dictionary<string, int>();
            Dictionary<string, double> money = new Dictionary<string, double>();
            while (true)
            {
                input = Console.ReadLine().Split(' ').ToArray();
                if(input[0] == "stocked")
                {
                    break;
                }
                else if (quantity.ContainsKey(input[0]))
                {
                    quantity[input[0]] = quantity[input[0]] + int.Parse(input[2]);
                    money[input[0]] = double.Parse(input[1]);
                }
                else
                {
                    quantity.Add(input[0], int.Parse(input[2]));
                    money.Add(input[0], double.Parse(input[1]));
                }
            }
            foreach (KeyValuePair<string, int> ele1 in quantity)
            {
                Console.WriteLine($"{ele1.Key}: ${money[ele1.Key]:F2} * {ele1.Value} = ${ele1.Value * money[ele1.Key]:F2}");
                sum += ele1.Value * money[ele1.Key];
            }
            Console.WriteLine($"------------------------------\nGrand Total: ${sum:F2}");
        }
    }
}
