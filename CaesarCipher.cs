using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackeRankPrograms
{
    class CaesarCipher
    {

        static void Main()
        {

            string str1 = "abcdefghijklmnopqrstuvwxyz";

            string str3 = "ABCDEFGHIJKLMNOPQRSTUVWXYZ";
            string str2 = str1.Substring(2, str1.Length-2) + str1.Substring(0, 2);

            string rotstr = "middle-Outz";

           
                    for (int i = 0; i < rotstr.Length; i++)
                    {

                if ((rotstr[i] >= 'a' && rotstr[i] <= 'z') )
                {
                    for (int j = 0; j < str1.Length; j++)
                    {
                        if (rotstr[i] == str1[j])
                        {
                            Console.Write(str2[j]);
                        }
                    }


                }

                

                else { Console.Write(rotstr[i]); }
                        
                    }
            Console.WriteLine();

                
            }


            

        }
    }

