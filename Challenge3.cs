using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) {
        int i,j;
        int n = Convert.ToInt32(Console.ReadLine());
        int[][] a = new int[n][];
        for(int a_i = 0; a_i < n; a_i++){
           string[] a_temp = Console.ReadLine().Split(' ');
           a[a_i] = Array.ConvertAll(a_temp,Int32.Parse);
        }
        
     int sumOfDiagonal1 = 0, sumOfDiagonal2 = 0;
            
            for(i=0;i<n;i++)
            {
             for(j=0;j<n;j++)
             {
                 if(i==j)
                 {
                    sumOfDiagonal1 += a[i][j];    
                 }
             }   
            }
            
            for(i=0;i<n;i++)
            {
                sumOfDiagonal2 += a[i][n-i-1];    
            }
         
            
            int difference = sumOfDiagonal1 - sumOfDiagonal2;
            int absoluteDifference = Math.Abs(difference);
            
            Console.WriteLine(absoluteDifference);
    }
}
