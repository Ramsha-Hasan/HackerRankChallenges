using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        string[] arr_temp = Console.ReadLine().Split(' ');
        long[] arr = Array.ConvertAll(arr_temp,long.Parse);
       
        Array.Sort(arr);
       
         
        
  
            Console.Write(arr[0] + arr[1] + arr[2] + arr[3] + " ");
            Console.Write(arr[1] + arr[2] + arr[3] + arr[4]);
        

         
    }
}
