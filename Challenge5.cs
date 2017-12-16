using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static void Main(String[] args) 
    {
        int i,j;
        
        int n = Convert.ToInt16(Console.ReadLine());
        
        for(i=1; i<=n; i++)
        {
            for(j=1; j<=n; j++)
            {
                if(j<=n-i)
                {
                    Console.Write(" ");    
                }    
                else
                {
                    Console.Write("#");    
                }
            } 
            Console.WriteLine();
        }
        
    }
}
