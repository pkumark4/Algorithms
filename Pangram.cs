using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackeRankPrograms
{
    class Pangram
    {
        static void Main()
        {


            /*
             
             This program checks if the given string is a panagram or not
             Panagram => String with letters a-z 
             Eg: The quick brown fox jumps over the lazy dog
             
            Logic :  We defined one string with a-z and verified whether letters of input string contains alphabets a-z

             
             */

            string s1 = "abcdefghijklmnopqrstuvwxyz";


            string ip = "We promptly judged antique ivory buckles for the prize";


            bool flag = false;
            for(int i=0;i<s1.Length;i++)

            {
                if (!ip.Contains(s1[i]))

                {
                    flag = true;
                   
                    break;
                }


            }

            if (flag)
            { Console.WriteLine("not panagram"); }
            else
            { Console.WriteLine("pangram" ); 
               
                }
                
          
            Console.ReadLine();
        }
    }
}
