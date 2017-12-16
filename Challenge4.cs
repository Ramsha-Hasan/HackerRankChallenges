using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        decimal zeroCount = 0;
        decimal posCount = 0;
        decimal negCount = 0;
        int n = Convert.ToInt32(Console.ReadLine());
        decimal temp = (decimal)1/n;
        string[] arr_temp = Console.ReadLine().Split(' ');
        int[] arr = Array.ConvertAll(arr_temp,Int32.Parse);
     
        foreach (int element in arr)
        {
            if(element == 0)
            {
                    zeroCount++;
            } 
            
            else if(element > 0)
            {
                    posCount++;    
            }
            
            else if(element < 0)
            {
                   negCount++;    
            }
        }
        decimal posFraction = posCount*temp;
        decimal negFraction = negCount*temp;
        decimal zeroFraction = zeroCount*temp;
        
         Console.WriteLine(Math.Round(posFraction,5));
         Console.WriteLine(Math.Round(negFraction,5));
         Console.WriteLine(Math.Round(zeroFraction,5));
       }
}
