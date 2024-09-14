// using System;
// using System.Linq;
namespace DotnetDSA.Entities;

public class PairSum()
{
   //https://www.structy.net/problems/pair-sum
   private static List<int> Evaluate(List<int> array, int target)
   {
      var map = new Dictionary<int, int>();

      for (int i = 0; i < array.Count; i++)
      {
         int remainder = target - array[i];

         if (map.ContainsKey(remainder))
         {
            return [map[remainder], i];
         }
         map.Add(array[i], i);
      }

      return [];
   }

   public void Run()
   {
      var testCases = new Dictionary<int, List<int>>()
      {
         {8, [3, 2, 5, 4, 1]},
         {5, [4, 7, 9, 2, 5, 1]},
         {3, [4, 7, 9, 2, 5, 1]},
         {13, [1, 6, 7, 2]},
         {18, [9, 9]},
         {12, [6, 4, 2, 8]},
      };

      Console.WriteLine($"\n>> Running {GetType().Name} function <<");
      foreach (var testCase in testCases)
      {
         string values = string.Join(",", testCase.Value);
         Console.WriteLine($"{testCase.Key} > {values} | {string.Join(",", Evaluate(testCase.Value, testCase.Key))}");
      }
   }
}