using System;

namespace DotnetDSA.Entities;

public class FiveSort
{
   //https://www.structy.net/problems/five-sort
   private static List<int> Evaluate(List<int> array, int target = 5)
   {
      int left = 0;
      int right = array.Count - 1;

      while (left < right)
      {
         while (array[right] == target)
         {
            right--;
         }

         if (array[left] == 5)
         {
            array[left] = array[right];
            array[right] = 5;
            right--;
         }

         left++;
      }

      return array;
   }

   public void Run()
   {
      var testCases = new List<List<int>>
      {
          ([12, 5, 1, 5, 12, 7]),
          ([5, 2, 5, 6, 5, 1, 10, 2, 5, 5]),
          ([5, 5, 5, 1, 1, 1, 4]),
          ([5, 5, 6, 5, 5, 5, 5]),
          ([5, 1, 2, 5, 5, 3, 2, 5, 1, 5, 5, 5, 4, 5])
      };

      Console.WriteLine($"\n>> Running {GetType().Name} function <<");
      foreach (var testCase in testCases)
      {
         Console.WriteLine($"{string.Join(", ", testCase)} > {string.Join(", ", Evaluate(testCase))}");
      }
   }
}
