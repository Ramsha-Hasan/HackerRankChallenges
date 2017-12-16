using System;
using System.Collections.Generic;
using System.IO;
class Solution 
{
    static void Main(String[] args) 
    {   
        string s = "";
        int n = Convert.ToInt32(Console.ReadLine());
        for(int i=0; i<=n-1; i++)
        {
            s = Console.ReadLine();
            
            for(int j=0; j<=s.Length-1; j++)
            {
                if(j%2==0)
                {
                    Console.Write(s[j]);  
                }
                
            }
            
            Console.Write(" ");
            
            for(int j=0; j<=s.Length-1; j++)
            {
                if(j%2!=0)
                {
                    Console.Write(s[j]);  
                }     
            }
            
            Console.WriteLine(" ");
        }
    }
}
