using System;
using System.Linq;

class Difference 
{
    private int[] elements;
    public int maximumDifference;
    
    public Difference(int[] e)
    {
        this.elements = e;
    }

    public int computeDifference()
    {
      int a = elements.Max(x => Math.Abs(x));
      int b = elements.Min(x => Math.Abs(x));
      
        maximumDifference = a - b;
      
        return maximumDifference;
    }
 } 

class Solution 
{
    static void Main(string[] args)
    {
        Convert.ToInt32(Console.ReadLine());
        
        int[] a = Console.ReadLine().Split(' ').Select(x=>Convert.ToInt32(x)).ToArray();
        
        Difference d = new Difference(a);
        
        d.computeDifference();
        
        Console.Write(d.maximumDifference);
    }
}
