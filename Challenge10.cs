using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] getRecord(int[] s)
    {
     var maxCount = 0;
     var minCount = 0;
     var maxRecord = s[0];
     var minRecord = s[0];
        
     for(int i=1; i<s.Length; i++)
     {
         if(s[i] > maxRecord)
         {
            maxRecord = s[i];
            maxCount++;
         }
         
           if(s[i] < minRecord)
         {
            minRecord = s[i];
            minCount++;
         }
     }
       
       return new int[] {maxCount, minCount};
        
    }

    static void Main(String[] args) {
        Console.ReadLine();
        string[] s_temp = Console.ReadLine().Split(' ');
        int[] s = Array.ConvertAll(s_temp,Int32.Parse);
        int[] result = getRecord(s);
        Console.WriteLine(String.Join(" ", result));
    }
}
