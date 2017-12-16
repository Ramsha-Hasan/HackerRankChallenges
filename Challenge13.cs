using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) 
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int remainder = 0;
        int quotient = 0;
        string result = string.Empty;
        int countNumOfOnes = 0;
        int max = 0;
        
       
        while (n >= 1)
        {
            remainder = n%2;
            if(remainder == 1)
            {
                countNumOfOnes++;  
                    if(countNumOfOnes > max)
                     max = countNumOfOnes;  
            }
            else if(remainder == 0)
            {
               countNumOfOnes = 0;     
            }
            quotient = n = n/2;
            result = remainder.ToString() + result;
        }
       
           //Console.WriteLine(result);
        
        Console.WriteLine(max);
    }
}
