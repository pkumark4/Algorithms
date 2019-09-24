using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackeRankPrograms
{
    class SepearateTheStrings
    {
        
        static void Main(String[] args)
        {
            
           int start;

            int q = Convert.ToInt32(Console.ReadLine());

            while (q>0)
            {
                string inputstr = Console.ReadLine();

                if (inputstr.Length == 1)
                {
                    Console.WriteLine("NO");
                }
                else
                {
                    for (int i = 0; i < inputstr.Length / 2; i++)
                    {
                        string newstr = inputstr.Substring(0, i + 1);
                        int num = Convert.ToInt32(newstr);

                        start = num;

                        while (newstr.Length < inputstr.Length)
                        {
                            num++;
                            newstr += String.Join("", num);
                        }

                        if (inputstr.Equals(newstr))
                        {
                            Console.WriteLine("YES {0}", start);
                            break;


                        }
                        else if ((i == inputstr.Length / 2 - 1) && (!inputstr.Equals(newstr)))
                        { Console.WriteLine("NO"); }
                        else continue;



                    }

                }
            }
            q--;
            
        }
    }
}
