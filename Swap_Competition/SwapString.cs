using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Swap_Competition
{
    public class SwapString
    {
        public bool AreEqual(string firstString, string secondString)
        {
            if (firstString.Length != secondString.Length)
            {
                return false;
            }
            //Convert string to character array  
            char[] firstCharArray = firstString.ToLower().ToCharArray();
            char[] secondCharArray = secondString.ToLower().ToCharArray();
          
            //Sort array  
            Array.Sort(firstCharArray);
            Array.Sort(secondCharArray);
            bool flag = false;
            char temp;
            //Check each characters of strings are equal or not  
            for (int i = 0; i < firstCharArray.Length - 1; i++)
            {
                for (int j = 0; j < secondCharArray.Length - 1; j++)
                {

                    temp = firstCharArray[i];
                    firstCharArray[i] = secondCharArray[j];
                    secondCharArray[j] = temp;
                    string s1 = new string(firstCharArray);
                    string s2 = new string(secondCharArray);

                    if (s1 == s2)
                    {
                        flag = true;
                        break;
                    }
                }
                if (flag)
                    break;
            }
            return flag;
        }
          
    }
}
