using System;
using System.Collections.Generic;
using System.Linq;
class TwoChars
{


    public int longesttwocharstringlength(string input)
    {
        
        var returnString = string.Empty;

        if (input.Length <= 2)

            return input.Length;

        else if (input.Length == 3)

        {

            if (input[0] == input[2] && input[0] != input[1])

                return input.Length;

        }

        else if (input.Length == 4 && input.Substring(0, 2) == input.Substring(2, 2))

        {

            return input.Length;

        }

        else

        {

            var dt = new Dictionary<char, int>();

            foreach (var ele in input)

            {

                if (dt.ContainsKey(ele))

                    dt[ele]++;

                else

                    dt.Add(ele, 1);



            }

            var dtKeys = dt.Keys.ToArray();
            
            for (int k = 0; k < dtKeys.Length - 1; k++)

            {
                
                for (int l = k + 1; l < dtKeys.Length; l++)

                {

                    var tempStr = input.Replace(dtKeys[k].ToString(), "");

                    tempStr = tempStr.Replace(dtKeys[l].ToString(), "");

                    int i = 2;

                    int indexI = -1;

                    var indexJ = -1;

                    while (i < tempStr.Length)

                    {

                        if (tempStr[i] == tempStr[0] && i % 2 == 0)

                        {

                            indexI = i;

                            i += 1;

                        }

                        else if (tempStr[i] == tempStr[1] && i % 2 == 1)

                        {

                            indexJ = i;

                            i += 1;

                        }

                        else

                            break;

                    }

                    Console.WriteLine(tempStr);

                    var finalIndex = -1;

                    if (indexI > indexJ)

                    {

                        finalIndex = (indexI - indexJ > 1) ? (

                         indexI - (indexI - indexJ) + 1) : (indexI);

                    }

                    else if (indexJ > indexI)

                    {

                        finalIndex = (indexJ - indexI > 1) ? (indexJ - (indexJ - indexI) + 1) : indexJ;

                    }



                    var tempStrlen = tempStr.Substring(0, finalIndex + 1);

                    if (tempStrlen.Length > returnString.Length)

                    {

                        returnString = tempStrlen;

                    }



                }

            }

        }



        return returnString.Length;

    }

    static void Main(String[] args)
    {



        TwoChars tc = new TwoChars();
        int len= tc.longesttwocharstringlength("beabeefeab");
        Console.WriteLine(len);





    }
}