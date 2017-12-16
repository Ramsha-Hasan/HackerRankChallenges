using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {

    static int[] solve(int a0, int a1, int a2, int b0, int b1, int b2)
    {
        int[] Alice = {a0, a1, a2};
        int[] Bob = {b0, b1, b2};
        
        int alicePoint = 0;
        int bobPoint = 0;
        
        for(int i=0; i<=2; i++)
        {
          if(Alice[i] > Bob[i])
          {
              alicePoint++;
          } 
          else if(Alice[i] < Bob[i])
          {
                bobPoint++;
          }
        }
        
        int[] result = {alicePoint , bobPoint};
        return result; 
    }

    static void Main(String[] args) 
    {
        string[] tokens_a0 = Console.ReadLine().Split(' ');
        int a0 = Convert.ToInt32(tokens_a0[0]);
        int a1 = Convert.ToInt32(tokens_a0[1]);
        int a2 = Convert.ToInt32(tokens_a0[2]);
        string[] tokens_b0 = Console.ReadLine().Split(' ');
        int b0 = Convert.ToInt32(tokens_b0[0]);
        int b1 = Convert.ToInt32(tokens_b0[1]);
        int b2 = Convert.ToInt32(tokens_b0[2]);
        int[] result = solve(a0, a1, a2, b0, b1, b2);
        Console.WriteLine(String.Join(" ", result));
     }
}
