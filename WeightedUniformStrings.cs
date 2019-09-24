using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackeRankPrograms
{
    class WeightedUniformStrings
    {
        static void Main()
        {

            string str = Console.ReadLine();
            //int queries = Convert.ToInt32(Console.ReadLine());

            int weight = 0;

            string alphabets = "abcdefghijklmnopqrstuvwxyz";


            // Logic to find the weights of uniform strings

            var dt = new Dictionary<char, int>();

            foreach (var item in str)
            {
                if (dt.ContainsKey(item))
                {
                    dt[item]++;
                }

                else
                {
                    dt.Add(item, 1);
                }
            }




        }

    }
}
