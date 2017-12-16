using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Solution {
   
    static int[] solve(int[] grades)
    {
       for(int i=0; i<grades.Length; i++){
           if(grades[i] >= 38)
           {
                  int remainder = grades[i]%5;
                  int difference = 5 - remainder;
                  if(difference < 3){
                  grades[i] = grades[i] + difference;
                 
               }
           }
       } 
        return grades;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        int[] grades = new int[n];
        for (int grades_i = 0; grades_i < n; grades_i++)
        grades[grades_i] = Convert.ToInt32(Console.ReadLine());
        int[] result = solve(grades);
        Console.WriteLine(String.Join("\n", result));
    }
}


/*
logic of getting next multiple of 5 of grade[i]   ------  grade[i] = 46
int remainder = grade[i] % 5;         ----> 46 % 5 = 1 
int difference = 5 - remainder;       ----> 5 - 1 = 4
int nextMultiple = grade[i] + difference; -> 46 + 4 = 50
*/
