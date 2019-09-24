using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackeRankPrograms
{
    class Anagram
    {
        static void Main()
        {


            int q = Convert.ToInt32(Console.ReadLine());
            


            int[] arr1 = new int[128];
            int[] arr2 = new int[128];

            while (q>0)
            {
                
                string str = Console.ReadLine();

                if (str.Length%2==1)
                {
                    Console.WriteLine("-1");
                }


                else
                {
                    int counter = 0;

                     
                    string st1 = str.Substring(0, str.Length / 2);


                    string st2 = str.Substring(str.Length / 2, str.Length / 2);

                    string unique="";

                    for (int i = 0; i < st2.Length; i++)
                    {
                        if (!unique.Contains(st2[i]))
                        {
                            unique += st2[i];
                        }
                    }
                    

                    foreach (var item in st1)
                    {
                        arr1[item]++;
                    }
                    foreach (var item in st2)
                    {
                        arr2[item]++;
                    }

                    

                    foreach (var item in unique)
                    {
                        if (st1.Contains(item.ToString()))
                        {
                            if ((arr2[item] != arr1[item]))
                            {
                                counter += Math.Abs(arr2[item] - arr1[item]);
                            }

                            
                        }

                        else if (!st1.Contains(item.ToString()))
                        {
                            //Console.WriteLine("st1 not contains an element from st2");
                            counter += arr2[item];
                        }

                    }

                    Console.WriteLine(counter);  
                }
            }
        }
    }
}
