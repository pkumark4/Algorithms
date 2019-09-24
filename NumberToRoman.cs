using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackeRankPrograms
{
    class NumberToRoman
    {
        static void Main()
        {

            /*
             
             This program converts the given integer number to corresponding Roman Number

            Eg : 10  => x
                 15  => xv
                 55  => LV

            Logic :  1. Define basevalues for for numbers and corresponding roman numerals
                     2. If given number is greater than get corresponding roman numeral in that index
                     3. then subtract the basevalue from the number to reduce the number
                     4. Repeat this process until the number becomes zero
                     
            Eg : consider if we are trying to find the roman number for 132

           
             
             
             */
            
            int number = 132;

            StringBuilder numeral = new StringBuilder();

            int[] basevalues =       { 1000, 900, 500, 400, 100, 90, 50, 40, 10, 9, 5, 4, 1 };
            string[] romannumerals = { "M", "CM", "D", "CD", "C", "XC", "L", "XL", "X", "IX", "V", "IV", "I" };

            if (number > 3999)
            {
                Console.WriteLine("Enter a number between 1 and 3999");
            }

            else
            {
                int i = 0;

                while (number>0)
                {
                    if (number - basevalues[i] >= 0)  // this condition satisfies at index 4 for value 100, 
                    {
                        numeral.Append(romannumerals[i]); // numeral = C (correspoding roman value)
                        number -= basevalues[i];  // number = 132-100 =32
                    }
                    else i++; // increment the index
                }

            }

            Console.WriteLine(numeral.ToString());


            
            

        }
    }
}
