using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackeRankPrograms
{
    class TwoCharsFinal
    {
        static void Main()
        {

            /*
             
             Hacker Rank Link : https://www.hackerrank.com/challenges/two-characters/problem

             In this challenge, you will be given a string. 
             You must remove characters until the string is made up of any two alternating characters.
             When you choose a character to remove, all instances of that character must be removed. 
             Your goal is to create the longest string possible that contains just two alternating letters.
             
            Sample Input : beabeefeab
            Output :      5(Lenght of the string "babab" )

            Logic :   First we need to identify the unique chars (b,e,a,f) from the given string using dictionary or any other method
                      start deleting the paif of chars in all combinations and get the string and check whether alternate chars are same or not if they are same print the length of the string  
              
             
             */

            int size = Convert.ToInt32(Console.ReadLine());
            string input = Console.ReadLine();
            string tempstr = "";

            List<string> resstring = new List<string>();

            
            var dict = new Dictionary<char, int>();

            if (size==2)
            {
                Console.WriteLine(size);
            }


            else
            {
                foreach (var item in input)
                {
                    if (dict.ContainsKey(item))
                    {
                        dict[item]++;
                    }

                    else
                    {
                        dict.Add(item, 1);
                    }
                }

                var keys = dict.Keys.ToArray();

                for (int i = 0; i < keys.Length - 1; i++)
                {
                    for (int j = i + 1; j < keys.Length; j++)
                    {

                        tempstr = input.Replace(keys[i].ToString(), "");
                        tempstr = tempstr.Replace(keys[j].ToString(), "");
                        //Console.WriteLine(tempstr);

                        resstring.Add(tempstr);

                          
                    }



                }
                bool alternate = false;

                int maxlength = 0;
                foreach (var item in resstring)
                {
                    for (int i = 0; i < item.Length / 2; i++)
                    {
                        if (item[i] != item[i + 2])
                        {
                            alternate = false;
                            break;
                        }

                        else { alternate = true; ; }
                    }

                    if (alternate)
                    {
                        if (item.Length > maxlength)
                        {
                            maxlength = item.Length;
                        }

                    }


                }

                Console.WriteLine(maxlength); 
            }

            


        }
    }
}
