using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackeRankPrograms
{
    class MakeAnagrams
    {
        static void Main()
        {
            /*
             
            Hakcer Rank Link : https://www.hackerrank.com/challenges/making-anagrams/problem
             This program returns number of deletions required to make anagrams from given two strings
             Anagram : two strings should have same letters with equal frequency
             Eg : bacdc and cadbc are anagrams but bacdc and cabd are not anagrams ('c' appeared twice in first string but once in second string)

            Sample Input: string1 : abcdefgh , string3 : abcd
            
             Output : After 4 (e,f,g,h)deletions in first string both becomes anagrams

            Logic :  declare two integer arrays of size 128 for both strings and fill in the occurance of each character
                     If arr1[item]!=arr2[item] get the difference which is equal to number of deletions need to make them anagrams
             
             */

            string st1 = Console.ReadLine();
            string st2 = Console.ReadLine();

            int delvar = 0;

            int[] arr1 = new int [128];
            int[] arr2 = new int[128];

            foreach (var item in st1)
            {
                int val = (int)item;
                arr1[val]++;
            }

            foreach (var item1 in st2)
            { 
                int val1 = (int)item1;
                arr2[val1]++;
            }

            for(int j=0;j<=127;j++)

            {
                if (arr1[j] != arr2[j])

                {
                        delvar+= Math.Abs(arr1[j] - arr2[j]);
                }

            }

            Console.WriteLine(delvar);
            Console.ReadLine();


        }
    }
}
