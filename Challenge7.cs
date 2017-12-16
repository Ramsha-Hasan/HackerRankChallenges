using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int birthdayCakeCandles(int n, int[] ar) 
    {
        int count = 1; 
      Array.Sort(ar);
       
    
        for(int i = 0; i < n-1; i++)
        {
            if(ar[n-1] == ar[i])
            {
                count++;
            }
        }
        return count;
        
    }

    static void Main(String[] args) {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp,Int32.Parse);
        int result = birthdayCakeCandles(n, ar);
        Console.WriteLine(result);
    }
}
