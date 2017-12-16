using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution 
{

    static void Main(String[] args) 
    {
      
      var appleCount = 0;
      var orangeCount = 0;
        
     var homePosition = Console.ReadLine().Split(' ');
     var s = int.Parse(homePosition[0]);
     var t = int.Parse(homePosition[1]);
        
     var treePosition = Console.ReadLine().Split(' ');
     var a = int.Parse(treePosition[0]);
     var b = int.Parse(treePosition[1]);
     
     Console.ReadLine();
         
	var apple_temp = Console.ReadLine().Split(' ');
    var distanceApple = Array.ConvertAll(apple_temp,Int32.Parse);
        
	var orange_temp = Console.ReadLine().Split(' ');
    var distanceOrange = Array.ConvertAll(orange_temp,Int32.Parse);
        
        
    foreach(var fallenApples in distanceApple)
    {
        var fallenApplesPosition = fallenApples + a;
        if(fallenApplesPosition >= s && fallenApplesPosition <= t)
        {
            appleCount++;    
        }
    }
        
      foreach(var fallenOranges in distanceOrange)
    {
        var fallenOrangesPosition = fallenOranges + b;
        if(fallenOrangesPosition >= s && fallenOrangesPosition <= t)
        {
            orangeCount++;    
        }
    }
        
      Console.WriteLine(appleCount);
      Console.WriteLine(orangeCount);
     
       
    }
    
}
